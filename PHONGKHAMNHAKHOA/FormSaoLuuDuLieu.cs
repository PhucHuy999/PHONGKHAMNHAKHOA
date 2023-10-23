using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHONGKHAMNHAKHOA.GUI
{
    public partial class FormSaoLuuDuLieu : DevExpress.XtraEditors.XtraForm
    {
        public FormSaoLuuDuLieu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source = HY\\PHUCHUY; Initial Catalog = PHONGKHAMNHAKHOA; User ID= sa; Password=123321;");

        private void FormSaoLuuDuLieu_Load(object sender, EventArgs e)
        {
            txtUrl.Enabled = false;
            btnSaoLuu.Enabled = false;
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();//fb==FoderBrowser, k phải facebook đâu nha :v
            if (fb.ShowDialog() == DialogResult.OK)
            {
                txtUrl.Text = fb.SelectedPath;
                btnSaoLuu.Enabled = true;
            }
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            string db = con.Database.ToString();
            if (string.IsNullOrEmpty(txtUrl.Text))
            {
                MessageBox.Show("Vui lòng chọn đường dẫn lưu file sao lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SplashScreenManager.ShowForm(this, typeof(FormHieuUngLoad), true, true, false);
                string sql = "BACKUP DATABASE [" + db + "] TO DISK='" + txtUrl.Text + "\\" + db + "-" + DateTime.Now.ToString("ss-mm-HH--dd-MM-yyyy") + ".bak'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();

                SplashScreenManager.CloseForm(true);
                MessageBox.Show("Sao lưu dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSaoLuu.Enabled = false;
            }
        }
    }
}