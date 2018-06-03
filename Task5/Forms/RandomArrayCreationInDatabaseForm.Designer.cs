namespace Task5.Forms
{
    partial class RandomArrayCreationInDatabaseForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomArrayCreationInDatabaseForm));
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbRows = new System.Windows.Forms.TextBox();
            this.tbColumns = new System.Windows.Forms.TextBox();
            this.lbRows = new System.Windows.Forms.Label();
            this.lbColumns = new System.Windows.Forms.Label();
            this.btApply = new System.Windows.Forms.Button();
            this.lbMinValue = new System.Windows.Forms.Label();
            this.lbMaxValue = new System.Windows.Forms.Label();
            this.tbMinValue = new System.Windows.Forms.TextBox();
            this.tbMaxValue = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDescription
            // 
            this.lbDescription.AutoEllipsis = true;
            resources.ApplyResources(this.lbDescription, "lbDescription");
            this.lbDescription.Name = "lbDescription";
            // 
            // tbRows
            // 
            resources.ApplyResources(this.tbRows, "tbRows");
            this.tbRows.Name = "tbRows";
            // 
            // tbColumns
            // 
            resources.ApplyResources(this.tbColumns, "tbColumns");
            this.tbColumns.Name = "tbColumns";
            // 
            // lbRows
            // 
            resources.ApplyResources(this.lbRows, "lbRows");
            this.lbRows.Name = "lbRows";
            // 
            // lbColumns
            // 
            resources.ApplyResources(this.lbColumns, "lbColumns");
            this.lbColumns.Name = "lbColumns";
            // 
            // btApply
            // 
            resources.ApplyResources(this.btApply, "btApply");
            this.btApply.Name = "btApply";
            this.btApply.UseVisualStyleBackColor = true;
            // 
            // lbMinValue
            // 
            resources.ApplyResources(this.lbMinValue, "lbMinValue");
            this.lbMinValue.Name = "lbMinValue";
            // 
            // lbMaxValue
            // 
            resources.ApplyResources(this.lbMaxValue, "lbMaxValue");
            this.lbMaxValue.Name = "lbMaxValue";
            // 
            // tbMinValue
            // 
            resources.ApplyResources(this.tbMinValue, "tbMinValue");
            this.tbMinValue.Name = "tbMinValue";
            // 
            // tbMaxValue
            // 
            resources.ApplyResources(this.tbMaxValue, "tbMaxValue");
            this.tbMaxValue.Name = "tbMaxValue";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // RandomArrayCreationInDatabaseForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbMaxValue);
            this.Controls.Add(this.tbMinValue);
            this.Controls.Add(this.lbMaxValue);
            this.Controls.Add(this.lbMinValue);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.lbColumns);
            this.Controls.Add(this.lbRows);
            this.Controls.Add(this.tbColumns);
            this.Controls.Add(this.tbRows);
            this.Controls.Add(this.lbDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RandomArrayCreationInDatabaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox tbRows;
        private System.Windows.Forms.TextBox tbColumns;
        private System.Windows.Forms.Label lbRows;
        private System.Windows.Forms.Label lbColumns;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.Label lbMinValue;
        private System.Windows.Forms.Label lbMaxValue;
        private System.Windows.Forms.TextBox tbMinValue;
        private System.Windows.Forms.TextBox tbMaxValue;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}