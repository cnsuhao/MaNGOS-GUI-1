namespace MaNGOS_GUI
{
    partial class broadcastMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(broadcastMessage));
            this.textBroadcastMessage = new System.Windows.Forms.TextBox();
            this.buttonBroadcastMessage = new System.Windows.Forms.Button();
            this.labelBroadcastMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBroadcastMessage
            // 
            resources.ApplyResources(this.textBroadcastMessage, "textBroadcastMessage");
            this.textBroadcastMessage.Name = "textBroadcastMessage";
            // 
            // buttonBroadcastMessage
            // 
            resources.ApplyResources(this.buttonBroadcastMessage, "buttonBroadcastMessage");
            this.buttonBroadcastMessage.Name = "buttonBroadcastMessage";
            this.buttonBroadcastMessage.UseVisualStyleBackColor = true;
            this.buttonBroadcastMessage.Click += new System.EventHandler(this.buttonBroadcastMessage_Click);
            // 
            // labelBroadcastMessage
            // 
            resources.ApplyResources(this.labelBroadcastMessage, "labelBroadcastMessage");
            this.labelBroadcastMessage.Name = "labelBroadcastMessage";
            // 
            // broadcastMessage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelBroadcastMessage);
            this.Controls.Add(this.buttonBroadcastMessage);
            this.Controls.Add(this.textBroadcastMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "broadcastMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBroadcastMessage;
        private System.Windows.Forms.Button buttonBroadcastMessage;
        private System.Windows.Forms.Label labelBroadcastMessage;
    }
}