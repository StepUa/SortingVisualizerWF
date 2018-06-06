namespace Task5.Forms
{
    partial class MainFormView
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormView));
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.mtsData = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsiAarrayInitialization = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsiSortMethodsList = new System.Windows.Forms.ToolStripMenuItem();
            this.DataToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mtsiRandomArrayCreation = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsiSortingStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsiLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsiEnglishLang = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsiUkrainianLang = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsiRussianLang = new System.Windows.Forms.ToolStripMenuItem();
            this.tcSorters = new System.Windows.Forms.TabControl();
            this.pStartButtonAndSpeedRegulator = new System.Windows.Forms.Panel();
            this.gbSpeedRegulator = new System.Windows.Forms.GroupBox();
            this.tbSortersSpeedRegulator = new System.Windows.Forms.TrackBar();
            this.lbSlow = new System.Windows.Forms.Label();
            this.lbFast = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.btStopSorting = new System.Windows.Forms.Button();
            this.btStartSorting = new System.Windows.Forms.Button();
            this.ssMainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.sortingTime = new System.Windows.Forms.Timer(this.components);
            this.msMainMenu.SuspendLayout();
            this.pStartButtonAndSpeedRegulator.SuspendLayout();
            this.gbSpeedRegulator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSortersSpeedRegulator)).BeginInit();
            this.ssMainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            resources.ApplyResources(this.msMainMenu, "msMainMenu");
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsData,
            this.mtsOptions});
            this.msMainMenu.Name = "msMainMenu";
            // 
            // mtsData
            // 
            resources.ApplyResources(this.mtsData, "mtsData");
            this.mtsData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsiAarrayInitialization,
            this.mtsiSortMethodsList,
            this.DataToolStripSeparator,
            this.mtsiRandomArrayCreation,
            this.mtsiSortingStatistics});
            this.mtsData.Name = "mtsData";
            // 
            // mtsiAarrayInitialization
            // 
            resources.ApplyResources(this.mtsiAarrayInitialization, "mtsiAarrayInitialization");
            this.mtsiAarrayInitialization.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromFileToolStripMenuItem,
            this.fromDatabaseToolStripMenuItem});
            this.mtsiAarrayInitialization.Name = "mtsiAarrayInitialization";
            // 
            // fromFileToolStripMenuItem
            // 
            resources.ApplyResources(this.fromFileToolStripMenuItem, "fromFileToolStripMenuItem");
            this.fromFileToolStripMenuItem.Name = "fromFileToolStripMenuItem";
            this.fromFileToolStripMenuItem.Click += new System.EventHandler(this.InitFromFileClick);
            // 
            // fromDatabaseToolStripMenuItem
            // 
            resources.ApplyResources(this.fromDatabaseToolStripMenuItem, "fromDatabaseToolStripMenuItem");
            this.fromDatabaseToolStripMenuItem.Name = "fromDatabaseToolStripMenuItem";
            this.fromDatabaseToolStripMenuItem.Click += new System.EventHandler(this.InitFromDatabaseClick);
            // 
            // mtsiSortMethodsList
            // 
            resources.ApplyResources(this.mtsiSortMethodsList, "mtsiSortMethodsList");
            this.mtsiSortMethodsList.Name = "mtsiSortMethodsList";
            this.mtsiSortMethodsList.Click += new System.EventHandler(this.SortMethodsListClick);
            // 
            // DataToolStripSeparator
            // 
            resources.ApplyResources(this.DataToolStripSeparator, "DataToolStripSeparator");
            this.DataToolStripSeparator.Name = "DataToolStripSeparator";
            // 
            // mtsiRandomArrayCreation
            // 
            resources.ApplyResources(this.mtsiRandomArrayCreation, "mtsiRandomArrayCreation");
            this.mtsiRandomArrayCreation.Name = "mtsiRandomArrayCreation";
            this.mtsiRandomArrayCreation.Click += new System.EventHandler(this.GenerateRandomArrayClick);
            // 
            // mtsiSortingStatistics
            // 
            resources.ApplyResources(this.mtsiSortingStatistics, "mtsiSortingStatistics");
            this.mtsiSortingStatistics.Name = "mtsiSortingStatistics";
            this.mtsiSortingStatistics.Click += new System.EventHandler(this.SortingStatisticsClick);
            // 
            // mtsOptions
            // 
            resources.ApplyResources(this.mtsOptions, "mtsOptions");
            this.mtsOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsiLanguage});
            this.mtsOptions.Name = "mtsOptions";
            // 
            // mtsiLanguage
            // 
            resources.ApplyResources(this.mtsiLanguage, "mtsiLanguage");
            this.mtsiLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsiEnglishLang,
            this.mtsiUkrainianLang,
            this.mtsiRussianLang});
            this.mtsiLanguage.Name = "mtsiLanguage";
            // 
            // mtsiEnglishLang
            // 
            resources.ApplyResources(this.mtsiEnglishLang, "mtsiEnglishLang");
            this.mtsiEnglishLang.CheckOnClick = true;
            this.mtsiEnglishLang.Name = "mtsiEnglishLang";
            this.mtsiEnglishLang.Click += new System.EventHandler(this.LanguageSelection);
            // 
            // mtsiUkrainianLang
            // 
            resources.ApplyResources(this.mtsiUkrainianLang, "mtsiUkrainianLang");
            this.mtsiUkrainianLang.CheckOnClick = true;
            this.mtsiUkrainianLang.Name = "mtsiUkrainianLang";
            this.mtsiUkrainianLang.Click += new System.EventHandler(this.LanguageSelection);
            // 
            // mtsiRussianLang
            // 
            resources.ApplyResources(this.mtsiRussianLang, "mtsiRussianLang");
            this.mtsiRussianLang.CheckOnClick = true;
            this.mtsiRussianLang.Name = "mtsiRussianLang";
            this.mtsiRussianLang.Click += new System.EventHandler(this.LanguageSelection);
            // 
            // tcSorters
            // 
            resources.ApplyResources(this.tcSorters, "tcSorters");
            this.tcSorters.Name = "tcSorters";
            this.tcSorters.SelectedIndex = 0;
            // 
            // pStartButtonAndSpeedRegulator
            // 
            resources.ApplyResources(this.pStartButtonAndSpeedRegulator, "pStartButtonAndSpeedRegulator");
            this.pStartButtonAndSpeedRegulator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pStartButtonAndSpeedRegulator.Controls.Add(this.gbSpeedRegulator);
            this.pStartButtonAndSpeedRegulator.Controls.Add(this.lbTimer);
            this.pStartButtonAndSpeedRegulator.Controls.Add(this.btStopSorting);
            this.pStartButtonAndSpeedRegulator.Controls.Add(this.btStartSorting);
            this.pStartButtonAndSpeedRegulator.Name = "pStartButtonAndSpeedRegulator";
            // 
            // gbSpeedRegulator
            // 
            resources.ApplyResources(this.gbSpeedRegulator, "gbSpeedRegulator");
            this.gbSpeedRegulator.Controls.Add(this.tbSortersSpeedRegulator);
            this.gbSpeedRegulator.Controls.Add(this.lbSlow);
            this.gbSpeedRegulator.Controls.Add(this.lbFast);
            this.gbSpeedRegulator.Name = "gbSpeedRegulator";
            this.gbSpeedRegulator.TabStop = false;
            // 
            // tbSortersSpeedRegulator
            // 
            resources.ApplyResources(this.tbSortersSpeedRegulator, "tbSortersSpeedRegulator");
            this.tbSortersSpeedRegulator.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbSortersSpeedRegulator.Name = "tbSortersSpeedRegulator";
            this.tbSortersSpeedRegulator.Value = 10;
            this.tbSortersSpeedRegulator.ValueChanged += new System.EventHandler(this.SortingSpeedRegulatorValueChange);
            // 
            // lbSlow
            // 
            resources.ApplyResources(this.lbSlow, "lbSlow");
            this.lbSlow.Name = "lbSlow";
            // 
            // lbFast
            // 
            resources.ApplyResources(this.lbFast, "lbFast");
            this.lbFast.Name = "lbFast";
            // 
            // lbTimer
            // 
            resources.ApplyResources(this.lbTimer, "lbTimer");
            this.lbTimer.Name = "lbTimer";
            // 
            // btStopSorting
            // 
            resources.ApplyResources(this.btStopSorting, "btStopSorting");
            this.btStopSorting.Name = "btStopSorting";
            this.btStopSorting.UseVisualStyleBackColor = true;
            this.btStopSorting.Click += new System.EventHandler(this.ButtonStopSortingClick);
            // 
            // btStartSorting
            // 
            resources.ApplyResources(this.btStartSorting, "btStartSorting");
            this.btStartSorting.Name = "btStartSorting";
            this.btStartSorting.UseVisualStyleBackColor = true;
            this.btStartSorting.Click += new System.EventHandler(this.ButtonStartSortingClick);
            // 
            // ssMainStatusStrip
            // 
            resources.ApplyResources(this.ssMainStatusStrip, "ssMainStatusStrip");
            this.ssMainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.ssMainStatusStrip.Name = "ssMainStatusStrip";
            // 
            // tsslStatus
            // 
            resources.ApplyResources(this.tsslStatus, "tsslStatus");
            this.tsslStatus.Name = "tsslStatus";
            // 
            // sortingTime
            // 
            this.sortingTime.Interval = 500;
            this.sortingTime.Tick += new System.EventHandler(this.TimerTick);
            // 
            // MainFormView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ssMainStatusStrip);
            this.Controls.Add(this.pStartButtonAndSpeedRegulator);
            this.Controls.Add(this.tcSorters);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "MainFormView";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.pStartButtonAndSpeedRegulator.ResumeLayout(false);
            this.pStartButtonAndSpeedRegulator.PerformLayout();
            this.gbSpeedRegulator.ResumeLayout(false);
            this.gbSpeedRegulator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSortersSpeedRegulator)).EndInit();
            this.ssMainStatusStrip.ResumeLayout(false);
            this.ssMainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mtsOptions;
        private System.Windows.Forms.TabControl tcSorters;
        private System.Windows.Forms.Panel pStartButtonAndSpeedRegulator;
        private System.Windows.Forms.Button btStartSorting;
        private System.Windows.Forms.TrackBar tbSortersSpeedRegulator;
        private System.Windows.Forms.StatusStrip ssMainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.Button btStopSorting;
        private System.Windows.Forms.Label lbFast;
        private System.Windows.Forms.Label lbSlow;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.ToolStripMenuItem mtsiLanguage;
        private System.Windows.Forms.ToolStripMenuItem mtsiEnglishLang;
        private System.Windows.Forms.ToolStripMenuItem mtsiUkrainianLang;
        private System.Windows.Forms.ToolStripMenuItem mtsiRussianLang;
        private System.Windows.Forms.GroupBox gbSpeedRegulator;
        private System.Windows.Forms.ToolStripMenuItem mtsData;
        private System.Windows.Forms.ToolStripMenuItem mtsiAarrayInitialization;
        private System.Windows.Forms.ToolStripMenuItem fromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mtsiSortMethodsList;
        private System.Windows.Forms.ToolStripSeparator DataToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem mtsiRandomArrayCreation;
        private System.Windows.Forms.Timer sortingTime;
        private System.Windows.Forms.ToolStripMenuItem mtsiSortingStatistics;
    }
}

