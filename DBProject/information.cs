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
    public partial class information : Form
    {
        OdbcConnection conn;
        string connectionString = "dsn=mydb;PWD=h101202;UID=ghwns9991";
        private string info_id;
        int count; //회원의 주문 개수 저장변수
        public string info_passid//Check에서 ID를 받아오는 함수
        {
            get { return this.info_id; }
            set { this.info_id = value; }
        }
        public information()
        {
            InitializeComponent();
            name_txtbox.Select();
            this.MaximizeBox = false;
        }

        private void information_Load(object sender, EventArgs e)
        {
            conn = new OdbcConnection(connectionString);
            conn.Open(); //데이터베이스 연결
            updatedata();
        }

        private void button1_Click(object sender, EventArgs e)//회원정보 변경 버튼
        {
            if (name_txtbox.Text == null || PW_txtbox.Text == null)
            {
                MessageBox.Show("모든 회원정보를 입력했는지 확인해주세요", "정보 입력 오류");
            }
            else if (MessageBox.Show("회원정보를 변경하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //회원이 입력한 정보에 따라 변경하기
                try
                {
                    OdbcCommand cmd = new OdbcCommand();
                    cmd.CommandText = "UPDATE 회원 SET 비밀번호 = '" + PW_txtbox.Text + "', 성명 = '" + name_txtbox.Text + "' WHERE 회원번호 = '" + info_id + "'";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                    MessageBox.Show("회원정보 변경이 완료되었습니다. 다시 로그인 해주세요", "회원정보 변경 완료");
                    Application.Restart();//윈도우 폼을 아예 재시작
                    //무결성 제약조건으로 회원번호 수정이 안되는듯. 다른방법(삭제후 생성)찾기.
                    //변경했을 떄, 변경 내용 다른 폼에도 적용되도록 하기.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); //에러 메세지
                }
            }
        }
        private void updatedata()
        {
            //주문상태 테이블을 데이터그리드뷰에 임시로 넣어둠
            OdbcCommand cmd7 = new OdbcCommand();
            cmd7.CommandText = "select 주문번호, 주문상태 from 주문 WHERE 회원번호 = '" + info_id + "'";
            cmd7.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
            cmd7.Connection = conn;
            OdbcDataReader readstate = cmd7.ExecuteReader();
            dataGridView1.ColumnCount = 3;
            //필드명 받아오는 반복문
            for (int i = 0; i < 2; i++)
            {
                dataGridView1.Columns[i].Name = readstate.GetName(i);
            }

            //행 단위로 반복
            while (readstate.Read())
            {
                object[] obj = new object[2]; // 필드수만큼 오브젝트 배열

                for (int i = 0; i < 2; i++) // 필드 수만큼 반복
                {
                    obj[i] = new object();
                    obj[i] = readstate.GetValue(i); // 오브젝트배열에 데이터 저장
                }

                dataGridView1.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
            }
            readstate.Close();
        }
        //회원 탈퇴버튼 클릭시
        private void button2_Click(object sender, EventArgs e)//회원탈퇴 버튼
        {
            if (MessageBox.Show("정말 탈퇴하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //회원의 주문한 도서 개수를 가져옴.
                    OdbcCommand cmd = new OdbcCommand();
                    cmd.CommandText = "select count(주문상태) from 주문 WHERE 회원번호 = '" + info_id + "'";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    OdbcDataReader readcount = cmd.ExecuteReader();
                    if (readcount.Read())
                    {
                        count = Int32.Parse(readcount.GetValue(0).ToString());//행 갯수
                    }
                    readcount.Close();
                    
                    string o_state;
                    int check = 0;
                    for(int i = 0; i< count; i++)
                    {
                        o_state = dataGridView1.Rows[i].Cells[1].FormattedValue.ToString();
                        if (o_state == "신청")
                            check = 1;
                    }
                    if (check == 1)
                    {
                        MessageBox.Show("주문하신 도서가 있어서 탈퇴하실 수 없습니다.\n주문을 취소하시거나, 서점측에서 발송할 때까지 기다려주세요.", "탈퇴 불가");
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            OdbcCommand cmd8 = new OdbcCommand();
                            cmd8.CommandText = "DELETE FROM 주문선택 WHERE 주문번호 = '" + dataGridView1.Rows[i].Cells[0].FormattedValue.ToString() + "'";
                            cmd8.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                            cmd8.Connection = conn;
                            cmd8.ExecuteNonQuery();
                        }

                        OdbcCommand cmd1 = new OdbcCommand();
                        cmd1.CommandText = "DELETE FROM 주문 WHERE 회원번호 = '" + info_id + "'";
                        cmd1.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd1.Connection = conn;
                        cmd1.ExecuteNonQuery();

                        OdbcCommand cmd2 = new OdbcCommand();
                        cmd2.CommandText = "DELETE FROM 회원신용카드 WHERE 회원번호 = '" + info_id + "'";
                        cmd2.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd2.Connection = conn;
                        cmd2.ExecuteNonQuery();

                        OdbcCommand cmd3 = new OdbcCommand();
                        cmd3.CommandText = "DELETE FROM 회원주소록 WHERE 회원번호 = '" + info_id + "'";
                        cmd3.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd3.Connection = conn;
                        cmd3.ExecuteNonQuery();

                        OdbcCommand cmd4 = new OdbcCommand();
                        cmd4.CommandText = "DELETE FROM 장바구니담기 WHERE 바구니번호 = (SELECT 바구니번호 FROM 장바구니 WHERE 회원번호 = '" + info_id + "')";
                        cmd4.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd4.Connection = conn;
                        cmd4.ExecuteNonQuery();

                        OdbcCommand cmd5 = new OdbcCommand();
                        cmd5.CommandText = "DELETE FROM 장바구니 WHERE 회원번호 = '" + info_id + "'"; 
                        cmd5.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd5.Connection = conn;
                        cmd5.ExecuteNonQuery();

                        OdbcCommand cmd6 = new OdbcCommand();
                        cmd6.CommandText = "DELETE FROM 회원 WHERE 회원번호 = '" + info_id + "'";
                        cmd6.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd6.Connection = conn;
                        cmd6.ExecuteNonQuery();
                        //주소, 카드 다 삭제하고, 회원삭제. 주문내역이 신청상태이면 탈퇴못하게.

                        MessageBox.Show("탈퇴가 완료되었습니다.\n이용해주셔서 감사합니다.", "회원탈퇴 완료");
                        Application.Restart();
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
                button1_Click(sender, e);
            }
        }

    }
}
