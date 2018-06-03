namespace Task5.Forms
{
    partial class ArrayInitializationFromDatabaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArrayInitializationFromDatabaseForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatabaseContent = new System.Windows.Forms.DataGridView();
            this.columnArrayId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNumberOfRows = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNumberOfColumns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plHeader = new System.Windows.Forms.Panel();
            this.btApply = new System.Windows.Forms.Button();
            this.lbDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabaseContent)).BeginInit();
            this.plHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatabaseContent
            // 
            resources.ApplyResources(this.dgvDatabaseContent, "dgvDatabaseContent");
            this.dgvDatabaseContent.AllowUserToAddRows = false;
            this.dgvDatabaseContent.AllowUserToDeleteRows = false;
            this.dgvDatabaseContent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatabaseContent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatabaseContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabaseContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnArrayId,
            this.columnNumberOfRows,
            this.columnNumberOfColumns});
            this.dgvDatabaseContent.MultiSelect = false;
            this.dgvDatabaseContent.Name = "dgvDatabaseContent";
            this.dgvDatabaseContent.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvDatabaseContent.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatabaseContent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // columnArrayId
            // 
            resources.ApplyResources(this.columnArrayId, "columnArrayId");
            this.columnArrayId.Name = "columnArrayId";
            this.columnArrayId.ReadOnly = true;
            // 
            // columnNumberOfRows
            // 
            resources.ApplyResources(this.columnNumberOfRows, "columnNumberOfRows");
            this.columnNumberOfRows.Name = "columnNumberOfRows";
            this.columnNumberOfRows.ReadOnly = true;
            // 
            // columnNumberOfColumns
            // 
            resources.ApplyResources(this.columnNumberOfColumns, "columnNumberOfColumns");
            this.columnNumberOfColumns.Name = "columnNumberOfColumns";
            this.columnNumberOfColumns.ReadOnly = true;
            // 
            // plHeader
            // 
            resources.ApplyResources(this.plHeader, "plHeader");
            this.plHeader.Controls.Add(this.btApply);
            this.plHeader.Controls.Add(this.lbDescription);
            this.plHeader.Name = "plHeader";
            // 
            // btApply
            // 
            resources.ApplyResources(this.btApply, "btApply");
            this.btApply.Name = "btApply";
            this.btApply.UseVisualStyleBackColor = true;
            // 
            // lbDescription
            // 
            resources.ApplyResources(this.lbDescription, "lbDescription");
            this.lbDescription.Name = "lbDescription";
            // 
            // ArrayInitializationFromDatabaseForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plHeader);
            this.Controls.Add(this.dgvDatabaseContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArrayInitializationFromDatabaseForm";
            this.Load += new System.EventHandler(this.ArrayInitializationFromDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabaseContent)).EndInit();
            this.plHeader.ResumeLayout(false);
            this.plHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatabaseContent;
        private System.Windows.Forms.Panel plHeader;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnArrayId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumberOfRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumberOfColumns;
    }
}