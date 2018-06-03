using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISorterProject;
using Task5.MVC;
using Task5.Forms.Localization;

namespace Task5.Forms
{
    public partial class SortMethodsListForm : Form
    {
        Controller _formController;
        Model _formModel;

        /// <summary>
        /// Constructor for form with sort methods list
        /// </summary>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <param name="model">Model for form to operate with</param>
        public SortMethodsListForm(Model model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("model", "Viewer cannot have model as null parameter");
            }

            InitializeComponent();

            _formModel = model;
            _formController = new Controller(_formModel);
        }

        private void SortMethodsListForm_Load(object sender, EventArgs e)
        {   
            _formController.ControllerModel.LoadSorters();

            if (_formModel.LoadedSorters.Count == 0)
            {
                MessageBox.Show(MessagesSortMethodsListForm.SortingNumberIsZeroErrorText, MessagesSortMethodsListForm.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.Close();
            }

            CheckedListBoxItemsInitialization();

            FormSizeUpdate();
        }
        private void btApply_Click(object sender, EventArgs e)
        {
            if (clbSorters.CheckedIndices.Count == 0)
            {   
                return;
            }

            _formController.ControllerModel.SelectedSorters = new Sorter[clbSorters.CheckedIndices.Count];

            for (int i = 0; i < _formController.ControllerModel.SelectedSorters.Length; i++)
            {
                _formController.ControllerModel.SelectedSorters[i] = _formModel.LoadedSorters[clbSorters.CheckedIndices[i]];
            }

            this.Close();
        }
        private void CheckedListBoxItemsInitialization()
        {
            CheckedListBox.ObjectCollection clbSortersItems = clbSorters.Items;

            for (int i = 0; i < _formModel.LoadedSorters.Count; i++)
            {
                clbSortersItems.Add(_formModel.LoadedSorters[i].ToString());
            }
        }
        private void FormSizeUpdate()
        {
            // CheckedListBox height update
            clbSorters.Height += clbSorters.PreferredHeight - clbSorters.ClientSize.Height;

            // Adding space for button on the form
            int freeSpace = 10;
            this.Height += btApply.Height + freeSpace;
        }
    }
}
