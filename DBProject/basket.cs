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
    public partial class basket : Form
    {
        OdbcConnection conn;
        string connectionString = "dsn=mydb;PWD=h101202;UID=ghwns9991";
        private string basket_name;
        private string basket_id;
        int basketnum;//회원의 바구니번호 담아두는 변수
        int price;
        string order_num; //주문번호 저장해놓는 변수
        int book_price;
        public string basket_passname//mypage에서 이름을 받아오는 함수
        {
            get { return this.basket_name; }
            set { this.basket_name = value; }
        }
        public string basket_passid//mypage에서 이름을 받아오는 함수
        {
            get { return this.basket_id; }
            set { this.basket_id = value; }
        }
        public basket()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        private void basket_Load(object sender, EventArgs e)
        {
            conn = new OdbcConnection(connectionString);
            conn.Open(); //데이터베이스 연결
            name_label.Text = basket_name + name_label.Text;
            updatebasket();
            updatecard();
            updatehome();
        }
        //장바구니 DB는 도서번호로 도서명, 재고량, 판매가 가져오고, 수량도 표시하기 아마 조인 써야할듯..?
        //도서와 장바구니담기 조인
        private void updatebasket()//장바구니 DB 업데이트
        {
            try
            {
                //회원의 바구니번호를 가져옴
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandText = "select 바구니번호 from 장바구니 where 회원번호 = '" + basket_id + "'"; //장바구니 테이블
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                OdbcDataReader readbasket = cmd.ExecuteReader();
                if (readbasket.Read())
                {
                    basketnum = Int32.Parse(readbasket.GetValue(0).ToString());
                }

                OdbcCommand cmd2 = new OdbcCommand();
                cmd2.CommandText = "select 바구니번호, 장바구니담기.도서번호, 도서명, 수량, 재고량, 판매가 from 장바구니담기, 도서 where 장바구니담기.도서번호 = 도서.도서번호 AND 바구니번호 = " + basketnum; //장바구니 - 도서 조인 테이블
                cmd2.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd2.Connection = conn;
                OdbcDataReader read = cmd2.ExecuteReader();
                dataGridView1.ColumnCount = 7;

                //필드명 받아오는 반복문
                for (int i = 0; i < 6; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                }

                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[6]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < 6; i++) // 필드 수만큼 반복
                    {

                        obj[i] = new object();
                        obj[i] = read.GetValue(i); // 오브젝트배열에 데이터 저장

                    }
                    //MessageBox.Show("확인1");
                    dataGridView1.Rows.Add(obj);
                }
                readbasket.Close();
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
        private void order_btn_Click(object sender, EventArgs e)//장바구니에서 주문
        {
            if (product_label.Text == "null")
            {
                MessageBox.Show("장바구니에서 항목을 선택해주세요.", "항목 미선택");
            }
            else if (home_radio.Checked == false && work_radio.Checked == false)
            {
                MessageBox.Show("배송지를 확인해주세요.", "배송지 미선택");
            }
            else if (post_label.Text == "null" && basic_label.Text == "null" && detail_label.Text == "null")
            {
                MessageBox.Show("배송지를 확인해주세요.", "배송지 미선택");
            }
            else if (cardnum_label.Text == "null" && cardmy_label.Text == "null")
            {
                MessageBox.Show("카드를 선택해주세요.", "카드 미선택");
            }
            else if (0 > Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[4].Value.ToString()) - Int32.Parse(numericUpDown1.Value.ToString()))//선택된 행의 4번째 셀)
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
                        int basketnum = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString());
                        string bookn = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString();
                        string bookname = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[2].Value.ToString();
                        int ordercount = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[3].Value.ToString());
                        int bookcount = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[4].Value.ToString());
                        int bookp = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[5].Value.ToString());
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
                        cmd1.CommandText = "INSERT INTO 주문 VALUES('" + order_num + "', SYSDATE, " + price + ", '신청', '" + cardnum_label.Text + "','" + cardmy_label.Text + "','" + mycard_cbox.SelectedItem.ToString() + "','" + post_label.Text + "','" + basic_label.Text + "','" + detail_label.Text + "','" + basket_id + "')";
                        cmd1.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd1.Connection = conn;
                        cmd1.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                        OdbcCommand cmd2 = new OdbcCommand();
                        cmd2.CommandText = "INSERT INTO 주문선택 VALUES('" + order_num + "','" + bookn_label.Text + "'," + ordercount + ")";
                        cmd2.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd2.Connection = conn;
                        cmd2.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                        OdbcCommand cmd3 = new OdbcCommand();
                        cmd3.CommandText = "UPDATE 도서 SET 재고량 = " + bcount + " where 도서번호 = '" + bookn + "'";
                        cmd3.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd3.Connection = conn;
                        cmd3.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                        //장바구니담기에서 주문한거 삭제
                        OdbcCommand cmd4 = new OdbcCommand();
                        cmd4.CommandText = "delete from 장바구니담기 where 바구니번호 = " + basketnum + " AND 도서번호 = '" + bookn + "'";
                        cmd4.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd4.Connection = conn;
                        cmd4.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                        MessageBox.Show("선택하신 도서를 주문했습니다. ", "주문 완료");
                        dataGridView1.Rows.Clear();
                        updatebasket();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            address_group.Enabled = true;
            product_group.Enabled = true;
            card_group.Enabled = true;
            order_btn.Enabled = true;
            delete_btn.Enabled = true;
            button1.Enabled = true;
            product_label.Visible = true;
            product_label.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            bookn_label.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            book_price = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            price_label.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() + "원";
        }

        private void mycard_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardnum_label.Text = "null";
            cardmy_label.Text = "null";
            try
            {
                OdbcCommand cmd = new OdbcCommand();
                //회원 아이디와 선택한 카드종류를 통해서 회원이 선택한 카드의 카드번호를 가져옴.
                cmd.CommandText = "select 카드번호 from 회원신용카드 where 회원번호 = '" + basket_id + "' AND 카드종류 = '" + mycard_cbox.SelectedItem.ToString() + "'";
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
                cmd.CommandText = "select 유효기간 from 회원신용카드 where 회원번호 = '" + basket_id + "' AND 카드종류 = '" + mycard_cbox.SelectedItem.ToString() + "'";
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            price = Int32.Parse(numericUpDown1.Value.ToString()) * book_price;
            price_label.Text = price.ToString() + "원";
        }
        private void home_radio_CheckedChanged(object sender, EventArgs e)
        {
            updatehome();
        }

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
                cmd.CommandText = "select 우편번호 from 회원주소록 where 회원번호 = '" + basket_id + "' AND 배송지 = '집'";
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
                cmd.CommandText = "select 기본주소 from 회원주소록 where 회원번호 = '" + basket_id + "' AND 배송지 = '집'";
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
                cmd.CommandText = "select 상세주소 from 회원주소록 where 회원번호 = '" + basket_id + "' AND 배송지 = '집'";
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
                cmd.CommandText = "select 우편번호 from 회원주소록 where 회원번호 = '" + basket_id + "' AND 배송지 = '직장'";
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
                cmd.CommandText = "select 기본주소 from 회원주소록 where 회원번호 = '" + basket_id + "' AND 배송지 = '직장'";
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
                cmd.CommandText = "select 상세주소 from 회원주소록 where 회원번호 = '" + basket_id + "' AND 배송지 = '직장'";
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
                cmd.CommandText = "select * from 회원신용카드 where 회원번호 = '" + basket_id + "'";
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
            updatebasket();
            if (work_radio.Checked == true)
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
        private void delete_btn_Click(object sender, EventArgs e)//장바구니 삭제
        {
            if (product_label.Text == "null")
            {
                MessageBox.Show("장바구니에서 항목을 선택해주세요.", "항목 미선택");
            }
            else
            {
                if (MessageBox.Show("해당 도서를 장바구니에서 삭제하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int basketnum = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString());
                        string bookn = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString();
                        //장바구니담기에서 주문한거 삭제
                        OdbcCommand cmd4 = new OdbcCommand();
                        cmd4.CommandText = "delete from 장바구니담기 where 바구니번호 = " + basketnum + " AND 도서번호 = '" + bookn + "'";
                        cmd4.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd4.Connection = conn;
                        cmd4.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                        MessageBox.Show("선택하신 도서를 장바구니에서 삭제했습니다. ", "장바구니 삭제 완료");
                        dataGridView1.Rows.Clear();
                        updatebasket();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message); //에러 메세지
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//수정 버튼
        {
            if (product_label.Text == "null")
            {
                MessageBox.Show("장바구니에서 항목을 선택해주세요.", "항목 미선택");
            }
            else if (Int32.Parse(numericUpDown1.Value.ToString()) > Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[4].Value.ToString())){
                MessageBox.Show("재고가 부족합니다.", "재고부족");
            }
            else
            {
                if (MessageBox.Show("해당 도서의 개수를 수정하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int basketnum = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString());
                        string bookn = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString();
                        //장바구니담기에서 주문한거 삭제
                        OdbcCommand cmd4 = new OdbcCommand();
                        cmd4.CommandText = "UPDATE 장바구니담기 SET 수량 = " + Int32.Parse(numericUpDown1.Value.ToString()) + "where 바구니번호 = " + basketnum + " AND 도서번호 = '" + bookn + "'";
                        cmd4.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd4.Connection = conn;
                        cmd4.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                        MessageBox.Show("선택하신 도서의 개수를 수정했습니다. ", "개수 수정 완료");
                        dataGridView1.Rows.Clear();
                        updatebasket();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message); //에러 메세지
                    }
                }
            }
        }
    }
}
