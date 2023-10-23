namespace PHONGKHAMNHAKHOA.GUI
{
    partial class FormSaoLuuDuLieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaoLuuDuLieu));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnBrowser = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaoLuu = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dẫn lưu file:";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(119, 25);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(227, 21);
            this.txtUrl.TabIndex = 1;
            // 
            // btnBrowser
            // 
            this.btnBrowser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBrowser.ImageOptions.SvgImage")));
            this.btnBrowser.Location = new System.Drawing.Point(352, 17);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(92, 37);
            this.btnBrowser.TabIndex = 2;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaoLuu.ImageOptions.SvgImage")));
            this.btnSaoLuu.Location = new System.Drawing.Point(183, 65);
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.Size = new System.Drawing.Size(92, 37);
            this.btnSaoLuu.TabIndex = 3;
            this.btnSaoLuu.Text = "Sao lưu";
            this.btnSaoLuu.Click += new System.EventHandler(this.btnSaoLuu_Click);
            // 
            // FormSaoLuuDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 120);
            this.Controls.Add(this.btnSaoLuu);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Name = "FormSaoLuuDuLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAO LƯU DỮ LIỆU";
            this.Load += new System.EventHandler(this.FormSaoLuuDuLieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private DevExpress.XtraEditors.SimpleButton btnBrowser;
        private DevExpress.XtraEditors.SimpleButton btnSaoLuu;
    }
}