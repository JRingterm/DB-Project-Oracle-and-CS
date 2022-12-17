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
    public partial class findid : Form
    {
        OdbcConnection conn;
        string connectionString = "dsn=mydb;PWD=h101202;UID=ghwns9991";
        string id;
        public findid()
        {
            InitializeComponent();
            name_txtbox.Select();
            this.MaximizeBox = false;
        }

        private void button1_Click_1(object sender, EventArgs e)//아이디 찾기
        {
            conn = new OdbcConnection(connectionString);

            if (name_txtbox.Text == "" || PW_txtbox.Text == "")
            {
                MessageBox.Show("입력하지 않은 사항이 있는지 확인해주세요", "미입력 오류!");
            }
            else
            {
                try
                {
                    conn.Open(); //데이터베이스 연결
                    OdbcCommand cmd = new OdbcCommand();

                    cmd.CommandText = "select 회원번호 from 회원 where 성명 = '" + name_txtbox.Text + "' AND 비밀번호 = '" + PW_txtbox.Text + "'";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                    OdbcDataReader read = cmd.ExecuteReader(); //결과
                    if (read.Read())
                    {
                        id = read.GetValue(0).ToString();
                    }
                    label3.Text = id;
                    if (label3.Text == "")
                    {
                        MessageBox.Show("회원님의 아이디를 찾지 못했습니다.\n성명과 PW를 다시 확인해주세요", "찾기 실패");
                    }
                    else
                    {
                        MessageBox.Show("회원님의 아이디는 " + id + "입니다.", "아이디 찾기");
                        Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); //에러 메세지
                }
            }
        }

        private void PW_txtbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click_1(sender, e);
            }
        }
    }
}
