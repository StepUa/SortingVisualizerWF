namespace Task5.Forms
{
    partial class SortMethodsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortMethodsListForm));
            this.clbSorters = new System.Windows.Forms.CheckedListBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.btApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbSorters
            // 
            resources.ApplyResources(this.clbSorters, "clbSorters");
            this.clbSorters.BackColor = System.Drawing.SystemColors.Control;
            this.clbSorters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbSorters.CheckOnClick = true;
            this.clbSorters.FormattingEnabled = true;
            this.clbSorters.Name = "clbSorters";
            // 
            // lbDescription
            // 
            resources.ApplyResources(this.lbDescription, "lbDescription");
            this.lbDescription.Name = "lbDescription";
            // 
            // btApply
            // 
            resources.ApplyResources(this.btApply, "btApply");
            this.btApply.Name = "btApply";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // SortMethodsListForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.clbSorters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SortMethodsListForm";
            this.Load += new System.EventHandler(this.SortMethodsListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbSorters;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Button btApply;
    }
}