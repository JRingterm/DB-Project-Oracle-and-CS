
namespace DBProject
{
    partial class basket
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
            this.name_label = new System.Windows.Forms.Label();
            this.order_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.address_group = new System.Windows.Forms.GroupBox();
            this.detail_label = new System.Windows.Forms.Label();
            this.basic_label = new System.Windows.Forms.Label();
            this.post_label = new System.Windows.Forms.Label();
            this.work_radio = new System.Windows.Forms.RadioButton();
            this.home_radio = new System.Windows.Forms.RadioButton();
            this.product_group = new System.Windows.Forms.GroupBox();
            this.bookn_label = new System.Windows.Forms.Label();
            this.product_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.card_group = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cardmy_label = new System.Windows.Forms.Label();
            this.cardnum_label = new System.Windows.Forms.Label();
            this.mycard_cbox = new System.Windows.Forms.ComboBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.address_group.SuspendLayout();
            this.product_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.card_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_label.Location = new System.Drawing.Point(12, 29);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(139, 28);
            this.name_label.TabIndex = 29;
            this.name_label.Text = "님의 장바구니";
            // 
            // order_btn
            // 
            this.order_btn.CausesValidation = false;
            this.order_btn.Enabled = false;
            this.order_btn.Location = new System.Drawing.Point(663, 448);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(312, 74);
            this.order_btn.TabIndex = 31;
            this.order_btn.Text = "주문하기";
            this.order_btn.UseVisualStyleBackColor = true;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(17, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(635, 290);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // address_group
            // 
            this.address_group.Controls.Add(this.detail_label);
            this.address_group.Controls.Add(this.basic_label);
            this.address_group.Controls.Add(this.post_label);
            this.address_group.Controls.Add(this.work_radio);
            this.address_group.Controls.Add(this.home_radio);
            this.address_group.Enabled = false;
            this.address_group.Location = new System.Drawing.Point(17, 369);
            this.address_group.Name = "address_group";
            this.address_group.Size = new System.Drawing.Size(316, 153);
            this.address_group.TabIndex = 32;
            this.address_group.TabStop = false;
            this.address_group.Text = "배송지 정보";
            // 
            // detail_label
            // 
            this.detail_label.AutoSize = true;
            this.detail_label.Location = new System.Drawing.Point(164, 83);
            this.detail_label.Name = "detail_label";
            this.detail_label.Size = new System.Drawing.Size(29, 15);
            this.detail_label.TabIndex = 24;
            this.detail_label.Text = "null";
            this.detail_label.Visible = false;
            // 
            // basic_label
            // 
            this.basic_label.AutoSize = true;
            this.basic_label.Location = new System.Drawing.Point(17, 85);
            this.basic_label.Name = "basic_label";
            this.basic_label.Size = new System.Drawing.Size(29, 15);
            this.basic_label.TabIndex = 23;
            this.basic_label.Text = "null";
            this.basic_label.Visible = false;
            // 
            // post_label
            // 
            this.post_label.AutoSize = true;
            this.post_label.Location = new System.Drawing.Point(17, 55);
            this.post_label.Name = "post_label";
            this.post_label.Size = new System.Drawing.Size(29, 15);
            this.post_label.TabIndex = 21;
            this.post_label.Text = "null";
            this.post_label.Visible = false;
            // 
            // work_radio
            // 
            this.work_radio.AutoSize = true;
            this.work_radio.Location = new System.Drawing.Point(154, 24);
            this.work_radio.Name = "work_radio";
            this.work_radio.Size = new System.Drawing.Size(58, 19);
            this.work_radio.TabIndex = 20;
            this.work_radio.Text = "직장";
            this.work_radio.UseVisualStyleBackColor = true;
            this.work_radio.CheckedChanged += new System.EventHandler(this.work_radio_CheckedChanged);
            // 
            // home_radio
            // 
            this.home_radio.AutoSize = true;
            this.home_radio.Checked = true;
            this.home_radio.Location = new System.Drawing.Point(19, 24);
            this.home_radio.Name = "home_radio";
            this.home_radio.Size = new System.Drawing.Size(58, 19);
            this.home_radio.TabIndex = 19;
            this.home_radio.TabStop = true;
            this.home_radio.Text = "자택";
            this.home_radio.UseVisualStyleBackColor = true;
            this.home_radio.CheckedChanged += new System.EventHandler(this.home_radio_CheckedChanged);
            // 
            // product_group
            // 
            this.product_group.Controls.Add(this.bookn_label);
            this.product_group.Controls.Add(this.product_label);
            this.product_group.Controls.Add(this.price_label);
            this.product_group.Controls.Add(this.label2);
            this.product_group.Controls.Add(this.numericUpDown1);
            this.product_group.Enabled = false;
            this.product_group.Location = new System.Drawing.Point(339, 369);
            this.product_group.Name = "product_group";
            this.product_group.Size = new System.Drawing.Size(313, 153);
            this.product_group.TabIndex = 25;
            this.product_group.TabStop = false;
            this.product_group.Text = "선택상품";
            // 
            // bookn_label
            // 
            this.bookn_label.AutoSize = true;
            this.bookn_label.Location = new System.Drawing.Point(60, 52);
            this.bookn_label.Name = "bookn_label";
            this.bookn_label.Size = new System.Drawing.Size(75, 15);
            this.bookn_label.TabIndex = 20;
            this.bookn_label.Text = "book_num";
            this.bookn_label.Visible = false;
            // 
            // product_label
            // 
            this.product_label.AutoSize = true;
            this.product_label.Location = new System.Drawing.Point(60, 26);
            this.product_label.Name = "product_label";
            this.product_label.Size = new System.Drawing.Size(29, 15);
            this.product_label.TabIndex = 19;
            this.product_label.Text = "null";
            this.product_label.Visible = false;
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(239, 86);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(22, 15);
            this.price_label.TabIndex = 18;
            this.price_label.Text = "원";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "선택: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(19, 82);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // card_group
            // 
            this.card_group.Controls.Add(this.label6);
            this.card_group.Controls.Add(this.label3);
            this.card_group.Controls.Add(this.cardmy_label);
            this.card_group.Controls.Add(this.cardnum_label);
            this.card_group.Controls.Add(this.mycard_cbox);
            this.card_group.Enabled = false;
            this.card_group.Location = new System.Drawing.Point(663, 152);
            this.card_group.Name = "card_group";
            this.card_group.Size = new System.Drawing.Size(312, 130);
            this.card_group.TabIndex = 33;
            this.card_group.TabStop = false;
            this.card_group.Text = "카드선택";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "카드번호:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "유효기간:";
            // 
            // cardmy_label
            // 
            this.cardmy_label.AutoSize = true;
            this.cardmy_label.Location = new System.Drawing.Point(248, 50);
            this.cardmy_label.Name = "cardmy_label";
            this.cardmy_label.Size = new System.Drawing.Size(29, 15);
            this.cardmy_label.TabIndex = 2;
            this.cardmy_label.Text = "null";
            this.cardmy_label.Visible = false;
            // 
            // cardnum_label
            // 
            this.cardnum_label.AutoSize = true;
            this.cardnum_label.Location = new System.Drawing.Point(90, 95);
            this.cardnum_label.Name = "cardnum_label";
            this.cardnum_label.Size = new System.Drawing.Size(29, 15);
            this.cardnum_label.TabIndex = 1;
            this.cardnum_label.Text = "null";
            this.cardnum_label.Visible = false;
            // 
            // mycard_cbox
            // 
            this.mycard_cbox.FormattingEnabled = true;
            this.mycard_cbox.Location = new System.Drawing.Point(18, 47);
            this.mycard_cbox.Name = "mycard_cbox";
            this.mycard_cbox.Size = new System.Drawing.Size(121, 23);
            this.mycard_cbox.TabIndex = 0;
            this.mycard_cbox.SelectedIndexChanged += new System.EventHandler(this.mycard_cbox_SelectedIndexChanged);
            // 
            // delete_btn
            // 
            this.delete_btn.CausesValidation = false;
            this.delete_btn.Enabled = false;
            this.delete_btn.Location = new System.Drawing.Point(663, 368);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(312, 74);
            this.delete_btn.TabIndex = 34;
            this.delete_btn.Text = "장바구니에서 삭제";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // button1
            // 
            this.button1.CausesValidation = false;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(663, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 74);
            this.button1.TabIndex = 35;
            this.button1.Text = "개수 수정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.card_group);
            this.Controls.Add(this.product_group);
            this.Controls.Add(this.address_group);
            this.Controls.Add(this.order_btn);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.dataGridView1);
            this.Name = "basket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "장바구니";
            this.Load += new System.EventHandler(this.basket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.address_group.ResumeLayout(false);
            this.address_group.PerformLayout();
            this.product_group.ResumeLayout(false);
            this.product_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.card_group.ResumeLayout(false);
            this.card_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox address_group;
        private System.Windows.Forms.Label detail_label;
        private System.Windows.Forms.Label basic_label;
        private System.Windows.Forms.Label post_label;
        private System.Windows.Forms.RadioButton work_radio;
        private System.Windows.Forms.RadioButton home_radio;
        private System.Windows.Forms.GroupBox product_group;
        private System.Windows.Forms.Label bookn_label;
        private System.Windows.Forms.Label product_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox card_group;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cardmy_label;
        private System.Windows.Forms.Label cardnum_label;
        private System.Windows.Forms.ComboBox mycard_cbox;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button button1;
    }
}