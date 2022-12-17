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
    public partial class Register : Form
    {
        string connectionString = "dsn=mydb;PWD=h101202;UID=ghwns9991";
        public Register()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            Name_txtbox.Select();
        }
  
        private void register_btn_Click(object sender, EventArgs e)//회원가입 버튼
        {
            OdbcConnection conn;
            // OleDbConnection conn;
            conn = new OdbcConnection(connectionString);
            //conn = new OleDbConnection();
            try
            {
                conn.Open(); //데이터베이스 연결
                OdbcCommand cmd = new OdbcCommand();
                //OleDbCommand cmd = new OleDbCommand();
                if (Name_txtbox.Text == "" || ID_txtbox.Text == "" || PW_txtbox.Text == "" || PWC_txtbox.Text == "")
                {
                    MessageBox.Show("입력하지 않은 사항이 있는지 확인해주세요", "미입력 오류!");
                }
                else if(PW_txtbox.Text != PWC_txtbox.Text)
                {
                    MessageBox.Show("비밀번호를 확인해주세요", "비밀번호 일치오류!");
                }
                else if (MessageBox.Show("회원가입 하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd.CommandText = "INSERT INTO 회원 VALUES('" + ID_txtbox.Text + "','" + PW_txtbox.Text + "','" + Name_txtbox.Text + "')";  //회원 테이블
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                    //회원가입할때 장바구니 생성
                    OdbcCommand cmd2 = new OdbcCommand();
                    cmd2.CommandText = "INSERT INTO 장바구니(바구니번호, 생성일자, 회원번호) VALUES(basket_no.NEXTVAL,SYSDATE,'" + ID_txtbox.Text + "')";
                    cmd2.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd2.Connection = conn;
                    cmd2.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                    MessageBox.Show("회원가입이 완료되었습니다.", "회원가입 완료");
                    Close();//회원가입 창을 닫음

                }
            }
            catch (Exception ex) 
            {
                   MessageBox.Show("Error: " + ex.Message); //에러 메세지
            }

            finally
            {
                if (conn != null)
                {
                    conn.Close(); //데이터베이스 연결 해제
                }
            }
        }

        private void PWC_txtbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                register_btn_Click(sender, e);
            }
        }
    }
}
