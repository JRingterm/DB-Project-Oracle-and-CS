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
    public partial class mypage : Form
    {
        OdbcConnection conn;
        string connectionString = "dsn=mydb;PWD=h101202;UID=ghwns9991";
        private string mypage_name;
        private string mypage_id;
        private string mypage_pw;
        public string mypage_passname//main에서 이름을 받아오는 함수
        {
            get { return this.mypage_name; }
            set { this.mypage_name = value; }
        }
        public string mypage_passid//main에서 이름을 받아오는 함수
        {
            get { return this.mypage_id; }
            set { this.mypage_id = value; }
        }
        public string mypage_passpw//main에서 이름을 받아오는 함수
        {
            get { return this.mypage_pw; }
            set { this.mypage_pw = value; }
        }

        public mypage()
        {
            InitializeComponent();
            mycard_cbox.Items.Clear();
            this.MaximizeBox = false;
        }
        private void mypage_Load(object sender, EventArgs e)
        {
            name_label.Text = mypage_passname + name_label.Text;
            id_label.Text = mypage_id;//테스트용임 최종때는 삭제하기
            card_cbox.SelectedIndex = 0;
            conn = new OdbcConnection(connectionString);
            conn.Open(); //데이터베이스 연결
            updatecard();
            
        }
        //=================================회원의 카드등록정보 가져오기
        private void updatecard()//카드정보 가져옴
        {
            mycard_cbox.Items.Clear();
            try
            {
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandText = "select * from 회원신용카드 where 회원번호 = '" + mypage_id + "'";
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
        //==================================회원의 배송지 정보 가져오기
        private void updateaddress()
        {
            //mycard_cbox.Items.Clear();
            try
            {
                OdbcCommand cmd = new OdbcCommand();
                cmd.CommandText = "select * from 회원주소록 where 회원번호 = '" + mypage_id + "'";
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
        //====================================================카드등록 버튼
        private void addcard_btn_Click(object sender, EventArgs e)
        {
            if(cardnum1_txtbox.TextLength < 4 || cardnum2_txtbox.TextLength < 4 || cardnum3_txtbox.TextLength < 4 || cardnum4_txtbox.TextLength < 3)
            {
                MessageBox.Show("카드번호를 정확히 입력했는지 확인해주세요", "카드번호 입력 오류");
            }
            else if(month_txtbox.TextLength < 2 || year_txtbox.TextLength < 2 || Int32.Parse(month_txtbox.Text) > 12)
            {
                MessageBox.Show("유효기간을 정확히 입력했는지 확인해주세요", "유효기간 입력 오류");
            }
            else if (Int32.Parse(month_txtbox.Text) < 12 && Int32.Parse(year_txtbox.Text) <= 20)//2020년 12월달 이전의 유효기간을 가진 카드는 사용불가
            {
                MessageBox.Show("유효기간이 지난 카드입니다", "유효기간 오류");
            }
            else if (MessageBox.Show("카드를 등록하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //회원이 입력한 정보에 따라 카드등록 하기
                try
                {
                    string date = month_txtbox.Text + "/" + year_txtbox.Text;
                    //DateTime myDate = DateTime.Parse(date);
                    OdbcCommand cmd = new OdbcCommand();
                    cmd.CommandText = "INSERT INTO 회원신용카드 VALUES('" + mypage_id + "','" + cardnum1_txtbox.Text + cardnum2_txtbox.Text + cardnum3_txtbox.Text + cardnum4_txtbox.Text + "','" + date + "','" + card_cbox.SelectedItem.ToString() + "')";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                    MessageBox.Show("카드 등록이 완료되었습니다.", "카드등록 완료");
                    cardnum1_txtbox.Clear();
                    cardnum2_txtbox.Clear();
                    cardnum3_txtbox.Clear();
                    cardnum4_txtbox.Clear();
                    month_txtbox.Clear();
                    year_txtbox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); //에러 메세지
                }
                updatecard();
            }
        }
        //==============================================텍스트박스에서 숫자만 입력받도록 함.
        private void Num_only(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
        //===============================회원이 등록한 카드 콤보박스에서 카드종류를 선택하면 그에대한 정보를 가져옴.
        private void mycard_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OdbcCommand cmd = new OdbcCommand();
                //회원 아이디와 선택한 카드종류를 통해서 회원이 선택한 카드의 카드번호를 가져옴.
                cmd.CommandText = "select 카드번호 from 회원신용카드 where 회원번호 = '" + mypage_id + "' AND 카드종류 = '" + mycard_cbox.SelectedItem.ToString() +"'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                OdbcDataReader readnum = cmd.ExecuteReader(); //결과
                while (readnum.Read())
                {
                    cardnum_txtbox.Text = readnum.GetValue(0).ToString();
                }
                readnum.Close();

                //회원 아이디와 선택한 카드종류를 통해서 회원이 선택한 카드의 유효기간을 가져옴.
                cmd.CommandText = "select 유효기간 from 회원신용카드 where 회원번호 = '" + mypage_id + "' AND 카드종류 = '" + mycard_cbox.SelectedItem.ToString() + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                OdbcDataReader readm_y = cmd.ExecuteReader(); //결과
                while (readm_y.Read())
                {
                    m_y_txtbox.Text = readm_y.GetValue(0).ToString();
                }
                readm_y.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지
            }
        }
        //==================================================================카드삭제 버튼
        private void deletecard_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택하신 카드를 삭제하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    OdbcCommand cmd = new OdbcCommand();
                    //회원 아이디와 선택한 카드종류를 통해서 회원이 선택한 카드의 카드번호를 가져옴.
                    cmd.CommandText = "delete from 회원신용카드 where 회원번호 = '" + mypage_id + "' AND 카드종류 = '" + mycard_cbox.SelectedItem.ToString() + "'";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                    MessageBox.Show("등록된 카드를 삭제했습니다.", "카드 삭제 완료");
                    cardnum_txtbox.Clear();
                    m_y_txtbox.Clear();
                    updatecard();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); //에러 메세지
                }
            }
        }
        //============================================================배송지 등록 버튼
        private void addaddress_btn_Click(object sender, EventArgs e)
        {
            if (home_radio.Checked == false && work_radio.Checked == false)
            {
                MessageBox.Show("자택, 직장 중 하나를 선택해주세요.", "미선택 오류");
            }
            else if (post_txtbox.Text == null || basic_txtbox.Text == null || detail_txtbox.Text == null)
            {
                MessageBox.Show("주소를 입력했는지 확인해주세요", "주소 입력 오류");
            }
            else if (home_radio.Checked == true)
            {
                if (MessageBox.Show("배송지를 등록하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //회원이 입력한 정보에 따라 배송지 등록 하기
                    try
                    {
                        OdbcCommand cmd = new OdbcCommand();
                        cmd.CommandText = "INSERT INTO 회원주소록 VALUES('" + mypage_id + "','집','" + post_txtbox.Text + "','" + basic_txtbox.Text + "','" + detail_txtbox.Text + "')";
                        cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                        MessageBox.Show("배송지 등록이 완료되었습니다.", "배송지 등록 완료");
                        post_txtbox.Clear();
                        basic_txtbox.Clear();
                        detail_txtbox.Clear();
                        home_radio.Checked = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message); //에러 메세지
                    }
                }
            }
            else if(work_radio.Checked == true)
            {
                if (MessageBox.Show("배송지를 등록하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //회원이 입력한 정보에 따라 배송지 등록 하기
                    try
                    {
                        OdbcCommand cmd = new OdbcCommand();
                        cmd.CommandText = "INSERT INTO 회원주소록 VALUES('" + mypage_id + "','직장','" + post_txtbox.Text + "','" + basic_txtbox.Text + "','" + detail_txtbox.Text + "')";
                        cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                        MessageBox.Show("배송지 등록이 완료되었습니다.", "배송지 등록 완료");
                        post_txtbox.Clear();
                        basic_txtbox.Clear();
                        detail_txtbox.Clear();
                        work_radio.Checked = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message); //에러 메세지
                    }
                }
            }
        }
        //====================================================배송지 수정 버튼
        private void fixaddress_btn_Click(object sender, EventArgs e)
        {
            if (chome_radio.Checked == false && cwork_radio.Checked == false)
            {
                MessageBox.Show("수정하실 배송지를 선택해주세요", "배송지 미선택");
            }
            else if (chome_radio.Checked == true)
            {
                if (MessageBox.Show("자택 배송지를 수정하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        OdbcCommand cmd = new OdbcCommand();
                        //회원 아이디와 선택한 배송지(자택)를 통해서 자택 배송지 수정
                        cmd.CommandText = "UPDATE 회원주소록 SET 우편번호 = '" + cpost_txtbox.Text + "', 기본주소 = '" + cbasic_txtbox.Text + "', 상세주소 = '" + cdetail_txtbox.Text + "' WHERE 회원번호 = '" + mypage_id + "' AND 배송지 = '집'";
                        cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                        MessageBox.Show("자택 배송지가 수정되었습니다.", "배송지 수정 완료");
                        cpost_txtbox.Clear();
                        cbasic_txtbox.Clear();
                        cdetail_txtbox.Clear();
                        homeChecked();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message); //에러 메세지
                    }
                }
            }
            else if (cwork_radio.Checked == true)
            {
                if (MessageBox.Show("직장 배송지를 수정하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        OdbcCommand cmd = new OdbcCommand();
                        //회원 아이디와 선택한 배송지(직장)를 통해서 직장 배송지 삭제
                        cmd.CommandText = "UPDATE 회원주소록 SET 우편번호 = '" + cpost_txtbox.Text + "', 기본주소 = '" + cbasic_txtbox.Text + "', 상세주소 = '" + cdetail_txtbox.Text + "' WHERE 회원번호 = '" + mypage_id + "' AND 배송지 = '직장'";
                        cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                        MessageBox.Show("직장 배송지가 수정되었습니다.", "배송지 수정 완료");
                        cpost_txtbox.Clear();
                        cbasic_txtbox.Clear();
                        cdetail_txtbox.Clear();
                        workChecked();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message); //에러 메세지
                    }
                }
            }
        }
        //======================================================배송지 삭제 버튼
        private void deleteaddress_btn_Click(object sender, EventArgs e)
        {
            if (chome_radio.Checked == false && cwork_radio.Checked == false)
            {
                MessageBox.Show("삭제하실 배송지를 선택해주세요", "배송지 미선택");
            }
            else if (chome_radio.Checked == true)
            {
                if (MessageBox.Show("자택 배송지를 삭제하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        OdbcCommand cmd = new OdbcCommand();
                        //회원 아이디와 선택한 배송지(자택)를 통해서 자택 배송지 삭제
                        cmd.CommandText = "delete from 회원주소록 where 회원번호 = '" + mypage_id + "' AND 배송지 = '집'";
                        cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                        MessageBox.Show("자택 배송지가 삭제되었습니다.", "배송지 삭제 완료");
                        cpost_txtbox.Clear();
                        cbasic_txtbox.Clear();
                        cdetail_txtbox.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message); //에러 메세지
                    }
                }
            }
            else if (cwork_radio.Checked == true)
            {
                if (MessageBox.Show("직장 배송지를 삭제하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        OdbcCommand cmd = new OdbcCommand();
                        //회원 아이디와 선택한 배송지(직장)를 통해서 직장 배송지 삭제
                        cmd.CommandText = "delete from 회원주소록 where 회원번호 = '" + mypage_id + "' AND 배송지 = '직장'";
                        cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                        MessageBox.Show("직장 배송지가 삭제되었습니다.", "배송지 삭제 완료");
                        cpost_txtbox.Clear();
                        cbasic_txtbox.Clear();
                        cdetail_txtbox.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message); //에러 메세지
                    }
                }
            }
        }
        //=========================================배송지 등록시에 라디오버튼 누르면 텍스트박스 비워짐
        private void home_radio_CheckedChanged(object sender, EventArgs e)
        {
            post_txtbox.Clear();
            basic_txtbox.Clear();
            detail_txtbox.Clear();
        }

        private void work_radio_CheckedChanged(object sender, EventArgs e)
        {
            post_txtbox.Clear();
            basic_txtbox.Clear();
            detail_txtbox.Clear();
        }
        //==============================================자택, 직장 라디오버튼 선택 시에 회원의 배송지 정보 표시
        private void chome_radio_CheckedChanged(object sender, EventArgs e)
        {
            homeChecked();
        }

        private void cwork_radio_CheckedChanged(object sender, EventArgs e)
        {
            workChecked();
        }
        //===================================================자택 라디오버튼 선택 후 배송지 조회
        private void homeChecked()
        {
            cpost_txtbox.Clear();
            cbasic_txtbox.Clear();
            cdetail_txtbox.Clear();
            try
            {
                OdbcCommand cmd = new OdbcCommand();
                //회원 아이디와 배송지를 통해서 우편번호를 가져옴
                cmd.CommandText = "select 우편번호 from 회원주소록 where 회원번호 = '" + mypage_id + "' AND 배송지 = '집'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                OdbcDataReader readpost = cmd.ExecuteReader(); //결과
                while (readpost.Read())
                {
                    cpost_txtbox.Text = readpost.GetValue(0).ToString();
                }
                readpost.Close();

                //회원 아이디와 배송지를 통해서 기본주소를 가져옴
                cmd.CommandText = "select 기본주소 from 회원주소록 where 회원번호 = '" + mypage_id + "' AND 배송지 = '집'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                OdbcDataReader readbasic = cmd.ExecuteReader(); //결과
                while (readbasic.Read())
                {
                    cbasic_txtbox.Text = readbasic.GetValue(0).ToString();
                }
                readbasic.Close();

                //회원 아이디와 배송지를 통해서 상세주소를 가져옴
                cmd.CommandText = "select 상세주소 from 회원주소록 where 회원번호 = '" + mypage_id + "' AND 배송지 = '집'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                OdbcDataReader readdetail = cmd.ExecuteReader(); //결과
                while (readdetail.Read())
                {
                    cdetail_txtbox.Text = readdetail.GetValue(0).ToString();
                }
                readdetail.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지
            }
        }
        //===================================================직장 라디오버튼 선택 후 배송지 조회
        private void workChecked()
        {
            cpost_txtbox.Clear();
            cbasic_txtbox.Clear();
            cdetail_txtbox.Clear();
            try
            {
                OdbcCommand cmd = new OdbcCommand();
                //회원 아이디와 배송지를 통해서 우편번호를 가져옴
                cmd.CommandText = "select 우편번호 from 회원주소록 where 회원번호 = '" + mypage_id + "' AND 배송지 = '직장'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                OdbcDataReader readpost = cmd.ExecuteReader(); //결과
                while (readpost.Read())
                {
                    cpost_txtbox.Text = readpost.GetValue(0).ToString();
                }
                readpost.Close();

                //회원 아이디와 배송지를 통해서 기본주소를 가져옴
                cmd.CommandText = "select 기본주소 from 회원주소록 where 회원번호 = '" + mypage_id + "' AND 배송지 = '직장'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                OdbcDataReader readbasic = cmd.ExecuteReader(); //결과
                while (readbasic.Read())
                {
                    cbasic_txtbox.Text = readbasic.GetValue(0).ToString();
                }
                readbasic.Close();

                //회원 아이디와 배송지를 통해서 상세주소를 가져옴
                cmd.CommandText = "select 상세주소 from 회원주소록 where 회원번호 = '" + mypage_id + "' AND 배송지 = '직장'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                OdbcDataReader readdetail = cmd.ExecuteReader(); //결과
                while (readdetail.Read())
                {
                    cdetail_txtbox.Text = readdetail.GetValue(0).ToString();
                }
                readdetail.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지
            }
        }

        //==========================================================회원정보 변경 버튼
        private void information_btn_Click(object sender, EventArgs e)
        {
            Check check = new Check();
            check.check_passid = mypage_id;
            check.check_passpw = mypage_pw;
            check.ShowDialog();
        }
        //====================================================주문조회 버튼
        private void orderview_btn_Click(object sender, EventArgs e)
        {
            Ordercheck order_check = new Ordercheck();
            order_check.ordercheck_passid = mypage_id;
            order_check.ordercheck_passname = mypage_name;
            order_check.ShowDialog();
        }
        //=====================================================장바구니 버튼
        private void basket_btn_Click(object sender, EventArgs e)
        {
            basket bas = new basket();
            bas.basket_passname = mypage_name;
            bas.basket_passid = mypage_id;
            bas.ShowDialog();
        }

    }
}
