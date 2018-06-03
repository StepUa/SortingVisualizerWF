using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task5.Forms.Localization;

namespace Task5.Forms
{
    public partial class RandomArrayCreationInDatabaseForm : Form
    {
        private const int _minArraySize = 1;
        private const int _maxArraySize = 1000;
        private int? _minValue = null;
        private int? _maxValue = null;
        private int? _rows = null;
        private int? _columns = null;

        public RandomArrayCreationInDatabaseForm()
        {
            InitializeComponent();

            tbRows.KeyPress += TextBoxArraySizeKeyPress;
            tbRows.Validating += TextBoxArraySizeValidation;
            tbRows.Validated += TextBoxArraySizeValidated;

            tbColumns.KeyPress += TextBoxArraySizeKeyPress;
            tbColumns.Validating += TextBoxArraySizeValidation;
            tbColumns.Validated += TextBoxArraySizeValidated;

            tbMaxValue.KeyPress += TextBoxArrayRangeKeyPress;
            tbMaxValue.Validating += TextBoxArrayRangeValidation;
            tbMaxValue.Validated += TextBoxArrayRangeValidated;

            tbMinValue.KeyPress += TextBoxArrayRangeKeyPress;
            tbMinValue.Validating += TextBoxArrayRangeValidation;
            tbMinValue.Validated += TextBoxArrayRangeValidated;

            btApply.Click += ButtonApplyClick;
        }

        private void ButtonApplyClick(object sender, EventArgs e)
        {
            using (Database.SortersVisualizerDBEntities context = new Database.SortersVisualizerDBEntities())
            {
                if (!context.Database.Exists())
                {
                    MessageBox.Show(MessagesRandomArrayCreationInDatabaseForm.DatabaseDosentExistText,
                        MessagesRandomArrayCreationInDatabaseForm.DatabaseConnectionText, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.Close();
                }

                int[] array = new int[(int)_rows * (int)_columns];

                array = Tools.Utils.GetRandomArray(array.Length, (int)_minValue, (int)_maxValue);

                Database.InputArrays inputArray = new Database.InputArrays
                {
                    iNumberOfRows = (int)_rows,
                    iNumberOfColumns = (int)_columns,
                    vcInputArrayContent = string.Join(" ", array)
                };

                context.InputArrays.Add(inputArray);
                int rowsAffected = context.SaveChanges();

                if (rowsAffected > 0)
                {
                    MessageBox.Show(MessagesRandomArrayCreationInDatabaseForm.ArraySuccessfullyCreatedText,
                        MessagesRandomArrayCreationInDatabaseForm.OperationResultText, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(MessagesRandomArrayCreationInDatabaseForm.ArrayUnsuccessfullyCreatedText,
                        MessagesRandomArrayCreationInDatabaseForm.OperationResultText, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            this.Close();
        }
        /// <summary>
        /// This method checks if all information about array creation is full and if so, makes button "Apply" active.
        /// </summary>
        private void ButtonApllyEnabling()
        {
            if (_columns.HasValue && _rows.HasValue)
            {
                if (_minValue.HasValue && _maxValue.HasValue)
                {
                    btApply.Enabled = true;

                    return;
                }
            }

            btApply.Enabled = false;
        }

        private void TextBoxArraySizeKeyPress(object sender, KeyPressEventArgs e)
        {
            //  Convert.ToChar(8) = Backspace
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
        private void TextBoxArraySizeValidation(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            int value;
            string errorMsg;

            if (Int32.TryParse(textBox.Text, out value))
            {
                if (ArraySizeIsValid(value))
                {
                    return;
                }
                else
                {
                    errorMsg = MessagesRandomArrayCreationInDatabaseForm.RowsAndColumnsValidationErrorText;
                }
            }
            else
            {
                errorMsg = MessagesRandomArrayCreationInDatabaseForm.ConvertToIntegerErrorText;
            }

            e.Cancel = true;
            textBox.Select(0, textBox.Text.Length);

            errorProvider.SetError(textBox, errorMsg);
        }
        private void TextBoxArraySizeValidated(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            int value = Int32.Parse(textBox.Text);

            if (textBox == tbColumns)
            {
                _columns = value;
            }
            else if (textBox == tbRows)
            {
                _rows = value;
            }
            else
            {
                MessageBox.Show("Wrong use of array size validation", "Error in program code",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            errorProvider.SetError(textBox, string.Empty);

            ButtonApllyEnabling();
        }
        private bool ArraySizeIsValid(int value)
        {
            if (value > _maxArraySize || value < _minArraySize)
            {
                return false;
            }

            return true;
        }

        private void TextBoxArrayRangeKeyPress(object sender, KeyPressEventArgs e)
        {
            //  ToChar(8) = Backspace, ToChar(45) = '-'
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != Convert.ToChar(45))
            {
                e.Handled = true;
            }
        }
        private void TextBoxArrayRangeValidation(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            int value;
            string errorMsg;

            if (Int32.TryParse(textBox.Text, out value))
            {
                if (!string.IsNullOrEmpty(tbMinValue.Text) && !string.IsNullOrEmpty(tbMaxValue.Text))
                {
                    int minValue = Int32.Parse(tbMinValue.Text);
                    int maxValue = Int32.Parse(tbMaxValue.Text);

                    if (ArrayRangeIsValid(minValue, maxValue))
                    {
                        _minValue = minValue;
                        _maxValue = maxValue;

                        return;
                    }
                    else
                    {
                        errorMsg = MessagesRandomArrayCreationInDatabaseForm.ArrayRangeValidationErrorText;
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                errorMsg = MessagesRandomArrayCreationInDatabaseForm.ConvertToIntegerErrorText;
            }

            e.Cancel = true;
            textBox.Select(0, textBox.Text.Length);

            errorProvider.SetError(textBox, errorMsg);
        }
        private void TextBoxArrayRangeValidated(object sender, EventArgs e)
        {
            errorProvider.SetError((TextBox)sender, string.Empty);

            ButtonApllyEnabling();
        }
        private bool ArrayRangeIsValid(int minValue, int maxValue)
        {
            if (minValue >= maxValue)
            {
                return false;
            }

            return true;
        }
    }
}
