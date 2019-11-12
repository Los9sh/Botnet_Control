using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotNet_Control
{
    public partial class frmMain : Form
    {
        TelegraphServer tserver;

        public frmMain()
        {
            InitializeComponent();
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            tserver = new TelegraphServer();
            tserver.CreateAccount(textBox_newAcc.Text);

            if(tserver.access_token.Length > 0)
            {
                textBox_token.Text = tserver.access_token;
                MessageBox.Show("Аккаунт успешно создан!");
            }
            else
            {
                MessageBox.Show("Ошибка!!! Аккаунт НЕ БЫЛ создан!");
            }
        }

        private void button_auth_Click(object sender, EventArgs e)
        {
            tserver = new TelegraphServer(textBox_token.Text);

            button_auth.Enabled = false;
            button_save.Enabled = true;
            button_change.Enabled = true;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            File.WriteAllText(configs.auth_file, textBox_token.Text);
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            tserver = new TelegraphServer(textBox_token.Text);
        }
    }
}
