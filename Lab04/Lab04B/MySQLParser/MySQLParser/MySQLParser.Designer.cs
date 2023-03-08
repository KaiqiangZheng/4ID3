namespace MySQLParser
{
    partial class MySQLParser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_QueryDatabase = new Button();
            lbl_DatabaseIP = new Label();
            txt_DatabaseIP = new TextBox();
            txt_DatabaseName = new TextBox();
            lbl_DatabaseName = new Label();
            txt_DatabaseUsername = new TextBox();
            lbl_DatabaseUsername = new Label();
            txt_DatabasePassword = new TextBox();
            lbl_DatabasePassword = new Label();
            txt_QueryDatabase = new TextBox();
            grid_DataView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grid_DataView).BeginInit();
            SuspendLayout();
            // 
            // btn_QueryDatabase
            // 
            btn_QueryDatabase.Location = new Point(83, 258);
            btn_QueryDatabase.Margin = new Padding(4, 5, 4, 5);
            btn_QueryDatabase.Name = "btn_QueryDatabase";
            btn_QueryDatabase.Size = new Size(183, 38);
            btn_QueryDatabase.TabIndex = 0;
            btn_QueryDatabase.Text = "Query Database";
            btn_QueryDatabase.UseVisualStyleBackColor = true;
            btn_QueryDatabase.Click += btn_QueryDatabase_Click;
            // 
            // lbl_DatabaseIP
            // 
            lbl_DatabaseIP.AutoSize = true;
            lbl_DatabaseIP.Location = new Point(83, 92);
            lbl_DatabaseIP.Margin = new Padding(4, 0, 4, 0);
            lbl_DatabaseIP.Name = "lbl_DatabaseIP";
            lbl_DatabaseIP.Size = new Size(106, 25);
            lbl_DatabaseIP.TabIndex = 1;
            lbl_DatabaseIP.Text = "Database IP";
            // 
            // txt_DatabaseIP
            // 
            txt_DatabaseIP.Location = new Point(246, 87);
            txt_DatabaseIP.Margin = new Padding(4, 5, 4, 5);
            txt_DatabaseIP.Name = "txt_DatabaseIP";
            txt_DatabaseIP.Size = new Size(258, 31);
            txt_DatabaseIP.TabIndex = 2;
            txt_DatabaseIP.Text = "localhost";
            // 
            // txt_DatabaseName
            // 
            txt_DatabaseName.Location = new Point(246, 157);
            txt_DatabaseName.Margin = new Padding(4, 5, 4, 5);
            txt_DatabaseName.Name = "txt_DatabaseName";
            txt_DatabaseName.Size = new Size(258, 31);
            txt_DatabaseName.TabIndex = 4;
            txt_DatabaseName.Text = "GroupA";
            // 
            // lbl_DatabaseName
            // 
            lbl_DatabaseName.AutoSize = true;
            lbl_DatabaseName.Location = new Point(83, 162);
            lbl_DatabaseName.Margin = new Padding(4, 0, 4, 0);
            lbl_DatabaseName.Name = "lbl_DatabaseName";
            lbl_DatabaseName.Size = new Size(138, 25);
            lbl_DatabaseName.TabIndex = 3;
            lbl_DatabaseName.Text = "Database Name";
            // 
            // txt_DatabaseUsername
            // 
            txt_DatabaseUsername.Location = new Point(741, 92);
            txt_DatabaseUsername.Margin = new Padding(4, 5, 4, 5);
            txt_DatabaseUsername.Name = "txt_DatabaseUsername";
            txt_DatabaseUsername.Size = new Size(258, 31);
            txt_DatabaseUsername.TabIndex = 6;
            txt_DatabaseUsername.Text = "root";
            // 
            // lbl_DatabaseUsername
            // 
            lbl_DatabaseUsername.AutoSize = true;
            lbl_DatabaseUsername.BackColor = SystemColors.Control;
            lbl_DatabaseUsername.Location = new Point(579, 97);
            lbl_DatabaseUsername.Margin = new Padding(4, 0, 4, 0);
            lbl_DatabaseUsername.Name = "lbl_DatabaseUsername";
            lbl_DatabaseUsername.Size = new Size(170, 25);
            lbl_DatabaseUsername.TabIndex = 5;
            lbl_DatabaseUsername.Text = "Database Username";
            // 
            // txt_DatabasePassword
            // 
            txt_DatabasePassword.Location = new Point(741, 162);
            txt_DatabasePassword.Margin = new Padding(4, 5, 4, 5);
            txt_DatabasePassword.Name = "txt_DatabasePassword";
            txt_DatabasePassword.Size = new Size(258, 31);
            txt_DatabasePassword.TabIndex = 8;
            txt_DatabasePassword.Text = "1144241906";
            // 
            // lbl_DatabasePassword
            // 
            lbl_DatabasePassword.AutoSize = true;
            lbl_DatabasePassword.BackColor = SystemColors.Control;
            lbl_DatabasePassword.Location = new Point(579, 167);
            lbl_DatabasePassword.Margin = new Padding(4, 0, 4, 0);
            lbl_DatabasePassword.Name = "lbl_DatabasePassword";
            lbl_DatabasePassword.Size = new Size(166, 25);
            lbl_DatabasePassword.TabIndex = 7;
            lbl_DatabasePassword.Text = "Database Password";
            // 
            // txt_QueryDatabase
            // 
            txt_QueryDatabase.Location = new Point(294, 262);
            txt_QueryDatabase.Margin = new Padding(4, 5, 4, 5);
            txt_QueryDatabase.Name = "txt_QueryDatabase";
            txt_QueryDatabase.Size = new Size(705, 31);
            txt_QueryDatabase.TabIndex = 9;
            txt_QueryDatabase.Text = "SELECT * FROM `DeviceA`;";
            // 
            // grid_DataView
            // 
            grid_DataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_DataView.Location = new Point(83, 348);
            grid_DataView.Margin = new Padding(4, 5, 4, 5);
            grid_DataView.Name = "grid_DataView";
            grid_DataView.RowHeadersWidth = 62;
            grid_DataView.RowTemplate.Height = 25;
            grid_DataView.Size = new Size(919, 353);
            grid_DataView.TabIndex = 10;
            // 
            // MySQLParser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(grid_DataView);
            Controls.Add(txt_QueryDatabase);
            Controls.Add(txt_DatabasePassword);
            Controls.Add(lbl_DatabasePassword);
            Controls.Add(txt_DatabaseUsername);
            Controls.Add(lbl_DatabaseUsername);
            Controls.Add(txt_DatabaseName);
            Controls.Add(lbl_DatabaseName);
            Controls.Add(txt_DatabaseIP);
            Controls.Add(lbl_DatabaseIP);
            Controls.Add(btn_QueryDatabase);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MySQLParser";
            Text = "MySQLParser";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grid_DataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_QueryDatabase;
        private Label lbl_DatabaseIP;
        private TextBox txt_DatabaseIP;
        private TextBox txt_DatabaseName;
        private Label lbl_DatabaseName;
        private TextBox txt_DatabaseUsername;
        private Label lbl_DatabaseUsername;
        private TextBox txt_DatabasePassword;
        private Label lbl_DatabasePassword;
        private TextBox txt_QueryDatabase;
        private DataGridView grid_DataView;
    }
}