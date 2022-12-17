
namespace DBProject
{
    partial class findid
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.PW_txtbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "성명:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "PW:";
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(90, 66);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(191, 25);
            this.name_txtbox.TabIndex = 10;
            // 
            // PW_txtbox
            // 
            this.PW_txtbox.Location = new System.Drawing.Point(90, 142);
            this.PW_txtbox.Name = "PW_txtbox";
            this.PW_txtbox.Size = new System.Drawing.Size(191, 25);
            this.PW_txtbox.TabIndex = 11;
            this.PW_txtbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PW_txtbox_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 87);
            this.button1.TabIndex = 12;
            this.button1.Text = "ID찾기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // findid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 310);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PW_txtbox);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "findid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ID찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.TextBox PW_txtbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}