namespace Task5.Tools
{
    partial class CustomTabPageControl
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDescriptionText = new System.Windows.Forms.Label();
            this.lbSwapCountText = new System.Windows.Forms.Label();
            this.lbElementsCountText = new System.Windows.Forms.Label();
            this.lbSortingTimeText = new System.Windows.Forms.Label();
            this.lbSwapCount = new System.Windows.Forms.Label();
            this.lbElementsCount = new System.Windows.Forms.Label();
            this.lbSortingTime = new System.Windows.Forms.Label();
            this.lbSorterName = new System.Windows.Forms.Label();
            this.btRatioTimeSize = new System.Windows.Forms.Button();
            this.btRatioSwapSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDescriptionText
            // 
            this.lbDescriptionText.AutoSize = true;
            this.lbDescriptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDescriptionText.Location = new System.Drawing.Point(3, 9);
            this.lbDescriptionText.Name = "lbDescriptionText";
            this.lbDescriptionText.Size = new System.Drawing.Size(227, 17);
            this.lbDescriptionText.TabIndex = 0;
            this.lbDescriptionText.Text = "Статистика для сортувальника - ";
            // 
            // lbSwapCountText
            // 
            this.lbSwapCountText.AutoSize = true;
            this.lbSwapCountText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSwapCountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSwapCountText.Location = new System.Drawing.Point(3, 43);
            this.lbSwapCountText.Name = "lbSwapCountText";
            this.lbSwapCountText.Size = new System.Drawing.Size(176, 15);
            this.lbSwapCountText.TabIndex = 1;
            this.lbSwapCountText.Text = "Кількість здійснених обмінів:";
            this.lbSwapCountText.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            this.lbSwapCountText.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // lbElementsCountText
            // 
            this.lbElementsCountText.AutoSize = true;
            this.lbElementsCountText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbElementsCountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbElementsCountText.Location = new System.Drawing.Point(3, 69);
            this.lbElementsCountText.Name = "lbElementsCountText";
            this.lbElementsCountText.Size = new System.Drawing.Size(128, 15);
            this.lbElementsCountText.TabIndex = 2;
            this.lbElementsCountText.Text = "Кількість елементів:";
            this.lbElementsCountText.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            this.lbElementsCountText.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // lbSortingTimeText
            // 
            this.lbSortingTimeText.AutoSize = true;
            this.lbSortingTimeText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSortingTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSortingTimeText.Location = new System.Drawing.Point(3, 95);
            this.lbSortingTimeText.Name = "lbSortingTimeText";
            this.lbSortingTimeText.Size = new System.Drawing.Size(101, 15);
            this.lbSortingTimeText.TabIndex = 3;
            this.lbSortingTimeText.Text = "Час сортування:";
            this.lbSortingTimeText.MouseEnter += new System.EventHandler(this.Label_MouseEnter);
            this.lbSortingTimeText.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            // 
            // lbSwapCount
            // 
            this.lbSwapCount.AutoSize = true;
            this.lbSwapCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSwapCount.Location = new System.Drawing.Point(210, 43);
            this.lbSwapCount.Name = "lbSwapCount";
            this.lbSwapCount.Size = new System.Drawing.Size(41, 15);
            this.lbSwapCount.TabIndex = 4;
            this.lbSwapCount.Text = "label1";
            // 
            // lbElementsCount
            // 
            this.lbElementsCount.AutoSize = true;
            this.lbElementsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbElementsCount.Location = new System.Drawing.Point(210, 69);
            this.lbElementsCount.Name = "lbElementsCount";
            this.lbElementsCount.Size = new System.Drawing.Size(41, 15);
            this.lbElementsCount.TabIndex = 5;
            this.lbElementsCount.Text = "label2";
            // 
            // lbSortingTime
            // 
            this.lbSortingTime.AutoSize = true;
            this.lbSortingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSortingTime.Location = new System.Drawing.Point(210, 95);
            this.lbSortingTime.Name = "lbSortingTime";
            this.lbSortingTime.Size = new System.Drawing.Size(41, 15);
            this.lbSortingTime.TabIndex = 6;
            this.lbSortingTime.Text = "label3";
            // 
            // lbSorterName
            // 
            this.lbSorterName.AutoSize = true;
            this.lbSorterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSorterName.Location = new System.Drawing.Point(222, 9);
            this.lbSorterName.Name = "lbSorterName";
            this.lbSorterName.Size = new System.Drawing.Size(46, 17);
            this.lbSorterName.TabIndex = 7;
            this.lbSorterName.Text = "label4";
            // 
            // btRatioTimeSize
            // 
            this.btRatioTimeSize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btRatioTimeSize.Location = new System.Drawing.Point(0, 173);
            this.btRatioTimeSize.Name = "btRatioTimeSize";
            this.btRatioTimeSize.Size = new System.Drawing.Size(272, 23);
            this.btRatioTimeSize.TabIndex = 11;
            this.btRatioTimeSize.Text = "Історія сортування";
            this.btRatioTimeSize.UseVisualStyleBackColor = true;
            // 
            // btRatioSwapSize
            // 
            this.btRatioSwapSize.AutoSize = true;
            this.btRatioSwapSize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btRatioSwapSize.Location = new System.Drawing.Point(0, 150);
            this.btRatioSwapSize.Name = "btRatioSwapSize";
            this.btRatioSwapSize.Size = new System.Drawing.Size(272, 23);
            this.btRatioSwapSize.TabIndex = 12;
            this.btRatioSwapSize.Text = "Вдношення к-ть обмінів/розмір";
            this.btRatioSwapSize.UseVisualStyleBackColor = true;
            // 
            // CustomTabPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.btRatioSwapSize);
            this.Controls.Add(this.btRatioTimeSize);
            this.Controls.Add(this.lbSorterName);
            this.Controls.Add(this.lbSortingTime);
            this.Controls.Add(this.lbElementsCount);
            this.Controls.Add(this.lbSwapCount);
            this.Controls.Add(this.lbSortingTimeText);
            this.Controls.Add(this.lbElementsCountText);
            this.Controls.Add(this.lbSwapCountText);
            this.Controls.Add(this.lbDescriptionText);
            this.Name = "CustomTabPageControl";
            this.Size = new System.Drawing.Size(272, 196);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDescriptionText;
        private System.Windows.Forms.Label lbSwapCountText;
        private System.Windows.Forms.Label lbElementsCountText;
        private System.Windows.Forms.Label lbSortingTimeText;
        private System.Windows.Forms.Label lbSwapCount;
        private System.Windows.Forms.Label lbElementsCount;
        private System.Windows.Forms.Label lbSortingTime;
        private System.Windows.Forms.Label lbSorterName;
        private System.Windows.Forms.Button btRatioTimeSize;
        private System.Windows.Forms.Button btRatioSwapSize;
    }
}
