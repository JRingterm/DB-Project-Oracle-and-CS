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
    public partial class Check : Form
    {
        OdbcConnection conn;
        string connectionString = "dsn=mydb;PWD=h101202;UID=ghwns9991";
        private string check_id;
        private string check_pw;
        public string check_passid//mypage에서 이름을 받아오는 함수
        {
            get { return this.check_id; }
            set { this.check_id = value; }
        }
        public string check_passpw//mypage에서 이름을 받아오는 함수
        {
            get { return this.check_pw; }
            set { this.check_pw = value; }
        }
        public Check()
        {
            InitializeComponent();
            ID_txtbox.Select();
            this.MaximizeBox = false;
        }
        private void Check_Load(object sender, EventArgs e)
        {
            MessageBox.Show("본인인증을 위해 다시한번 로그인 해주세요", "본인인증절차");
            conn = new OdbcConnection(connectionString);
            conn.Open(); //데이터베이스 연결
        }

        private void login_btn_Click(object sender, EventArgs e)
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
                if (PW_txtbox.Text == check_pw && ID_txtbox.Text == check_id)
                {
                    string id = ID_txtbox.Text;
                    MessageBox.Show("본인인증이 완료되었습니다.", "본인인증 성공");
                    information info = new information();
                    info.info_passid = id;
                    info.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("아이디 또는 비밀번호가 일치하지 않습니다.", "로그인 실패");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지
            }
        }

        private void PW_txtbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_btn_Click(sender, e);
            }
        }
    }
}
