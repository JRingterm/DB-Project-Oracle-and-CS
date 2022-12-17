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
    public partial class findpw : Form
    {
        OdbcConnection conn;
        string connectionString = "dsn=mydb;PWD=h101202;UID=ghwns9991";
        string pw;
        public findpw()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)//PW 검색버튼
        {
            conn = new OdbcConnection(connectionString);
            
            if (name_txtbox.Text == "" || ID_txtbox.Text == "")
            {
                MessageBox.Show("입력하지 않은 사항이 있는지 확인해주세요", "미입력 오류!");
            }
            else
            {
                try
                {
                    conn.Open(); //데이터베이스 연결
                    OdbcCommand cmd = new OdbcCommand();

                    cmd.CommandText = "select 비밀번호 from 회원 where 회원번호 = '" + ID_txtbox.Text + "' AND 성명 = '" + name_txtbox.Text + "'";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                    OdbcDataReader read = cmd.ExecuteReader(); //결과
                    if (read.Read())
                    {
                        pw = read.GetValue(0).ToString();
                    }
                    label3.Text = pw;
                    if (label3.Text == "")
                    {
                        MessageBox.Show("회원님의 비밀번호를 찾지 못했습니다.\nID와 성명을 다시 확인해주세요", "찾기 실패");
                    }
                    else
                    {
                        MessageBox.Show("회원님의 비밀번호는 " + pw + "입니다.", "비밀번호 찾기");
                        Close();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); //에러 메세지
                }
            }
        }

        private void name_txtbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
