using System.Windows.Forms;

namespace GUI
{
    public class CenterForm
    {
        public static void ToForm(Form form)
        {
            // Đặt StartPosition thành Manual để có thể kiểm soát vị trí của form
            form.StartPosition = FormStartPosition.Manual;

            // Lấy kích thước của màn hình
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Tính toán vị trí mới cho form
            int formWidth = form.Width;
            int formHeight = form.Height;

            int x = (screenWidth - formWidth) / 2;
            int y = (screenHeight - formHeight) / 2;

            // Đặt vị trí mới cho form
            form.Location = new System.Drawing.Point(x, y);
        }
    }

}