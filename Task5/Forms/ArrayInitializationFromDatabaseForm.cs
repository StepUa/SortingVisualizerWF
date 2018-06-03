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
    public partial class ArrayInitializationFromDatabaseForm : Form
    {
        private int? _arrayIdFromDatabase = null;
        private int _arrayIdFromDatabaseTMPContainer;

        public ArrayInitializationFromDatabaseForm()
        {
            InitializeComponent();

            btApply.Click += btApply_Click;
            dgvDatabaseContent.CellClick += dgvDatabaseContent_CellClick;
        }

        public int? ArrayIdFormDatabase
        {
            get
            {
                return _arrayIdFromDatabase;
            }
        }

        private void ArrayInitializationFromDatabase_Load(object sender, EventArgs e)
        {
            DataGridViewInitialization();
        }
        private void DataGridViewInitialization()
        {
            using (Database.SortersVisualizerDBEntities context = new Database.SortersVisualizerDBEntities())
            {
                if (!context.Database.Exists())
                {
                    MessageBox.Show(MessagesArrayInitializationFromDatabaseForm.DatabaseDosentExistText,
                        MessagesArrayInitializationFromDatabaseForm.DatabaseConnectionText,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.Close();
                }

                var inputArrays = (from item in context.InputArrays
                                   select new { item.iInputArrayId, item.iNumberOfColumns, item.iNumberOfRows }).ToList();

                foreach (var item in inputArrays)
                {
                    dgvDatabaseContent.Rows.Add(item.iInputArrayId, item.iNumberOfRows, item.iNumberOfColumns);
                }

                dgvDatabaseContent.ClearSelection();
            }
        }
        private void dgvDatabaseContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _arrayIdFromDatabaseTMPContainer = (int)dgvDatabaseContent["columnArrayId", e.RowIndex].Value;
                btApply.Enabled = true;
            }
        }
        private void btApply_Click(object sender, EventArgs e)
        {
            _arrayIdFromDatabase = _arrayIdFromDatabaseTMPContainer;

            this.Close();
        }
    }
}
