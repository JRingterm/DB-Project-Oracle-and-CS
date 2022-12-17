namespace DBProject
{
    partial class main
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
            this.mypage_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.order_btn = new System.Windows.Forms.Button();
            this.basket_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.ID_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PW_txtbox = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.product_group = new System.Windows.Forms.GroupBox();
            this.bookn_label = new System.Windows.Forms.Label();
            this.product_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.address_group = new System.Windows.Forms.GroupBox();
            this.detail_label = new System.Windows.Forms.Label();
            this.basic_label = new System.Windows.Forms.Label();
            this.address_btn = new System.Windows.Forms.Button();
            this.post_label = new System.Windows.Forms.Label();
            this.work_radio = new System.Windows.Forms.RadioButton();
            this.home_radio = new System.Windows.Forms.RadioButton();
            this.card_group = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cardmy_label = new System.Windows.Forms.Label();
            this.cardnum_label = new System.Windows.Forms.Label();
            this.mycard_cbox = new System.Windows.Forms.ComboBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.find_pw_btn = new System.Windows.Forms.Button();
            this.find_id_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.product_group.SuspendLayout();
            this.address_group.SuspendLayout();
            this.card_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // mypage_btn
            // 
            this.mypage_btn.Enabled = false;
            this.mypage_btn.Location = new System.Drawing.Point(155, 12);
            this.mypage_btn.Name = "mypage_btn";
            this.mypage_btn.Size = new System.Drawing.Size(109, 28);
            this.mypage_btn.TabIndex = 0;
            this.mypage_btn.Text = "마이페이지";
            this.mypage_btn.UseVisualStyleBackColor = true;
            this.mypage_btn.Visible = false;
            this.mypage_btn.Click += new System.EventHandler(this.mypage_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(65, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "님";
            this.label1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(519, 543);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // order_btn
            // 
            this.order_btn.CausesValidation = false;
            this.order_btn.Enabled = false;
            this.order_btn.Location = new System.Drawing.Point(549, 550);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(314, 92);
            this.order_btn.TabIndex = 3;
            this.order_btn.Text = "주문하기";
            this.order_btn.UseVisualStyleBackColor = true;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // basket_btn
            // 
            this.basket_btn.Enabled = false;
            this.basket_btn.Location = new System.Drawing.Point(549, 496);
            this.basket_btn.Name = "basket_btn";
            this.basket_btn.Size = new System.Drawing.Size(314, 48);
            this.basket_btn.TabIndex = 4;
            this.basket_btn.Text = "장바구니 담기";
            this.basket_btn.UseVisualStyleBackColor = true;
            this.basket_btn.Click += new System.EventHandler(this.basket_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Enabled = false;
            this.logout_btn.Location = new System.Drawing.Point(155, 47);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(109, 28);
            this.logout_btn.TabIndex = 9;
            this.logout_btn.Text = "로그아웃";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Visible = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(220, 15);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(109, 25);
            this.login_btn.TabIndex = 10;
            this.login_btn.Text = "로그인";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // ID_txtbox
            // 
            this.ID_txtbox.Location = new System.Drawing.Point(52, 14);
            this.ID_txtbox.Name = "ID_txtbox";
            this.ID_txtbox.Size = new System.Drawing.Size(137, 25);
            this.ID_txtbox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "PW:";
            // 
            // PW_txtbox
            // 
            this.PW_txtbox.Location = new System.Drawing.Point(52, 49);
            this.PW_txtbox.Name = "PW_txtbox";
            this.PW_txtbox.PasswordChar = '*';
            this.PW_txtbox.Size = new System.Drawing.Size(137, 25);
            this.PW_txtbox.TabIndex = 14;
            this.PW_txtbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PW_txtbox_KeyUp);
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(220, 49);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(109, 25);
            this.register_btn.TabIndex = 15;
            this.register_btn.Text = "회원가입";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
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
            // product_group
            // 
            this.product_group.Controls.Add(this.bookn_label);
            this.product_group.Controls.Add(this.product_label);
            this.product_group.Controls.Add(this.price_label);
            this.product_group.Controls.Add(this.label2);
            this.product_group.Controls.Add(this.numericUpDown1);
            this.product_group.Enabled = false;
            this.product_group.Location = new System.Drawing.Point(550, 250);
            this.product_group.Name = "product_group";
            this.product_group.Size = new System.Drawing.Size(315, 125);
            this.product_group.TabIndex = 17;
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
            // address_group
            // 
            this.address_group.Controls.Add(this.detail_label);
            this.address_group.Controls.Add(this.basic_label);
            this.address_group.Controls.Add(this.address_btn);
            this.address_group.Controls.Add(this.post_label);
            this.address_group.Controls.Add(this.work_radio);
            this.address_group.Controls.Add(this.home_radio);
            this.address_group.Enabled = false;
            this.address_group.Location = new System.Drawing.Point(549, 91);
            this.address_group.Name = "address_group";
            this.address_group.Size = new System.Drawing.Size(316, 153);
            this.address_group.TabIndex = 19;
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
            // address_btn
            // 
            this.address_btn.Location = new System.Drawing.Point(113, 112);
            this.address_btn.Name = "address_btn";
            this.address_btn.Size = new System.Drawing.Size(197, 33);
            this.address_btn.TabIndex = 22;
            this.address_btn.Text = "배송지 등록 및 변경하기";
            this.address_btn.UseVisualStyleBackColor = true;
            this.address_btn.Click += new System.EventHandler(this.address_btn_Click);
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
            this.work_radio.TabStop = true;
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
            // card_group
            // 
            this.card_group.Controls.Add(this.label6);
            this.card_group.Controls.Add(this.label3);
            this.card_group.Controls.Add(this.cardmy_label);
            this.card_group.Controls.Add(this.cardnum_label);
            this.card_group.Controls.Add(this.mycard_cbox);
            this.card_group.Enabled = false;
            this.card_group.Location = new System.Drawing.Point(550, 381);
            this.card_group.Name = "card_group";
            this.card_group.Size = new System.Drawing.Size(315, 104);
            this.card_group.TabIndex = 20;
            this.card_group.TabStop = false;
            this.card_group.Text = "카드선택";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "카드번호:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "유효기간:";
            // 
            // cardmy_label
            // 
            this.cardmy_label.AutoSize = true;
            this.cardmy_label.Location = new System.Drawing.Point(248, 27);
            this.cardmy_label.Name = "cardmy_label";
            this.cardmy_label.Size = new System.Drawing.Size(29, 15);
            this.cardmy_label.TabIndex = 2;
            this.cardmy_label.Text = "null";
            this.cardmy_label.Visible = false;
            // 
            // cardnum_label
            // 
            this.cardnum_label.AutoSize = true;
            this.cardnum_label.Location = new System.Drawing.Point(90, 72);
            this.cardnum_label.Name = "cardnum_label";
            this.cardnum_label.Size = new System.Drawing.Size(29, 15);
            this.cardnum_label.TabIndex = 1;
            this.cardnum_label.Text = "null";
            this.cardnum_label.Visible = false;
            // 
            // mycard_cbox
            // 
            this.mycard_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mycard_cbox.FormattingEnabled = true;
            this.mycard_cbox.Location = new System.Drawing.Point(18, 24);
            this.mycard_cbox.Name = "mycard_cbox";
            this.mycard_cbox.Size = new System.Drawing.Size(121, 23);
            this.mycard_cbox.TabIndex = 0;
            this.mycard_cbox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // update_btn
            // 
            this.update_btn.Enabled = false;
            this.update_btn.Location = new System.Drawing.Point(550, 12);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(309, 73);
            this.update_btn.TabIndex = 21;
            this.update_btn.Text = "새로고침";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // find_pw_btn
            // 
            this.find_pw_btn.Location = new System.Drawing.Point(335, 49);
            this.find_pw_btn.Name = "find_pw_btn";
            this.find_pw_btn.Size = new System.Drawing.Size(109, 25);
            this.find_pw_btn.TabIndex = 22;
            this.find_pw_btn.Text = "PW찾기";
            this.find_pw_btn.UseVisualStyleBackColor = true;
            this.find_pw_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // find_id_btn
            // 
            this.find_id_btn.Location = new System.Drawing.Point(335, 15);
            this.find_id_btn.Name = "find_id_btn";
            this.find_id_btn.Size = new System.Drawing.Size(109, 25);
            this.find_id_btn.TabIndex = 23;
            this.find_id_btn.Text = "ID찾기";
            this.find_id_btn.UseVisualStyleBackColor = true;
            this.find_id_btn.Click += new System.EventHandler(this.find_id_btn_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(877, 653);
            this.Controls.Add(this.find_id_btn);
            this.Controls.Add(this.find_pw_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.card_group);
            this.Controls.Add(this.address_group);
            this.Controls.Add(this.product_group);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.PW_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ID_txtbox);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.basket_btn);
            this.Controls.Add(this.order_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mypage_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCH 인터넷 서점";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.product_group.ResumeLayout(false);
            this.product_group.PerformLayout();
            this.address_group.ResumeLayout(false);
            this.address_group.PerformLayout();
            this.card_group.ResumeLayout(false);
            this.card_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mypage_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.Button basket_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox ID_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PW_txtbox;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox product_group;
        private System.Windows.Forms.Label product_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox address_group;
        private System.Windows.Forms.Button address_btn;
        private System.Windows.Forms.Label post_label;
        private System.Windows.Forms.RadioButton work_radio;
        private System.Windows.Forms.RadioButton home_radio;
        private System.Windows.Forms.Label basic_label;
        private System.Windows.Forms.Label detail_label;
        private System.Windows.Forms.Label bookn_label;
        private System.Windows.Forms.GroupBox card_group;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cardmy_label;
        private System.Windows.Forms.Label cardnum_label;
        private System.Windows.Forms.ComboBox mycard_cbox;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button find_pw_btn;
        private System.Windows.Forms.Button find_id_btn;
    }
}