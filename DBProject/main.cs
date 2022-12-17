using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace DBProject
{
    public partial class main : Form
    {
        OdbcConnection conn;
        string connectionString = "dsn=mydb;PWD=h101202;UID=ghwns9991";
        string addname; //사용자의 이름 저장해놓는 변수
        string id;  //사용자의 ID 저장해놓는 변수
        int book_price; //도서의 값 저장해놓는 변수
        int price; //판매가 * 개수 =총 판매량 변수
        string order_num; //주문번호 저장해놓는 변수
        string pw;

        public main()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            ID_txtbox.Select();//폼 실행 시에 ID 텍스트박스에 포커싱
            this.MaximizeBox = false;
            mycard_cbox.Items.Clear();
        }
        private void main_Load(object sender, EventArgs e)
        {
            conn = new OdbcConnection(connectionString);
            conn.Open(); //데이터베이스 연결
        }
        private void login_btn_Click(object sender, EventArgs e) //로그인 버튼
        {

            if (ID_txtbox.Text == "admin" && PW_txtbox.Text == "1234")//따로 계정을 만들지 말랬으니..
            {
                Admin ad = new Admin();
                ad.ShowDialog();
            }
            else
            {
                try
                {
                    if (ID_txtbox.Text == "" || PW_txtbox.Text == "")
                    {
                        MessageBox.Show("ID 또는 비밀번호를 입력하세요", "로그인 오류");
                        return;
                    }
                    OdbcCommand cmd = new OdbcCommand();
                    cmd.CommandText = "select 비밀번호 from 회원 where 회원번호 = " + "'" + ID_txtbox.Text + "'"; //아이디에 해당하는 비밀번호 탐색
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    OdbcDataReader readpass = cmd.ExecuteReader(); //비밀번호 확인에 대한 결과

                    OdbcCommand name = new OdbcCommand();
                    name.CommandText = "select 성명 from 회원 where 회원번호 = " + "'" + ID_txtbox.Text + "'"; //아이디에 해당하는 성명
                    name.CommandType = CommandType.Text;
                    name.Connection = conn;
                    OdbcDataReader readname = name.ExecuteReader(); //성명 확인에 대한 결과

                    if (readpass.Read())
                    {
                        if (PW_txtbox.Text != readpass["비밀번호"].ToString())
                        {
                            MessageBox.Show("비밀번호가 일치하지 않습니다.", "로그인 실패");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("등록되지 않은 ID 입니다.", "로그인 실패");
                        return;
                    }
                    MessageBox.Show("로그인 되었습니다.", "환영합니다.");
                    id = ID_txtbox.Text.ToString();
                    pw = PW_txtbox.Text.ToString();
                    ID_txtbox.Text = null;
                    PW_txtbox.Text = null;
                    readpass.Close();

                    label4.Visible = false;
                    label5.Visible = false;
                    ID_txtbox.Enabled = false;
                    PW_txtbox.Enabled = false;
                    ID_txtbox.Visible = false;
                    PW_txtbox.Visible = false;
                    find_id_btn.Enabled = false;
                    find_pw_btn.Enabled = false;
                    find_id_btn.Visible = false;
                    find_pw_btn.Visible = false;
                    login_btn.Enabled = false;
                    register_btn.Enabled = false;
                    login_btn.Visible = false;
                    register_btn.Visible = false;
                    label1.Visible = true;
                    mypage_btn.Enabled = true;
                    logout_btn.Enabled = true;
                    mypage_btn.Visible = true;
                    logout_btn.Visible = true;
                    basket_btn.Enabled = true;
                    order_btn.Enabled = true;
                    update_btn.Enabled = true;
                    dataGridView1.Enabled = true;
                    if (readname.Read())
                    {
                        addname = readname["성명"].ToString();
                        label1.Text = addname + label1.Text;
                    }
                    readname.Close();
                    updatedb();
                    updatecard();
                    updatehome();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); //에러 메세지
                }
            }
        }
        private void updatedb()//도서 DB 업데이트
        {
            dataGridView1.Rows.Clear();
            try
            {
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandText = "select * from 도서"; //도서 테이블
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OdbcDataReader read = cmd.ExecuteReader(); //select * from 도서 결과
                dataGridView1.ColumnCount = 5;
                //필드명 받아오는 반복문
                for (int i = 0; i < 4; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                }

                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[4]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < 4; i++) // 필드 수만큼 반복
                    {
                        obj[i] = new object();
                        obj[i] = read.GetValue(i); // 오브젝트배열에 데이터 저장
                    }

                    dataGridView1.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
        private void updatecard()//회원의 카드정보를 가져옴
        {
            mycard_cbox.Items.Clear();
            cardmy_label.Text = "null";
            cardnum_label.Text = "null";
            cardnum_label.Visible = false;
            cardmy_label.Visible = false;
            try
            {
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandText = "select * from 회원신용카드 where 회원번호 = '" + id + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                OdbcDataReader read = cmd.ExecuteReader(); //결과
                while (read.Read())
                {
                    mycard_cbox.Items.Add(read.GetValue(3));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지
            }
            if (mycard_cbox.Items.Count != 0)
            {
                mycard_cbox.SelectedIndex = 0;
            }
        }
        private void update()//새로고침
        {
            updatedb();
            updatecard();
            if(work_radio.Checked == true)
            {
                updatehome();
                updatework(); 
            }
            else
            {
                updatework();
                updatehome();
            }
            
        }
        private void register_btn_Click(object sender, EventArgs e)//회원가입 버튼
        {
            Register register = new Register();
            register.ShowDialog();
        }
        //비밀번호를 입력하고 엔터키를 입력하면 로그인되도록.
        private void PW_txtbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_btn_Click(sender, e);
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)//로그아웃 버튼
        {
            if (MessageBox.Show("로그아웃 하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("로그아웃 되었습니다.", "로그아웃");
                label4.Visible = true;
                label5.Visible = true;
                ID_txtbox.Enabled = true;
                PW_txtbox.Enabled = true;
                ID_txtbox.Visible = true;
                PW_txtbox.Visible = true;
                find_id_btn.Enabled = true;
                find_pw_btn.Enabled = true;
                find_id_btn.Visible = true;
                find_pw_btn.Visible = true;
                login_btn.Enabled = true;
                register_btn.Enabled = true;
                login_btn.Visible = true;
                register_btn.Visible = true;
                label1.Visible = false;
                mypage_btn.Enabled = false;
                logout_btn.Enabled = false;
                mypage_btn.Visible = false;
                logout_btn.Visible = false;
                basket_btn.Enabled = false;
                order_btn.Enabled = false;
                dataGridView1.Enabled = false;
                numericUpDown1.Value = 1;
                product_label.Visible = false;
                post_label.Visible = false;
                basic_label.Visible = false;
                detail_label.Visible = false;
                cardnum_label.Visible = false;
                cardmy_label.Visible = false;
                update_btn.Enabled = false;
                price_label.Text = "원";
                mycard_cbox.Items.Clear();
                address_group.Enabled = false;
                product_group.Enabled = false;
                card_group.Enabled = false;
                ID_txtbox.Select();
                label1.Text = "님";
                addname = null;
                id = null;
                dataGridView1.Rows.Clear();
            }
        }
        //그리드 뷰의 셀을 클릭했을 때
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            address_group.Enabled = true;
            product_group.Enabled = true;
            card_group.Enabled = true;
            product_label.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            product_label.Visible = true;
            bookn_label.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            numericUpDown1.Value = 1;
            book_price = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            //int price = Int32.Parse(numericUpDown1.Value.ToString()) * Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            price_label.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "원";

        }
        //자택 라디오버튼을 선택했을 때
        private void home_radio_CheckedChanged(object sender, EventArgs e)
        {
            updatehome();
        }
        //직장 라디오버튼을 선택했을 때
        private void work_radio_CheckedChanged(object sender, EventArgs e)
        {
            updatework();
        }
        private void updatehome()
        {
            post_label.Text = "null";
            basic_label.Text = "null";
            detail_label.Text = "null";
            try
            {
                OdbcCommand cmd = new OdbcCommand();
                //회원 아이디와 배송지를 통해서 우편번호를 가져옴
                cmd.CommandText = "select 우편번호 from 회원주소록 where 회원번호 = '" + id + "' AND 배송지 = '집'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                OdbcDataReader readpost = cmd.ExecuteReader(); //결과
                while (readpost.Read())
                {
                    post_label.Text = readpost.GetValue(0).ToString();
                }
                readpost.Close();

                //회원 아이디와 배송지를 통해서 기본주소를 가져옴
                cmd.CommandText = "select 기본주소 from 회원주소록 where 회원번호 = '" + id + "' AND 배송지 = '집'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                OdbcDataReader readbasic = cmd.ExecuteReader(); //결과
                while (readbasic.Read())
                {
                    basic_label.Text = readbasic.GetValue(0).ToString();
                }
                readbasic.Close();

                //회원 아이디와 배송지를 통해서 상세주소를 가져옴
                cmd.CommandText = "select 상세주소 from 회원주소록 where 회원번호 = '" + id + "' AND 배송지 = '집'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                OdbcDataReader readdetail = cmd.ExecuteReader(); //결과
                while (readdetail.Read())
                {
                    detail_label.Text = readdetail.GetValue(0).ToString();
                }
                post_label.Visible = true;
                basic_label.Visible = true;
                detail_label.Visible = true;
                readdetail.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지
            }
        }
        private void updatework()
        {
            post_label.Text = "null";
            basic_label.Text = "null";
            detail_label.Text = "null";
            try
            {
                OdbcCommand cmd = new OdbcCommand();
                //회원 아이디와 배송지를 통해서 우편번호를 가져옴
                cmd.CommandText = "select 우편번호 from 회원주소록 where 회원번호 = '" + id + "' AND 배송지 = '직장'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                OdbcDataReader readpost = cmd.ExecuteReader(); //결과
                while (readpost.Read())
                {
                    post_label.Text = readpost.GetValue(0).ToString();
                }
                readpost.Close();

                //회원 아이디와 배송지를 통해서 기본주소를 가져옴
                cmd.CommandText = "select 기본주소 from 회원주소록 where 회원번호 = '" + id + "' AND 배송지 = '직장'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                OdbcDataReader readbasic = cmd.ExecuteReader(); //결과
                while (readbasic.Read())
                {
                    basic_label.Text = readbasic.GetValue(0).ToString();
                }
                readbasic.Close();

                //회원 아이디와 배송지를 통해서 상세주소를 가져옴
                cmd.CommandText = "select 상세주소 from 회원주소록 where 회원번호 = '" + id + "' AND 배송지 = '직장'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                OdbcDataReader readdetail = cmd.ExecuteReader(); //결과
                while (readdetail.Read())
                {
                    detail_label.Text = readdetail.GetValue(0).ToString();
                }
                post_label.Visible = true;
                basic_label.Visible = true;
                detail_label.Visible = true;
                readdetail.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지
            }
        }
        
        //배송지 등록 및 변경 버튼 눌렀을 때
        private void address_btn_Click(object sender, EventArgs e)
        {
            mypage my = new mypage();
            my.mypage_passname = addname;
            my.mypage_passid = id;
            my.ShowDialog();
        }
        //numericUPDOWN의 값을 변화시켰을 때, 도서 값 * 개수 계산
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            price = Int32.Parse(numericUpDown1.Value.ToString()) * book_price;
            price_label.Text = price.ToString() + "원";
        }
        private void mypage_btn_Click(object sender, EventArgs e)//마이페이지 버튼
        {
            mypage my = new mypage();
            my.mypage_passname = addname;
            my.mypage_passid = id;
            my.mypage_passpw = pw;
            my.ShowDialog();
        }
        //==========================================주문하기 버튼
        private void order_btn_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString();//선택된 행의 0번째 셀

            if (product_label.Text == "null")
            {
                MessageBox.Show("도서를 선택해주세요.", "상품 미선택");
            }
            else if (home_radio.Checked == false && work_radio.Checked == false)
            {
                MessageBox.Show("배송지를 확인해주세요.", "배송지 미선택");
            }
            else if (post_label.Text == "null" && basic_label.Text == "null" && detail_label.Text == "null")
            {
                MessageBox.Show("배송지를 확인해주세요.", "배송지 미선택");
            }
            else if(cardnum_label.Text == "null" && cardmy_label.Text == "null")
            {
                MessageBox.Show("카드를 선택해주세요.", "카드 미선택");
            }
            else if (0 > Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[2].Value.ToString()) - Int32.Parse(numericUpDown1.Value.ToString()))//선택된 행의 2번째 셀)
            {
                MessageBox.Show("선택하신 도서의 재고가 부족합니다.", "재고 부족");
            }
            else
            {
                if (MessageBox.Show("해당 상품을 주문하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //도서 정보를 가져옴
                        string bookn = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString();
                        string bookname = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString();
                        int bookcount = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[2].Value.ToString());
                        int bookp = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[3].Value.ToString());
                        int bcount = bookcount - Int32.Parse(numericUpDown1.Value.ToString());//재고량 - 주문
                        price = bookp * Int32.Parse(numericUpDown1.Value.ToString());
                        //주문번호 생성
                        OdbcCommand cmd = new OdbcCommand();
                        cmd.CommandText = "select TO_CHAR(SYSDATE,'YYYYMMDD') || LPAD(order_no.NEXTVAL,3,0) from dual";
                        cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                        OdbcDataReader readorder_num = cmd.ExecuteReader();
                        if (readorder_num.Read())
                        {
                            order_num = readorder_num.GetValue(0).ToString();
                        }
                        
                        //주문하면 주문테이블에 주문번호와 각종 회원정보를 넣음
                        OdbcCommand cmd1 = new OdbcCommand();
                        cmd1.CommandText = "INSERT INTO 주문 VALUES('" + order_num + "', SYSDATE, " + price + ", '신청', '" + cardnum_label.Text + "','" + cardmy_label.Text + "','" + mycard_cbox.SelectedItem.ToString() + "','" + post_label.Text + "','" + basic_label.Text + "','" + detail_label.Text + "','" + id +"')";
                        cmd1.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd1.Connection = conn;
                        cmd1.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                        
                        OdbcCommand cmd2 = new OdbcCommand();
                        cmd2.CommandText = "INSERT INTO 주문선택 VALUES('" + order_num + "','" + bookn_label.Text + "'," + Int32.Parse(numericUpDown1.Value.ToString()) + ")";
                        cmd2.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd2.Connection = conn;
                        cmd2.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                        OdbcCommand cmd3 = new OdbcCommand();
                        cmd3.CommandText = "UPDATE 도서 SET 재고량 = " + bcount + " where 도서번호 = '" + bookn + "'";
                        cmd3.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd3.Connection = conn;
                        cmd3.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                        MessageBox.Show("선택하신 도서를 주문했습니다. ", "주문 완료");
                        dataGridView1.Rows.Clear();
                        updatedb();
                        //post_txtbox.Clear();
                        //basic_txtbox.Clear();
                        //detail_txtbox.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message); //에러 메세지
                    }
                }
            }
        }
        //장바구니 담기 버튼
        private void basket_btn_Click(object sender, EventArgs e)
        {
            if (product_label.Text == "null")
            {
                MessageBox.Show("도서를 선택해주세요.", "상품 미선택");
            }
            else if (home_radio.Checked == false && work_radio.Checked == false)
            {
                MessageBox.Show("배송지를 확인해주세요.", "배송지 미선택");
            }
            else if (post_label.Text == "null" && basic_label.Text == "null" && detail_label.Text == "null")
            {
                MessageBox.Show("배송지를 확인해주세요.", "배송지 미선택");
            }
            else if ("0" == dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[2].Value.ToString())//선택된 행의 2번째 셀)
            {
                MessageBox.Show("선택하신 도서가 품절되었습니다.", "도서 품절");
            }
            else
            {
                if (MessageBox.Show("장바구니에 담으시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int basket_num = 0;
                        OdbcCommand cmd = new OdbcCommand();
                        cmd.CommandText = "SELECT 바구니번호 from 장바구니 WHERE 회원번호 = '" + id + "'";
                        cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                        OdbcDataReader read = cmd.ExecuteReader();
                        if (read.Read())
                        {
                            basket_num = Int32.Parse(read.GetValue(0).ToString());
                        }
                        OdbcCommand cmd2 = new OdbcCommand();
                        cmd2.CommandText = "INSERT INTO 장바구니담기 VALUES('" + basket_num + "','" + bookn_label.Text + "','" + Int32.Parse(numericUpDown1.Value.ToString()) + "')";
                        cmd2.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd2.Connection = conn;
                        cmd2.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                        MessageBox.Show("장바구니에 해당 도서를 담았습니다. ", "장바구니 담기 완료");
                        //post_txtbox.Clear();
                        //basic_txtbox.Clear();
                        //detail_txtbox.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message); //에러 메세지
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardnum_label.Text = "null";
            cardmy_label.Text = "null";
            try
            {
                OdbcCommand cmd = new OdbcCommand();
                //회원 아이디와 선택한 카드종류를 통해서 회원이 선택한 카드의 카드번호를 가져옴.
                cmd.CommandText = "select 카드번호 from 회원신용카드 where 회원번호 = '" + id + "' AND 카드종류 = '" + mycard_cbox.SelectedItem.ToString() + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                OdbcDataReader readnum = cmd.ExecuteReader(); //결과
                while (readnum.Read())
                {
                    cardnum_label.Text = readnum.GetValue(0).ToString();
                }
                readnum.Close();

                //회원 아이디와 선택한 카드종류를 통해서 회원이 선택한 카드의 유효기간을 가져옴.
                cmd.CommandText = "select 유효기간 from 회원신용카드 where 회원번호 = '" + id + "' AND 카드종류 = '" + mycard_cbox.SelectedItem.ToString() + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                OdbcDataReader readm_y = cmd.ExecuteReader(); //결과
                while (readm_y.Read())
                {
                    cardmy_label.Text = readm_y.GetValue(0).ToString();
                }
                readm_y.Close();
                cardnum_label.Visible = true;
                cardmy_label.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            findpw Fpw = new findpw();
            Fpw.ShowDialog();
        }

        private void find_id_btn_Click(object sender, EventArgs e)
        {
            findid Fid = new findid();
            Fid.ShowDialog();
        }
    }
}

