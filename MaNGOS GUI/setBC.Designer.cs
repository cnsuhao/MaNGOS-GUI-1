namespace MaNGOS_GUI
{
    partial class setBC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setBC));
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelBC = new System.Windows.Forms.Label();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.comboBC = new System.Windows.Forms.ComboBox();
            this.accountComboBox1 = new MaNGOS_GUI.Controls.AccountComboBox();
            this.SuspendLayout();
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
            // labelBC
            // 
            resources.ApplyResources(this.labelBC, "labelBC");
            this.labelBC.Name = "labelBC";
            // 
            // labelAccountName
            // 
            resources.ApplyResources(this.labelAccountName, "labelAccountName");
            this.labelAccountName.Name = "labelAccountName";
            // 
            // comboBC
            // 
            this.comboBC.FormattingEnabled = true;
            this.comboBC.Items.AddRange(new object[] {
            resources.GetString("setexp_wotlk"),
            resources.GetString("setexp_bc"),
            resources.GetString("setexp_classic")});
            resources.ApplyResources(this.comboBC, "comboBC");
            this.comboBC.Name = "comboBC";
            // 
            // accountComboBox1
            // 
            this.accountComboBox1.DataSource = ((object)(resources.GetObject("accountComboBox1.DataSource")));
            this.accountComboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.accountComboBox1, "accountComboBox1");
            this.accountComboBox1.Name = "accountComboBox1";
            // 
            // setBC
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accountComboBox1);
            this.Controls.Add(this.comboBC);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelBC);
            this.Controls.Add(this.labelAccountName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "setBC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelBC;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.ComboBox comboBC;
        private MaNGOS_GUI.Controls.AccountComboBox accountComboBox1;
    }
}