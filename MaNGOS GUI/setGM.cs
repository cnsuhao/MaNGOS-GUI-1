using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaNGOS_GUI.DataAccess;

namespace MaNGOS_GUI
{
    public partial class setGM : Form
    {
        public setGM()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(comboAccount.Text ))
                {
                    if (!String.IsNullOrEmpty(comboGMLevel.Text))
                    {
                        ServerData sData = new ServerData();

                        if (sData.checkAccountExists(comboAccount.Text))
                        {
                            string commandString = "account set gmlevel " + comboAccount.Text + " " + comboGMLevel.Text;
                            ManguiMain.mangosProcess.StandardInput.WriteLine(commandString);

                            ConfigAccess.updateLog(commandString);

                            MessageBox.Show(string.Format(Resources.hcStringResources.Global_CommandSuccesful, commandString));
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(Resources.hcStringResources.setGM_AccountUnknown );
                        }
                    }
                    else
                    {
                        MessageBox.Show(Resources.hcStringResources.setGM_ChooseGMLevel );
                    }
                }
                else
                {
                    MessageBox.Show(Resources.hcStringResources.setGM_EnterAccount );
                }
            }
            catch
            {
                MessageBox.Show(Resources.hcStringResources.Global_CommandError );
            }
        }
    }
}
