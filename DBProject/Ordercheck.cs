using System;
using System.Collections;
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
    public partial class Ordercheck : Form
    {
        OdbcConnection conn;
        string connectionString = "dsn=mydb;PWD=h101202;UID=ghwns9991";
        private string ordercheck_name;
        private string ordercheck_id;
        object[] order_num;//다수의 주문번호를 저장하는 배열
        int order_count;//회원의 주문의 개수를 저장하는 배열
        object[] obj;
        int bookcount;
        int bookprice;

        public string ordercheck_passname//mypage에서 이름을 받아오는 함수
        {
            get { return this.ordercheck_name; }
            set { this.ordercheck_name = value; }
        }
        public string ordercheck_passid//mypage에서 id를 받아오는 함수
        {
            get { return this.ordercheck_id; }
            set { this.ordercheck_id = value; }
        }
        public Ordercheck()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Ordercheck_Load(object sender, EventArgs e)
        {
            conn = new OdbcConnection(connectionString);
            conn.Open(); //데이터베이스 연결
            updateordercheck();
            //회원번호로 주문번호를 찾아내고, 찾아낸 주문번호로 도서 테이블과 주문번호가 같은 데이터 조인하여 주문도서 찾기
            //dataGridView1.Rows.Clear();
            //dataGridView2.Rows.Clear();
        }

        private void updateordercheck()//주문내역 DB 업데이트
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            try
            {
                //주문의 갯수
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandText = "select count(*) from 주문 where 회원번호 = '" + ordercheck_id + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                OdbcDataReader readcount = cmd.ExecuteReader();
                if (readcount.Read())
                {
                    order_count = Int32.Parse(readcount.GetValue(0).ToString());
                }

                //회원의 주문번호를 가져옴(주문은 여러개일 수 있으니 배열로 주문번호를 저장)
                OdbcCommand cmd1 = new OdbcCommand();
                cmd1.CommandText = "select 주문번호 from 주문 where 회원번호 = '" + ordercheck_id + "'";
                cmd1.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd1.Connection = conn;
                OdbcDataReader readordernum = cmd1.ExecuteReader();

                while (readordernum.Read())
                {
                    order_num = new object[1];
                    for (int i = 0; i < 1; i++)
                    {
                        order_num[i] = new object();
                        order_num[i] = readordernum.GetValue(i);//주문번호를 저장
                    }
                    dataGridView2.Rows.Add(order_num);    //임시로 데이터그리드2에 주문번호 담아놓음              
                }
                //데이터 그리드뷰의 필드명을 받기 위함
                OdbcCommand cmd2 = new OdbcCommand();
                cmd2.CommandText = "select 주문번호, 주문선택.도서번호, 도서명, 수량 from 주문선택, 도서 where 주문선택.도서번호 = 도서.도서번호 AND 주문번호 = '" + order_num[0] + "'"; //장바구니 - 도서 조인 테이블
                cmd2.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd2.Connection = conn;
                OdbcDataReader readfield = cmd2.ExecuteReader();
                dataGridView1.ColumnCount = 5;
                for (int j = 0; j < 4; j++)
                {
                    dataGridView1.Columns[j].Name = readfield.GetName(j);
                }

                //주문선택 - 도서 조인 테이블을 만들어서 주문내역 데이터그리드뷰에 저장
                for (int i = 0; i < order_count; i++)
                {
                    OdbcCommand cmd3 = new OdbcCommand();
                    cmd3.CommandText = "select 주문번호, 주문선택.도서번호, 도서명, 수량 from 주문선택, 도서 where 주문선택.도서번호 = 도서.도서번호 AND 주문번호 = '" + dataGridView2.Rows[i].Cells[0].FormattedValue.ToString() + "'"; //장바구니 - 도서 조인 테이블
                    cmd3.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd3.Connection = conn;
                    OdbcDataReader read = cmd3.ExecuteReader();

                    while (read.Read())
                    {
                        obj = new object[4];
                        for (int n = 0; n < 4; n++)
                        {
                            obj[n] = new object();
                            obj[n] = read.GetValue(n);
                        }
                        dataGridView1.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
                    }
                }
                readcount.Close();
                readordernum.Close();
                readfield.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void button1_Click(object sender, EventArgs e)//수취확인 버튼
        {
            if (ordernum_txtbox.Text == "")
            {
                MessageBox.Show("주문내역을 선택해주세요", "주문내역 미선택");
            }
            else if (state_label.Text == "신청")
            {
                MessageBox.Show("아직 발송되지 않은 주문입니다.");
            }
            else if (state_label.Text == "판매완료")
            {
                MessageBox.Show("이미 수취확인된 주문입니다.");
            }
            else
            {
                if (MessageBox.Show("해당 주문에 대한 도서를 수취하셨습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        OdbcCommand cmd = new OdbcCommand();
                        cmd.CommandText = "UPDATE 주문 SET 주문상태 = '판매완료' where 주문번호 = '" + ordernum_txtbox.Text + "'";
                        cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd.Connection = conn;
                        OdbcDataReader readorder = cmd.ExecuteReader();
                        MessageBox.Show("수취확인 되었습니다.");

                        updateordercheck();
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
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            numericUpDown1.Enabled = true;
            ordernum_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            bookname_txtbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            try
            {
                //세부정보 표시

                //주문일자 표시
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandText = "select 주문일자 from 주문 where 주문번호 = '" + ordernum_txtbox.Text + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                OdbcDataReader readdate = cmd.ExecuteReader();
                if (readdate.Read())
                {
                    date_txtbox.Text = readdate.GetValue(0).ToString();
                }

                //배송지_우편번호 표시
                OdbcCommand cmd1 = new OdbcCommand();
                cmd1.CommandText = "select 배송지_우편번호 from 주문 where 주문번호 = '" + ordernum_txtbox.Text + "'";
                cmd1.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd1.Connection = conn;
                OdbcDataReader readpost = cmd1.ExecuteReader();
                if (readpost.Read())
                {
                    post_txtbox.Text = readpost.GetValue(0).ToString();
                }

                //배송지_기본주소 표시
                OdbcCommand cmd2 = new OdbcCommand();
                cmd2.CommandText = "select 배송지_기본주소 from 주문 where 주문번호 = '" + ordernum_txtbox.Text + "'";
                cmd2.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd2.Connection = conn;
                OdbcDataReader readbasic = cmd2.ExecuteReader();
                if (readbasic.Read())
                {
                    basic_txtbox.Text = readbasic.GetValue(0).ToString();
                }

                //배송지_상세주소 표시
                OdbcCommand cmd3 = new OdbcCommand();
                cmd3.CommandText = "select 배송지_상세주소 from 주문 where 주문번호 = '" + ordernum_txtbox.Text + "'";
                cmd3.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd3.Connection = conn;
                OdbcDataReader readdetail = cmd3.ExecuteReader();
                if (readdetail.Read())
                {
                    detail_txtbox.Text = readdetail.GetValue(0).ToString();
                }

                //주문상태 표시
                OdbcCommand cmd4 = new OdbcCommand();
                cmd4.CommandText = "select 주문상태 from 주문 where 주문번호 = '" + ordernum_txtbox.Text + "'";
                cmd4.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd4.Connection = conn;
                OdbcDataReader readstate = cmd4.ExecuteReader();
                if (readstate.Read())
                {
                    state_label.Text = readstate.GetValue(0).ToString();
                }

                //재고량 표시
                OdbcCommand cmd5 = new OdbcCommand();
                cmd5.CommandText = "select 재고량 from 도서 where 도서번호 = '" + Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString()) + "'";
                cmd5.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd5.Connection = conn;
                OdbcDataReader read = cmd5.ExecuteReader();
                if (readstate.Read())
                {
                    label6.Text = read.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }

        private void button2_Click(object sender, EventArgs e)//주문취소
        {
            if (ordernum_txtbox.Text == "")
            {
                MessageBox.Show("주문내역을 선택해주세요", "주문내역 미선택");
            }
            else
            {
                if (MessageBox.Show("해당 주문을 취소하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        int bookc = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[3].Value.ToString());//수량
                        int bookn = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString());//도서번호
                        OdbcCommand cmd = new OdbcCommand();
                        cmd.CommandText = "delete from 주문선택 where 주문번호 = '" + ordernum_txtbox.Text + "'";
                        cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();

                        OdbcCommand cmd2 = new OdbcCommand();
                        cmd2.CommandText = "delete from 주문 where 주문번호 = '" + ordernum_txtbox.Text + "'";
                        cmd2.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd2.Connection = conn;
                        cmd2.ExecuteNonQuery();

                        OdbcCommand cmd3 = new OdbcCommand();
                        cmd3.CommandText = "select 재고량 from 도서 where 도서번호 = '" + bookn + "'";
                        cmd3.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd3.Connection = conn;
                        cmd3.ExecuteNonQuery();
                        OdbcDataReader read = cmd3.ExecuteReader();
                        if (read.Read())
                        {
                            bookcount = Int32.Parse(read.GetValue(0).ToString());
                        }
                        int book_total_count = bookc + bookcount;
                        OdbcCommand cmd4 = new OdbcCommand();
                        cmd4.CommandText = "UPDATE 도서 SET 재고량 = " + book_total_count + " where 도서번호 = '" + bookn + "'";
                        cmd4.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd4.Connection = conn;
                        cmd4.ExecuteNonQuery();
                        MessageBox.Show("주문이 취소 되었습니다.");
                        updateordercheck();
                        ordernum_txtbox.Text = null;
                        bookname_txtbox.Text = null;
                        date_txtbox.Text = null;
                        post_txtbox.Text = null;
                        basic_txtbox.Text = null;
                        detail_txtbox.Text = null;
                        state_label.Text = "null";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message); //에러 메세지 
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)//주문수정
        {
            if (ordernum_txtbox.Text == "")
            {
                MessageBox.Show("주문내역을 선택해주세요", "주문내역 미선택");
            }
            else if (state_label.Text == "발송" || state_label.Text == "판매완료")
            {
                MessageBox.Show("발송 중인 주문이거나 수취완료된 주문입니다.", "수정 오류");
            }
            else if (state_label.Text == "신청")
            {
                if (Int32.Parse(numericUpDown1.Value.ToString()) > Int32.Parse(label6.Text))
                {
                    MessageBox.Show("재고가 부족합니다.", "재고 부족"); ;
                }
                else
                {
                    if (MessageBox.Show("주문 개수를 수정하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int bookc = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[3].Value.ToString());//수량
                            int bookn = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString());//도서번호

                            OdbcCommand cmd5 = new OdbcCommand();//도서의 현재 재고량 받아옴
                            cmd5.CommandText = "select 재고량 from 도서 where 도서번호 = '" + bookn + "'";
                            cmd5.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                            cmd5.Connection = conn;
                            cmd5.ExecuteNonQuery();
                            OdbcDataReader read = cmd5.ExecuteReader();
                            if (read.Read())
                            {
                                bookcount = Int32.Parse(read.GetValue(0).ToString());
                            }
                            int book_total_count = bookc + bookcount;
                            int book_total_count2 = book_total_count - Int32.Parse(numericUpDown1.Value.ToString());

                            OdbcCommand cmd3 = new OdbcCommand();//도서 재고량 변화
                            cmd3.CommandText = "UPDATE 도서 SET 재고량 = " + book_total_count2 + "where 도서번호 = '" + bookn + "'";
                            cmd3.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                            cmd3.Connection = conn;
                            cmd3.ExecuteNonQuery();

                            OdbcCommand cmd = new OdbcCommand();//주문선택의 수량 변화
                            cmd.CommandText = "UPDATE 주문선택 SET 수량 = " + Int32.Parse(numericUpDown1.Value.ToString()) + " where 주문번호 = '" + ordernum_txtbox.Text + "'";
                            cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                            cmd.Connection = conn;
                            cmd.ExecuteNonQuery();

                            OdbcCommand cmd6 = new OdbcCommand();//도서의 가격 받아옴
                            cmd6.CommandText = "select 판매가 from 도서 where 도서번호 = '" + bookn + "'";
                            cmd6.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                            cmd6.Connection = conn;
                            cmd6.ExecuteNonQuery();
                            OdbcDataReader readprice = cmd6.ExecuteReader();
                            if (readprice.Read())
                            {
                                bookprice = Int32.Parse(readprice.GetValue(0).ToString());
                            }
                            int booK_total_price = bookprice * Int32.Parse(numericUpDown1.Value.ToString());

                            OdbcCommand cmd2 = new OdbcCommand();//주문의 주문총액 변화
                            cmd2.CommandText = "UPDATE 주문 SET 주문총액 = " + booK_total_price + " where 주문번호 = '" + ordernum_txtbox.Text + "'";
                            cmd2.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                            cmd2.Connection = conn;
                            cmd2.ExecuteNonQuery();

                            MessageBox.Show("주문 개수가 수정되었습니다.");
                            updateordercheck();
                            ordernum_txtbox.Text = null;
                            bookname_txtbox.Text = null;
                            date_txtbox.Text = null;
                            post_txtbox.Text = null;
                            basic_txtbox.Text = null;
                            detail_txtbox.Text = null;
                            state_label.Text = "null";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message); //에러 메세지 
                        }
                    }
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = numericUpDown1.Value.ToString();
        }

    }
}

