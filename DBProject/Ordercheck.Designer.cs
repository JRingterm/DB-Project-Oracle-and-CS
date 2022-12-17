
namespace DBProject
{
    partial class Ordercheck
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name_label = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.state_label = new System.Windows.Forms.Label();
            this.ordernum_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.detail_txtbox = new System.Windows.Forms.TextBox();
            this.basic_txtbox = new System.Windows.Forms.TextBox();
            this.post_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookname_txtbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(497, 254);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_label.Location = new System.Drawing.Point(12, 31);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(139, 28);
            this.name_label.TabIndex = 28;
            this.name_label.Text = "님의 주문목록";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView2.Location = new System.Drawing.Point(12, 226);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(383, 107);
            this.dataGridView2.TabIndex = 30;
            this.dataGridView2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "주문번호";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(515, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 73);
            this.button1.TabIndex = 31;
            this.button1.Text = "수취확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.state_label);
            this.groupBox1.Controls.Add(this.ordernum_txtbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.detail_txtbox);
            this.groupBox1.Controls.Add(this.basic_txtbox);
            this.groupBox1.Controls.Add(this.post_txtbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.date_txtbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bookname_txtbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 254);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "세부정보";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "주문상태:";
            // 
            // state_label
            // 
            this.state_label.AutoSize = true;
            this.state_label.Location = new System.Drawing.Point(404, 41);
            this.state_label.Name = "state_label";
            this.state_label.Size = new System.Drawing.Size(29, 15);
            this.state_label.TabIndex = 10;
            this.state_label.Text = "null";
            // 
            // ordernum_txtbox
            // 
            this.ordernum_txtbox.Location = new System.Drawing.Point(127, 38);
            this.ordernum_txtbox.Name = "ordernum_txtbox";
            this.ordernum_txtbox.ReadOnly = true;
            this.ordernum_txtbox.Size = new System.Drawing.Size(153, 25);
            this.ordernum_txtbox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "주문번호";
            // 
            // detail_txtbox
            // 
            this.detail_txtbox.Location = new System.Drawing.Point(127, 211);
            this.detail_txtbox.Name = "detail_txtbox";
            this.detail_txtbox.ReadOnly = true;
            this.detail_txtbox.Size = new System.Drawing.Size(355, 25);
            this.detail_txtbox.TabIndex = 7;
            // 
            // basic_txtbox
            // 
            this.basic_txtbox.Location = new System.Drawing.Point(127, 181);
            this.basic_txtbox.Name = "basic_txtbox";
            this.basic_txtbox.ReadOnly = true;
            this.basic_txtbox.Size = new System.Drawing.Size(355, 25);
            this.basic_txtbox.TabIndex = 6;
            // 
            // post_txtbox
            // 
            this.post_txtbox.Location = new System.Drawing.Point(127, 150);
            this.post_txtbox.Name = "post_txtbox";
            this.post_txtbox.ReadOnly = true;
            this.post_txtbox.Size = new System.Drawing.Size(355, 25);
            this.post_txtbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "배송지";
            // 
            // date_txtbox
            // 
            this.date_txtbox.Location = new System.Drawing.Point(127, 112);
            this.date_txtbox.Name = "date_txtbox";
            this.date_txtbox.ReadOnly = true;
            this.date_txtbox.Size = new System.Drawing.Size(153, 25);
            this.date_txtbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "주문일자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "도서명";
            // 
            // bookname_txtbox
            // 
            this.bookname_txtbox.Location = new System.Drawing.Point(127, 74);
            this.bookname_txtbox.Name = "bookname_txtbox";
            this.bookname_txtbox.ReadOnly = true;
            this.bookname_txtbox.Size = new System.Drawing.Size(153, 25);
            this.bookname_txtbox.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(515, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 73);
            this.button2.TabIndex = 33;
            this.button2.Text = "주문취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(6, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 77);
            this.button3.TabIndex = 34;
            this.button3.Text = "개수수정";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(524, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 140);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "주문 개수 수정";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(6, 24);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown1.TabIndex = 36;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(690, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // Ordercheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 605);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ordercheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "주문조회";
            this.Load += new System.EventHandler(this.Ordercheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox detail_txtbox;
        private System.Windows.Forms.TextBox basic_txtbox;
        private System.Windows.Forms.TextBox post_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox date_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookname_txtbox;
        private System.Windows.Forms.TextBox ordernum_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label state_label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
    }
}