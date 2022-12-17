namespace DBProject
{
    partial class Register
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
            this.Name_txtbox = new System.Windows.Forms.TextBox();
            this.ID_txtbox = new System.Windows.Forms.TextBox();
            this.PW_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PWC_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_txtbox
            // 
            this.Name_txtbox.Location = new System.Drawing.Point(142, 72);
            this.Name_txtbox.Name = "Name_txtbox";
            this.Name_txtbox.Size = new System.Drawing.Size(159, 25);
            this.Name_txtbox.TabIndex = 0;
            // 
            // ID_txtbox
            // 
            this.ID_txtbox.Location = new System.Drawing.Point(142, 129);
            this.ID_txtbox.Name = "ID_txtbox";
            this.ID_txtbox.Size = new System.Drawing.Size(159, 25);
            this.ID_txtbox.TabIndex = 1;
            // 
            // PW_txtbox
            // 
            this.PW_txtbox.Location = new System.Drawing.Point(142, 193);
            this.PW_txtbox.Name = "PW_txtbox";
            this.PW_txtbox.PasswordChar = '*';
            this.PW_txtbox.Size = new System.Drawing.Size(159, 25);
            this.PW_txtbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "성명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "비밀번호";
            // 
            // PWC_txtbox
            // 
            this.PWC_txtbox.Location = new System.Drawing.Point(142, 244);
            this.PWC_txtbox.Name = "PWC_txtbox";
            this.PWC_txtbox.PasswordChar = '*';
            this.PWC_txtbox.Size = new System.Drawing.Size(159, 25);
            this.PWC_txtbox.TabIndex = 6;
            this.PWC_txtbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PWC_txtbox_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "비밀번호 확인";
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(76, 309);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(216, 45);
            this.register_btn.TabIndex = 8;
            this.register_btn.Text = "회원가입하기";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 410);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PWC_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PW_txtbox);
            this.Controls.Add(this.ID_txtbox);
            this.Controls.Add(this.Name_txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원가입";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_txtbox;
        private System.Windows.Forms.TextBox ID_txtbox;
        private System.Windows.Forms.TextBox PW_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PWC_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button register_btn;
    }
}