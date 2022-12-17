
namespace DBProject
{
    partial class findpw
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
            this.ID_txtbox = new System.Windows.Forms.TextBox();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_txtbox
            // 
            this.ID_txtbox.Location = new System.Drawing.Point(96, 73);
            this.ID_txtbox.Name = "ID_txtbox";
            this.ID_txtbox.Size = new System.Drawing.Size(193, 25);
            this.ID_txtbox.TabIndex = 0;
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(96, 149);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(193, 25);
            this.name_txtbox.TabIndex = 1;
            this.name_txtbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.name_txtbox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "성명:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 76);
            this.button1.TabIndex = 4;
            this.button1.Text = "PW찾기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // findpw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 316);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.ID_txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "findpw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PW찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_txtbox;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}