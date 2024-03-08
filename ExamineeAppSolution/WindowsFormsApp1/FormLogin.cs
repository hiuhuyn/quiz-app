using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;

using System.Windows.Forms;
using System.Xml;

using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
    
        private readonly string apiUrl = Constaints.POST_TEACHER_LOGIN_URL; // Thay thế bằng URL của API của bạn
        private readonly HttpClient httpClient = new HttpClient();
        public FormLogin()
        {
            InitializeComponent();
        }
       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string passWord = txtPass.Text;
            // Kiểm tra xem có dữ liệu hợp lệ không
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Vui lòng nhập ID và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo chuỗi XML chứa thông tin đăng nhập
            string xmlData = $@"<?xml version='1.0' encoding='utf-8'?>
                            <Examinee>
                            <ExamineeID>{id}</ExamineeID>
                            <ExamineePassword>{passWord}</ExamineePassword>
                        </Examinee>";

                try
                {
                    var content = new StringContent(xmlData, Encoding.UTF8, "application/xml");
                    HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseXml = await response.Content.ReadAsStringAsync();
                        // Xử lý phản hồi XML từ server
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(responseXml);
                        XmlNode apiKeyNode = doc.SelectSingleNode("//APIKey/Key");
                        if (apiKeyNode != null)
                        {
                           APIKey.Key = apiKeyNode.InnerText;
                           Examinee.ExamineeID = id;
                            // Xử lý API key nhận được, ví dụ: lưu vào cấu hình hoặc sử dụng cho các yêu cầu tiếp theo
                            Console.WriteLine("Đã nhận được API key: " + APIKey.Key);

                            // Hiển thị form trang chính
                            FormTrangChu f = new FormTrangChu();
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy API key trong phản hồi từ server.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra khi gửi yêu cầu đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

        }


        private void FormĐăngNhập_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }

}

    

