namespace MaNGOS_GUI
{
    partial class serverShutdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serverShutdown));
            this.textShutdownDelay = new System.Windows.Forms.TextBox();
            this.labelShutdownDelay = new System.Windows.Forms.Label();
            this.buttonIdleShutdown = new System.Windows.Forms.Button();
            this.buttonDelayedShutdown = new System.Windows.Forms.Button();
            this.buttonCancelShutdown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textShutdownDelay
            // 
            resources.ApplyResources(this.textShutdownDelay, "textShutdownDelay");
            this.textShutdownDelay.Name = "textShutdownDelay";
            // 
            // labelShutdownDelay
            // 
            resources.ApplyResources(this.labelShutdownDelay, "labelShutdownDelay");
            this.labelShutdownDelay.Name = "labelShutdownDelay";
            // 
            // buttonIdleShutdown
            // 
            resources.ApplyResources(this.buttonIdleShutdown, "buttonIdleShutdown");
            this.buttonIdleShutdown.Name = "buttonIdleShutdown";
            this.buttonIdleShutdown.UseVisualStyleBackColor = true;
            this.buttonIdleShutdown.Click += new System.EventHandler(this.buttonIdleShutdown_Click);
            // 
            // buttonDelayedShutdown
            // 
            resources.ApplyResources(this.buttonDelayedShutdown, "buttonDelayedShutdown");
            this.buttonDelayedShutdown.Name = "buttonDelayedShutdown";
            this.buttonDelayedShutdown.UseVisualStyleBackColor = true;
            this.buttonDelayedShutdown.Click += new System.EventHandler(this.buttonDelayedShutdown_Click);
            // 
            // buttonCancelShutdown
            // 
            resources.ApplyResources(this.buttonCancelShutdown, "buttonCancelShutdown");
            this.buttonCancelShutdown.Name = "buttonCancelShutdown";
            this.buttonCancelShutdown.UseVisualStyleBackColor = true;
            this.buttonCancelShutdown.Click += new System.EventHandler(this.buttonCancelShutdown_Click);
            // 
            // serverShutdown
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCancelShutdown);
            this.Controls.Add(this.buttonDelayedShutdown);
            this.Controls.Add(this.buttonIdleShutdown);
            this.Controls.Add(this.textShutdownDelay);
            this.Controls.Add(this.labelShutdownDelay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "serverShutdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textShutdownDelay;
        private System.Windows.Forms.Label labelShutdownDelay;
        private System.Windows.Forms.Button buttonIdleShutdown;
        private System.Windows.Forms.Button buttonDelayedShutdown;
        private System.Windows.Forms.Button buttonCancelShutdown;
    }
}