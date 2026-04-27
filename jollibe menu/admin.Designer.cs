namespace jollibe_menu
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            panel1 = new Panel();
            panel2 = new Panel();
            btnEmployee = new Button();
            btnStocks = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            button1 = new Button();
            btnLog = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-6, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(1331, 89);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnLog);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnStocks);
            panel2.Controls.Add(btnEmployee);
            panel2.Location = new Point(-6, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 540);
            panel2.TabIndex = 1;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.Red;
            btnEmployee.FlatStyle = FlatStyle.Popup;
            btnEmployee.ForeColor = SystemColors.ButtonFace;
            btnEmployee.Location = new Point(24, 267);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(198, 54);
            btnEmployee.TabIndex = 2;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = false;
            // 
            // btnStocks
            // 
            btnStocks.BackColor = Color.Red;
            btnStocks.FlatStyle = FlatStyle.Popup;
            btnStocks.ForeColor = SystemColors.ButtonFace;
            btnStocks.Location = new Point(24, 372);
            btnStocks.Name = "btnStocks";
            btnStocks.Size = new Size(198, 54);
            btnStocks.TabIndex = 3;
            btnStocks.Text = "STOCKS";
            btnStocks.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(24, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 127);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Astro", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(228, 33);
            label1.TabIndex = 2;
            label1.Text = "ADMIN USER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(589, 24);
            label2.Name = "label2";
            label2.Size = new Size(275, 41);
            label2.TabIndex = 1;
            label2.Text = "admin dashboard";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(256, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1052, 435);
            dataGridView1.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(522, 140);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search here";
            txtSearch.Size = new Size(671, 27);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(1199, 140);
            button1.Name = "button1";
            button1.Size = new Size(109, 29);
            button1.TabIndex = 4;
            button1.Text = "SEARCH";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.Red;
            btnLog.FlatStyle = FlatStyle.Popup;
            btnLog.ForeColor = SystemColors.ButtonFace;
            btnLog.Location = new Point(24, 473);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(198, 54);
            btnLog.TabIndex = 4;
            btnLog.Text = "LOGOUT";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 620);
            Controls.Add(button1);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "admin";
            Text = "admin";
            Load += admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnStocks;
        private Button btnEmployee;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button btnLog;
        private Button button1;
    }
}