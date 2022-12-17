
namespace DBProject
{
    partial class Admin
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
            this.bookname_txtbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.booknum_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.bookdelete_btn = new System.Windows.Forms.Button();
            this.bookfix_btn = new System.Windows.Forms.Button();
            this.bookadd_btn = new System.Windows.Forms.Button();
            this.bookprice_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bookcount_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accept_btn = new System.Windows.Forms.Button();
            this.order_group = new System.Windows.Forms.GroupBox();
            this.order_state_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.detail_txtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.basic_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.post_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.date_txtbox = new System.Windows.Forms.TextBox();
            this.order_num_label = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.customer_radio = new System.Windows.Forms.RadioButton();
            this.soldlist_radio = new System.Windows.Forms.RadioButton();
            this.order_radio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.customer_group = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.csearch_ID_txtbox = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.customer_search_btn = new System.Windows.Forms.Button();
            this.soldlist_group = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.ssearch_ID_txtbox = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.sold_search_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.order_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.customer_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.soldlist_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // bookname_txtbox
            // 
            this.bookname_txtbox.Location = new System.Drawing.Point(102, 438);
            this.bookname_txtbox.Name = "bookname_txtbox";
            this.bookname_txtbox.Size = new System.Drawing.Size(187, 25);
            this.bookname_txtbox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.booknum_txtbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.clear_btn);
            this.groupBox1.Controls.Add(this.bookdelete_btn);
            this.groupBox1.Controls.Add(this.bookfix_btn);
            this.groupBox1.Controls.Add(this.bookadd_btn);
            this.groupBox1.Controls.Add(this.bookprice_txtbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bookcount_txtbox);
            this.groupBox1.Controls.Add(this.bookname_txtbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 656);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도서관리";
            // 
            // booknum_txtbox
            // 
            this.booknum_txtbox.Location = new System.Drawing.Point(102, 396);
            this.booknum_txtbox.Name = "booknum_txtbox";
            this.booknum_txtbox.ReadOnly = true;
            this.booknum_txtbox.Size = new System.Drawing.Size(61, 25);
            this.booknum_txtbox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "도서번호";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(324, 514);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(231, 40);
            this.clear_btn.TabIndex = 10;
            this.clear_btn.Text = "초기화";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // bookdelete_btn
            // 
            this.bookdelete_btn.Location = new System.Drawing.Point(482, 438);
            this.bookdelete_btn.Name = "bookdelete_btn";
            this.bookdelete_btn.Size = new System.Drawing.Size(73, 64);
            this.bookdelete_btn.TabIndex = 9;
            this.bookdelete_btn.Text = "삭제";
            this.bookdelete_btn.UseVisualStyleBackColor = true;
            this.bookdelete_btn.Click += new System.EventHandler(this.bookdelete_btn_Click);
            // 
            // bookfix_btn
            // 
            this.bookfix_btn.Location = new System.Drawing.Point(403, 438);
            this.bookfix_btn.Name = "bookfix_btn";
            this.bookfix_btn.Size = new System.Drawing.Size(73, 64);
            this.bookfix_btn.TabIndex = 8;
            this.bookfix_btn.Text = "수정";
            this.bookfix_btn.UseVisualStyleBackColor = true;
            this.bookfix_btn.Click += new System.EventHandler(this.bookfix_btn_Click);
            // 
            // bookadd_btn
            // 
            this.bookadd_btn.Location = new System.Drawing.Point(324, 438);
            this.bookadd_btn.Name = "bookadd_btn";
            this.bookadd_btn.Size = new System.Drawing.Size(73, 64);
            this.bookadd_btn.TabIndex = 7;
            this.bookadd_btn.Text = "추가";
            this.bookadd_btn.UseVisualStyleBackColor = true;
            this.bookadd_btn.Click += new System.EventHandler(this.bookadd_btn_Click);
            // 
            // bookprice_txtbox
            // 
            this.bookprice_txtbox.Location = new System.Drawing.Point(102, 529);
            this.bookprice_txtbox.Name = "bookprice_txtbox";
            this.bookprice_txtbox.Size = new System.Drawing.Size(187, 25);
            this.bookprice_txtbox.TabIndex = 6;
            this.bookprice_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num_only);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "판매가";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(536, 342);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "도서명";
            // 
            // bookcount_txtbox
            // 
            this.bookcount_txtbox.Location = new System.Drawing.Point(102, 484);
            this.bookcount_txtbox.Name = "bookcount_txtbox";
            this.bookcount_txtbox.Size = new System.Drawing.Size(187, 25);
            this.bookcount_txtbox.TabIndex = 4;
            this.bookcount_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num_only);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "재고량";
            // 
            // accept_btn
            // 
            this.accept_btn.Location = new System.Drawing.Point(383, 374);
            this.accept_btn.Name = "accept_btn";
            this.accept_btn.Size = new System.Drawing.Size(140, 112);
            this.accept_btn.TabIndex = 2;
            this.accept_btn.Text = "주문승인";
            this.accept_btn.UseVisualStyleBackColor = true;
            this.accept_btn.Click += new System.EventHandler(this.accept_btn_Click);
            // 
            // order_group
            // 
            this.order_group.Controls.Add(this.order_state_label);
            this.order_group.Controls.Add(this.label8);
            this.order_group.Controls.Add(this.detail_txtbox);
            this.order_group.Controls.Add(this.label7);
            this.order_group.Controls.Add(this.basic_txtbox);
            this.order_group.Controls.Add(this.label6);
            this.order_group.Controls.Add(this.post_txtbox);
            this.order_group.Controls.Add(this.label5);
            this.order_group.Controls.Add(this.date_txtbox);
            this.order_group.Controls.Add(this.order_num_label);
            this.order_group.Controls.Add(this.dataGridView2);
            this.order_group.Controls.Add(this.accept_btn);
            this.order_group.Enabled = false;
            this.order_group.Location = new System.Drawing.Point(585, 155);
            this.order_group.Name = "order_group";
            this.order_group.Size = new System.Drawing.Size(565, 526);
            this.order_group.TabIndex = 3;
            this.order_group.TabStop = false;
            this.order_group.Text = "고객 주문관리";
            this.order_group.Visible = false;
            // 
            // order_state_label
            // 
            this.order_state_label.AutoSize = true;
            this.order_state_label.Location = new System.Drawing.Point(448, 356);
            this.order_state_label.Name = "order_state_label";
            this.order_state_label.Size = new System.Drawing.Size(80, 15);
            this.order_state_label.TabIndex = 23;
            this.order_state_label.Text = "order_state";
            this.order_state_label.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "상세주소";
            // 
            // detail_txtbox
            // 
            this.detail_txtbox.Location = new System.Drawing.Point(99, 484);
            this.detail_txtbox.Name = "detail_txtbox";
            this.detail_txtbox.ReadOnly = true;
            this.detail_txtbox.Size = new System.Drawing.Size(186, 25);
            this.detail_txtbox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "기본주소";
            // 
            // basic_txtbox
            // 
            this.basic_txtbox.Location = new System.Drawing.Point(99, 445);
            this.basic_txtbox.Name = "basic_txtbox";
            this.basic_txtbox.ReadOnly = true;
            this.basic_txtbox.Size = new System.Drawing.Size(186, 25);
            this.basic_txtbox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "우편번호";
            // 
            // post_txtbox
            // 
            this.post_txtbox.Location = new System.Drawing.Point(99, 404);
            this.post_txtbox.Name = "post_txtbox";
            this.post_txtbox.ReadOnly = true;
            this.post_txtbox.Size = new System.Drawing.Size(186, 25);
            this.post_txtbox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "주문날짜";
            // 
            // date_txtbox
            // 
            this.date_txtbox.Location = new System.Drawing.Point(99, 364);
            this.date_txtbox.Name = "date_txtbox";
            this.date_txtbox.ReadOnly = true;
            this.date_txtbox.Size = new System.Drawing.Size(186, 25);
            this.date_txtbox.TabIndex = 15;
            // 
            // order_num_label
            // 
            this.order_num_label.AutoSize = true;
            this.order_num_label.Location = new System.Drawing.Point(448, 329);
            this.order_num_label.Name = "order_num_label";
            this.order_num_label.Size = new System.Drawing.Size(75, 15);
            this.order_num_label.TabIndex = 14;
            this.order_num_label.Text = "order_num";
            this.order_num_label.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 24);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(536, 302);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // customer_radio
            // 
            this.customer_radio.AutoSize = true;
            this.customer_radio.Checked = true;
            this.customer_radio.Location = new System.Drawing.Point(17, 49);
            this.customer_radio.Name = "customer_radio";
            this.customer_radio.Size = new System.Drawing.Size(88, 19);
            this.customer_radio.TabIndex = 23;
            this.customer_radio.TabStop = true;
            this.customer_radio.Text = "회원조회";
            this.customer_radio.UseVisualStyleBackColor = true;
            this.customer_radio.CheckedChanged += new System.EventHandler(this.customer_radio_CheckedChanged);
            // 
            // soldlist_radio
            // 
            this.soldlist_radio.AutoSize = true;
            this.soldlist_radio.Location = new System.Drawing.Point(208, 49);
            this.soldlist_radio.Name = "soldlist_radio";
            this.soldlist_radio.Size = new System.Drawing.Size(138, 19);
            this.soldlist_radio.TabIndex = 24;
            this.soldlist_radio.Text = "회원별 판매이력";
            this.soldlist_radio.UseVisualStyleBackColor = true;
            this.soldlist_radio.CheckedChanged += new System.EventHandler(this.soldlist_radio_CheckedChanged);
            // 
            // order_radio
            // 
            this.order_radio.AutoSize = true;
            this.order_radio.Location = new System.Drawing.Point(113, 49);
            this.order_radio.Name = "order_radio";
            this.order_radio.Size = new System.Drawing.Size(88, 19);
            this.order_radio.TabIndex = 25;
            this.order_radio.Text = "주문관리";
            this.order_radio.UseVisualStyleBackColor = true;
            this.order_radio.CheckedChanged += new System.EventHandler(this.order_radio_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.customer_radio);
            this.groupBox3.Controls.Add(this.soldlist_radio);
            this.groupBox3.Controls.Add(this.order_radio);
            this.groupBox3.Location = new System.Drawing.Point(585, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 105);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "옵션";
            // 
            // customer_group
            // 
            this.customer_group.Controls.Add(this.button2);
            this.customer_group.Controls.Add(this.label12);
            this.customer_group.Controls.Add(this.csearch_ID_txtbox);
            this.customer_group.Controls.Add(this.dataGridView3);
            this.customer_group.Controls.Add(this.customer_search_btn);
            this.customer_group.Location = new System.Drawing.Point(579, 155);
            this.customer_group.Name = "customer_group";
            this.customer_group.Size = new System.Drawing.Size(565, 526);
            this.customer_group.TabIndex = 23;
            this.customer_group.TabStop = false;
            this.customer_group.Text = "회원조회";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 40);
            this.button2.TabIndex = 17;
            this.button2.Text = "초기화";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 411);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "회원번호";
            // 
            // csearch_ID_txtbox
            // 
            this.csearch_ID_txtbox.Location = new System.Drawing.Point(119, 408);
            this.csearch_ID_txtbox.Name = "csearch_ID_txtbox";
            this.csearch_ID_txtbox.Size = new System.Drawing.Size(186, 25);
            this.csearch_ID_txtbox.TabIndex = 15;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(15, 24);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(536, 302);
            this.dataGridView3.TabIndex = 13;
            // 
            // customer_search_btn
            // 
            this.customer_search_btn.Location = new System.Drawing.Point(383, 369);
            this.customer_search_btn.Name = "customer_search_btn";
            this.customer_search_btn.Size = new System.Drawing.Size(140, 112);
            this.customer_search_btn.TabIndex = 2;
            this.customer_search_btn.Text = "검색";
            this.customer_search_btn.UseVisualStyleBackColor = true;
            this.customer_search_btn.Click += new System.EventHandler(this.customer_search_btn_Click);
            // 
            // soldlist_group
            // 
            this.soldlist_group.Controls.Add(this.button1);
            this.soldlist_group.Controls.Add(this.label15);
            this.soldlist_group.Controls.Add(this.ssearch_ID_txtbox);
            this.soldlist_group.Controls.Add(this.dataGridView4);
            this.soldlist_group.Controls.Add(this.sold_search_btn);
            this.soldlist_group.Enabled = false;
            this.soldlist_group.Location = new System.Drawing.Point(600, 155);
            this.soldlist_group.Name = "soldlist_group";
            this.soldlist_group.Size = new System.Drawing.Size(565, 526);
            this.soldlist_group.TabIndex = 24;
            this.soldlist_group.TabStop = false;
            this.soldlist_group.Text = "판매이력";
            this.soldlist_group.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "초기화";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 411);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 16;
            this.label15.Text = "회원번호";
            // 
            // ssearch_ID_txtbox
            // 
            this.ssearch_ID_txtbox.Location = new System.Drawing.Point(112, 408);
            this.ssearch_ID_txtbox.Name = "ssearch_ID_txtbox";
            this.ssearch_ID_txtbox.Size = new System.Drawing.Size(186, 25);
            this.ssearch_ID_txtbox.TabIndex = 15;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(15, 24);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 27;
            this.dataGridView4.Size = new System.Drawing.Size(536, 302);
            this.dataGridView4.TabIndex = 13;
            // 
            // sold_search_btn
            // 
            this.sold_search_btn.Location = new System.Drawing.Point(383, 369);
            this.sold_search_btn.Name = "sold_search_btn";
            this.sold_search_btn.Size = new System.Drawing.Size(140, 112);
            this.sold_search_btn.TabIndex = 2;
            this.sold_search_btn.Text = "검색";
            this.sold_search_btn.UseVisualStyleBackColor = true;
            this.sold_search_btn.Click += new System.EventHandler(this.sold_search_btn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 693);
            this.Controls.Add(this.soldlist_group);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.order_group);
            this.Controls.Add(this.customer_group);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin";
            this.Text = "관리자모드";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.order_group.ResumeLayout(false);
            this.order_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.customer_group.ResumeLayout(false);
            this.customer_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.soldlist_group.ResumeLayout(false);
            this.soldlist_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox bookname_txtbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox bookprice_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookcount_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bookdelete_btn;
        private System.Windows.Forms.Button bookfix_btn;
        private System.Windows.Forms.Button bookadd_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.TextBox booknum_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button accept_btn;
        private System.Windows.Forms.GroupBox order_group;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label order_num_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox detail_txtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox basic_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox post_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox date_txtbox;
        private System.Windows.Forms.RadioButton order_radio;
        private System.Windows.Forms.RadioButton soldlist_radio;
        private System.Windows.Forms.RadioButton customer_radio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox customer_group;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox csearch_ID_txtbox;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button customer_search_btn;
        private System.Windows.Forms.GroupBox soldlist_group;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ssearch_ID_txtbox;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button sold_search_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label order_state_label;
    }
}