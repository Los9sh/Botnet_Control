namespace BotNet_Control
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_change = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_auth = new System.Windows.Forms.Button();
            this.textBox_token = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_reg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_newAcc = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_refresh = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_selected_server = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_page_create = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_page_create = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_cmd = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lab_content = new System.Windows.Forms.Label();
            this.lab_title = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_change);
            this.tabPage1.Controls.Add(this.button_save);
            this.tabPage1.Controls.Add(this.button_auth);
            this.tabPage1.Controls.Add(this.textBox_token);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Авторизация / Регистрация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_change
            // 
            this.button_change.Enabled = false;
            this.button_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_change.Location = new System.Drawing.Point(26, 219);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(197, 42);
            this.button_change.TabIndex = 9;
            this.button_change.Text = "Сменить аккаунт";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_save
            // 
            this.button_save.Enabled = false;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(26, 160);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(169, 42);
            this.button_save.TabIndex = 9;
            this.button_save.Text = "Сохранить токен";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_auth
            // 
            this.button_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_auth.Location = new System.Drawing.Point(26, 101);
            this.button_auth.Name = "button_auth";
            this.button_auth.Size = new System.Drawing.Size(169, 42);
            this.button_auth.TabIndex = 9;
            this.button_auth.Text = "Авторизация";
            this.button_auth.UseVisualStyleBackColor = true;
            this.button_auth.Click += new System.EventHandler(this.button_auth_Click);
            // 
            // textBox_token
            // 
            this.textBox_token.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_token.Location = new System.Drawing.Point(26, 44);
            this.textBox_token.Name = "textBox_token";
            this.textBox_token.Size = new System.Drawing.Size(330, 38);
            this.textBox_token.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Access_token:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_reg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_newAcc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(440, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Регистрация";
            // 
            // button_reg
            // 
            this.button_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reg.Location = new System.Drawing.Point(23, 116);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(245, 40);
            this.button_reg.TabIndex = 2;
            this.button_reg.Text = " Зарегистрировать";
            this.button_reg.UseVisualStyleBackColor = true;
            this.button_reg.Click += new System.EventHandler(this.button_reg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя аккаунта:";
            // 
            // textBox_newAcc
            // 
            this.textBox_newAcc.Location = new System.Drawing.Point(23, 61);
            this.textBox_newAcc.Name = "textBox_newAcc";
            this.textBox_newAcc.Size = new System.Drawing.Size(245, 30);
            this.textBox_newAcc.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_refresh);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.textBox_selected_server);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройка";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_refresh
            // 
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_refresh.Location = new System.Drawing.Point(138, 303);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(280, 40);
            this.button_refresh.TabIndex = 2;
            this.button_refresh.Text = "Обновить список";
            this.button_refresh.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(23, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(395, 204);
            this.listBox1.TabIndex = 10;
            // 
            // textBox_selected_server
            // 
            this.textBox_selected_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_selected_server.Location = new System.Drawing.Point(23, 47);
            this.textBox_selected_server.Name = "textBox_selected_server";
            this.textBox_selected_server.Size = new System.Drawing.Size(330, 30);
            this.textBox_selected_server.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Выбранный сервер:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_page_create);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_page_create);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(448, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 164);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Создание страницы";
            // 
            // button_page_create
            // 
            this.button_page_create.Location = new System.Drawing.Point(23, 109);
            this.button_page_create.Name = "button_page_create";
            this.button_page_create.Size = new System.Drawing.Size(243, 40);
            this.button_page_create.TabIndex = 2;
            this.button_page_create.Text = "Создать";
            this.button_page_create.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Название страницы:";
            // 
            // textBox_page_create
            // 
            this.textBox_page_create.Location = new System.Drawing.Point(21, 61);
            this.textBox_page_create.MaxLength = 256;
            this.textBox_page_create.Name = "textBox_page_create";
            this.textBox_page_create.Size = new System.Drawing.Size(245, 30);
            this.textBox_page_create.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button_send);
            this.tabPage3.Controls.Add(this.textBox_cmd);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(754, 349);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Управление";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button_send
            // 
            this.button_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_send.Location = new System.Drawing.Point(238, 109);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(145, 35);
            this.button_send.TabIndex = 2;
            this.button_send.Text = "Обновить";
            this.button_send.UseVisualStyleBackColor = true;
            // 
            // textBox_cmd
            // 
            this.textBox_cmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_cmd.Location = new System.Drawing.Point(23, 59);
            this.textBox_cmd.Name = "textBox_cmd";
            this.textBox_cmd.Size = new System.Drawing.Size(355, 30);
            this.textBox_cmd.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // lab_content
            // 
            this.lab_content.AutoSize = true;
            this.lab_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_content.Location = new System.Drawing.Point(38, 419);
            this.lab_content.Name = "lab_content";
            this.lab_content.Size = new System.Drawing.Size(58, 25);
            this.lab_content.TabIndex = 8;
            this.lab_content.Text = "CMD";
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_title.Location = new System.Drawing.Point(37, 394);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(49, 25);
            this.lab_title.TabIndex = 6;
            this.lab_title.Text = "Title";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.lab_content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Panel BotNet";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_auth;
        private System.Windows.Forms.TextBox textBox_token;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_newAcc;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox_selected_server;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_page_create;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_page_create;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_cmd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lab_content;
        private System.Windows.Forms.Label lab_title;
    }
}

