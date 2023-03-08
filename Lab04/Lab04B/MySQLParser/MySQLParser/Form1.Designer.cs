namespace MySQLParser
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txt_DatabaseIP = new TextBox();
            lbl_DatabaseIP = new Label();
            btn_QueryDatabase = new Button();
            grid_DataView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grid_DataView).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txt_DatabaseIP
            // 
            txt_DatabaseIP.Location = new Point(300, 107);
            txt_DatabaseIP.Name = "txt_DatabaseIP";
            txt_DatabaseIP.Size = new Size(150, 31);
            txt_DatabaseIP.TabIndex = 1;
            // 
            // lbl_DatabaseIP
            // 
            lbl_DatabaseIP.AutoSize = true;
            lbl_DatabaseIP.Location = new Point(177, 107);
            lbl_DatabaseIP.Name = "lbl_DatabaseIP";
            lbl_DatabaseIP.Size = new Size(106, 25);
            lbl_DatabaseIP.TabIndex = 2;
            lbl_DatabaseIP.Text = "Database IP";
            // 
            // btn_QueryDatabase
            // 
            btn_QueryDatabase.Location = new Point(271, 161);
            btn_QueryDatabase.Name = "btn_QueryDatabase";
            btn_QueryDatabase.Size = new Size(211, 40);
            btn_QueryDatabase.TabIndex = 3;
            btn_QueryDatabase.Text = "Query Database";
            btn_QueryDatabase.UseVisualStyleBackColor = true;
            btn_QueryDatabase.Click += button1_Click;
            // 
            // grid_DataView
            // 
            grid_DataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_DataView.Location = new Point(652, 251);
            grid_DataView.Name = "grid_DataView";
            grid_DataView.RowHeadersWidth = 62;
            grid_DataView.RowTemplate.Height = 33;
            grid_DataView.Size = new Size(419, 281);
            grid_DataView.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 667);
            Controls.Add(grid_DataView);
            Controls.Add(btn_QueryDatabase);
            Controls.Add(lbl_DatabaseIP);
            Controls.Add(txt_DatabaseIP);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grid_DataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox txt_DatabaseIP;
        private Label lbl_DatabaseIP;
        private Button btn_QueryDatabase;
        private DataGridView grid_DataView;
    }
}