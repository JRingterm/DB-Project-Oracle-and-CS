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
    public partial class Admin : Form
    {
        OdbcConnection conn;
        string connectionString = "dsn=mydb;PWD=h101202;UID=ghwns9991";
        public Admin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            conn = new OdbcConnection(connectionString);
            conn.Open(); //데이터베이스 연결
            updatedb();
            updatecustomer();
        }
        private void Num_only(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
        private void updatedb()//도서 DB 업데이트
        {
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
        private void updatesold()//판매이력 테이블
        {
            dataGridView4.Rows.Clear();
            try
            {
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandText = "select * from 주문"; //도서 테이블
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OdbcDataReader read = cmd.ExecuteReader(); //select * from 도서 결과
                dataGridView4.ColumnCount = 12;
                //필드명 받아오는 반복문
                for (int i = 0; i < 11; i++)
                {
                    dataGridView4.Columns[i].Name = read.GetName(i);
                }

                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[11]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < 11; i++) // 필드 수만큼 반복
                    {
                        obj[i] = new object();
                        obj[i] = read.GetValue(i); // 오브젝트배열에 데이터 저장
                    }

                    dataGridView4.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
        private void updatecustomer()//회원검색 테이블
        {
            dataGridView3.Rows.Clear();
            try
            {
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandText = "select * from 회원"; //도서 테이블
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OdbcDataReader read = cmd.ExecuteReader(); //select * from 도서 결과
                dataGridView3.ColumnCount = 4;
                //필드명 받아오는 반복문
                for (int i = 0; i < 3; i++)
                {
                    dataGridView3.Columns[i].Name = read.GetName(i);
                }

                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[3]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < 3; i++) // 필드 수만큼 반복
                    {
                        obj[i] = new object();
                        obj[i] = read.GetValue(i); // 오브젝트배열에 데이터 저장
                    }

                    dataGridView3.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
        private void updateorder()//주문 테이블 받아오기
        {
            dataGridView2.Rows.Clear();
            try
            {
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandText = "select * from 주문"; //도서 테이블
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OdbcDataReader read = cmd.ExecuteReader(); //select * from 도서 결과
                dataGridView2.ColumnCount = 12;
                //필드명 받아오는 반복문
                for (int i = 0; i < 11; i++)
                {
                    dataGridView2.Columns[i].Name = read.GetName(i);
                }

                //행 단위로 반복
                while (read.Read())
                {
                    object[] obj = new object[11]; // 필드수만큼 오브젝트 배열

                    for (int i = 0; i < 11; i++) // 필드 수만큼 반복
                    {
                        obj[i] = new object();
                        obj[i] = read.GetValue(i); // 오브젝트배열에 데이터 저장
                    }

                    dataGridView2.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            booknum_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            bookname_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            bookcount_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            bookprice_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }

        private void bookadd_btn_Click(object sender, EventArgs e)//도서추가버튼
        {
            dataGridView1.Rows.Clear();
            //conn = new OdbcConnection(connectionString);
            try
            {
                //conn.Open(); //데이터베이스 연결
                OdbcCommand cmd = new OdbcCommand();
                //입력한 도서정보 데이터베이스에 저장
                cmd.CommandText = "INSERT INTO 도서 VALUES(book_no.NEXTVAL, '" + bookname_txtbox.Text + "'," + Int32.Parse(bookcount_txtbox.Text) + "," + Int32.Parse(bookprice_txtbox.Text) + ")";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                updatedb();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }

        }
        
        private void bookfix_btn_Click(object sender, EventArgs e)//수정 버튼
        {
            dataGridView1.Rows.Clear();
            //conn = new OdbcConnection(connectionString);
            try
            {
                //conn.Open(); //데이터베이스 연결
                OdbcCommand cmd = new OdbcCommand();
                //입력한 도서정보 데이터베이스에 저장
                cmd.CommandText = "UPDATE 도서 SET 도서명 = '" + bookname_txtbox.Text + "', 재고량 = " + Int32.Parse(bookcount_txtbox.Text) + ", 판매가 = " + Int32.Parse(bookprice_txtbox.Text);
                cmd.CommandText = cmd.CommandText + " WHERE 도서번호 = '" + booknum_txtbox.Text + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                updatedb();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }

        }

        private void bookdelete_btn_Click(object sender, EventArgs e)//삭제버튼
        {

            dataGridView1.Rows.Clear();
            //conn = new OdbcConnection(connectionString);
            try
            {
                //conn.Open(); //데이터베이스 연결
                OdbcCommand cmd = new OdbcCommand();
                //입력한 도서정보 데이터베이스에 저장
                cmd.CommandText = "DELETE FROM 도서 WHERE 도서번호 = '" + booknum_txtbox.Text + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                updatedb();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }

        }

        private void clear_btn_Click(object sender, EventArgs e)//초기화버튼
        {
            dataGridView1.Rows.Clear();
            booknum_txtbox.Clear();
            bookname_txtbox.Clear();
            bookcount_txtbox.Clear();
            bookprice_txtbox.Clear();
            //conn = new OdbcConnection(connectionString);
            //conn.Open(); //데이터베이스 연결
            updatedb();
        }

        private void accept_btn_Click(object sender, EventArgs e)//주문승인버튼
        {
            
            //string order_state = dataGridView2.Rows[dataGridView1.CurrentCellAddress.Y].Cells[3].Value.ToString();//주문상태 정보
            //string order_number = dataGridView2.Rows[dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString();//주문번호 정보
            if (order_num_label.Text == "order_num")
            {
                MessageBox.Show("주문을 선택해주세요");
            }
            else if (order_state_label.Text == "발송" || order_state_label.Text == "판매완료")
            {
                MessageBox.Show("이미 승인된 주문입니다.");
            }
            else if (order_state_label.Text == "신청")
            {
                try
                {
                    OdbcCommand cmd = new OdbcCommand();
                    //입력한 도서정보 데이터베이스에 저장
                    cmd.CommandText = "UPDATE 주문 SET 주문상태 = '발송' where 주문번호 = '" + order_num_label.Text + "'";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                    MessageBox.Show("주문 승인이 완료되었습니다.", "승인 완료");
                    updateorder();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); //에러 메세지 
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)//주문관리 테이블
        {
            date_txtbox.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            post_txtbox.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
            basic_txtbox.Text = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();
            detail_txtbox.Text = dataGridView2.Rows[e.RowIndex].Cells[9].Value.ToString();
            order_num_label.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            order_state_label.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void customer_radio_CheckedChanged(object sender, EventArgs e)//회원정보
        {
            order_group.Visible = false;
            order_group.Enabled = false;
            soldlist_group.Visible = false;
            soldlist_group.Enabled = false;
            customer_group.Visible = true;
            customer_group.Enabled = true;
            updatecustomer();
        }

        private void soldlist_radio_CheckedChanged(object sender, EventArgs e)//회원별 판매이력
        {
            order_group.Visible = false;
            order_group.Enabled = false;
            customer_group.Visible = false;
            customer_group.Enabled = false;
            soldlist_group.Visible = true;
            soldlist_group.Enabled = true;
            updatesold();
        }

        private void order_radio_CheckedChanged(object sender, EventArgs e)//주문관리
        {
            soldlist_group.Visible = false;
            soldlist_group.Enabled = false;
            customer_group.Visible = false;
            customer_group.Enabled = false;
            order_group.Visible = true;
            order_group.Enabled = true;
            updateorder();
            /*
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            date_txtbox.Visible = true;
            post_txtbox.Visible = true;
            basic_txtbox.Visible = true;
            detail_txtbox.Visible = true;
            date_txtbox.Enabled = true;
            post_txtbox.Enabled = true;
            basic_txtbox.Enabled = true;
            detail_txtbox.Enabled = true;
            accept_btn.Visible = true;
            accept_btn.Enabled = true;*/
        }

        private void customer_search_btn_Click(object sender, EventArgs e)//회원 검색 버튼
        {
            //conn = new OdbcConnection(connectionString);
            if (csearch_ID_txtbox.Text == null)
            {
                MessageBox.Show("검색하실 회원번호를 입력하세요");
            }
            else
            {
                try
                {
                    dataGridView3.Rows.Clear();
                    //conn.Open(); //데이터베이스 연결
                    OdbcCommand cmd = new OdbcCommand();
                    //입력한 도서정보 데이터베이스에 저장
                    cmd.CommandText = "select * from 회원 where 회원번호 = '" + csearch_ID_txtbox.Text + "'";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                    OdbcDataReader read = cmd.ExecuteReader(); //select * from 도서 결과
                    dataGridView3.ColumnCount = 4;
                    //필드명 받아오는 반복문
                    for (int i = 0; i < 3; i++)
                    {
                        dataGridView3.Columns[i].Name = read.GetName(i);
                    }

                    //행 단위로 반복
                    while (read.Read())
                    {
                        object[] obj = new object[3]; // 필드수만큼 오브젝트 배열

                        for (int i = 0; i < 3; i++) // 필드 수만큼 반복
                        {
                            obj[i] = new object();
                            obj[i] = read.GetValue(i); // 오브젝트배열에 데이터 저장
                        }

                        dataGridView3.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                    }
                    read.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); //에러 메세지 
                }
            }
        }

        private void sold_search_btn_Click(object sender, EventArgs e)//판매이력 검색 버튼
        {
            //conn = new OdbcConnection(connectionString);
            if (ssearch_ID_txtbox.Text == null)
            {
                MessageBox.Show("검색하실 회원번호를 입력하세요");
            }
            else
            {
                try
                {
                    dataGridView4.Rows.Clear();
                    //conn.Open(); //데이터베이스 연결
                    OdbcCommand cmd = new OdbcCommand();
                    //입력한 도서정보 데이터베이스에 저장
                    cmd.CommandText = "select * from 주문 where 회원번호 = '" + ssearch_ID_txtbox.Text + "'";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                    OdbcDataReader read = cmd.ExecuteReader(); //select * from 도서 결과
                    dataGridView4.ColumnCount = 12;
                    //필드명 받아오는 반복문
                    for (int i = 0; i < 11; i++)
                    {
                        dataGridView4.Columns[i].Name = read.GetName(i);
                    }

                    //행 단위로 반복
                    while (read.Read())
                    {
                        object[] obj = new object[11]; // 필드수만큼 오브젝트 배열

                        for (int i = 0; i < 11; i++) // 필드 수만큼 반복
                        {
                            obj[i] = new object();
                            obj[i] = read.GetValue(i); // 오브젝트배열에 데이터 저장
                        }

                        dataGridView4.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                    }
                    read.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); //에러 메세지 
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)//회원조회의 초기화버튼
        {
            dataGridView3.Rows.Clear();
            csearch_ID_txtbox.Clear();
            //conn = new OdbcConnection(connectionString);
            //conn.Open(); //데이터베이스 연결
            updatecustomer();
        }

        private void button1_Click(object sender, EventArgs e)//판매이력의 초기화버튼
        {
            dataGridView4.Rows.Clear();
            ssearch_ID_txtbox.Clear();
            //conn = new OdbcConnection(connectionString);
            //conn.Open(); //데이터베이스 연결
            updatesold();
        }
    }
}
