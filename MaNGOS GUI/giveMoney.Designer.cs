namespace MaNGOS_GUI
{
    partial class giveMoney
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
            this.textSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textCharacterName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textMoney = new System.Windows.Forms.TextBox();
            this.buttonSendMoney = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textSubject
            // 
            this.textSubject.Location = new System.Drawing.Point(15, 64);
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(283, 20);
            this.textSubject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(179, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 9);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player got an mail with money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject of mail";
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(15, 103);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(285, 20);
            this.textMessage.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Text of mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Character name";
            // 
            // textCharacterName
            // 
            this.textCharacterName.Location = new System.Drawing.Point(15, 25);
            this.textCharacterName.Name = "textCharacterName";
            this.textCharacterName.Size = new System.Drawing.Size(283, 20);
            this.textCharacterName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amount of money";
            // 
            // textMoney
            // 
            this.textMoney.Location = new System.Drawing.Point(15, 142);
            this.textMoney.Multiline = true;
            this.textMoney.Name = "textMoney";
            this.textMoney.Size = new System.Drawing.Size(283, 20);
            this.textMoney.TabIndex = 8;
            // 
            // buttonSendMoney
            // 
            this.buttonSendMoney.Location = new System.Drawing.Point(214, 168);
            this.buttonSendMoney.Name = "buttonSendMoney";
            this.buttonSendMoney.Size = new System.Drawing.Size(84, 40);
            this.buttonSendMoney.TabIndex = 9;
            this.buttonSendMoney.Text = "Send";
            this.buttonSendMoney.UseVisualStyleBackColor = true;
            this.buttonSendMoney.Click += new System.EventHandler(this.buttonSendMoney_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(94, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Subject of mail must look like \"%subject%\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(79, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "Text of mail must look like \"%text%\"";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(107, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "1g = 10000";
            // 
            // giveMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 220);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSendMoney);
            this.Controls.Add(this.textMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCharacterName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSubject);
            this.Name = "giveMoney";
            this.Text = "Give Money";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCharacterName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textMoney;
        private System.Windows.Forms.Button buttonSendMoney;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}