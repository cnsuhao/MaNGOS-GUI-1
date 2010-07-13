namespace MaNGOS_GUI
{
    partial class setGM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setGM));
            this.comboGMLevel = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelGMLevel = new System.Windows.Forms.Label();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.comboAccount = new MaNGOS_GUI.Controls.AccountComboBox();
            this.SuspendLayout();
            // 
            // comboGMLevel
            // 
            this.comboGMLevel.FormattingEnabled = true;
            this.comboGMLevel.Items.AddRange(new object[] {
            resources.GetString("comboGMLevel.Items"),
            resources.GetString("comboGMLevel.Items1"),
            resources.GetString("comboGMLevel.Items2")});
            resources.ApplyResources(this.comboGMLevel, "comboGMLevel");
            this.comboGMLevel.Name = "comboGMLevel";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.buttonUpdate, "buttonUpdate");
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelGMLevel
            // 
            resources.ApplyResources(this.labelGMLevel, "labelGMLevel");
            this.labelGMLevel.Name = "labelGMLevel";
            // 
            // labelAccountName
            // 
            resources.ApplyResources(this.labelAccountName, "labelAccountName");
            this.labelAccountName.Name = "labelAccountName";
            // 
            // comboAccount
            // 
            this.comboAccount.DataSource = ((object)(resources.GetObject("comboAccount.DataSource")));
            this.comboAccount.FormattingEnabled = true;
            resources.ApplyResources(this.comboAccount, "comboAccount");
            this.comboAccount.Name = "comboAccount";
            // 
            // setGM
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboAccount);
            this.Controls.Add(this.comboGMLevel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelGMLevel);
            this.Controls.Add(this.labelAccountName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "setGM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboGMLevel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelGMLevel;
        private System.Windows.Forms.Label labelAccountName;
        private MaNGOS_GUI.Controls.AccountComboBox comboAccount;
    }
}