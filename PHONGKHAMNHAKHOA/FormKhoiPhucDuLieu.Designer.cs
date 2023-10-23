namespace PHONGKHAMNHAKHOA.GUI
{
    partial class FormKhoiPhucDuLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhoiPhucDuLieu));
            this.btnKhoiPhuc = new DevExpress.XtraEditors.SimpleButton();
            this.btnBrowser = new DevExpress.XtraEditors.SimpleButton();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaoLuu.ImageOptions.SvgImage")));
            this.btnKhoiPhuc.Location = new System.Drawing.Point(175, 75);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(92, 37);
            this.btnKhoiPhuc.TabIndex = 7;
            this.btnKhoiPhuc.Text = "Sao lưu";
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBrowser.ImageOptions.SvgImage")));
            this.btnBrowser.Location = new System.Drawing.Point(332, 24);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(92, 37);
            this.btnBrowser.TabIndex = 6;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(82, 32);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(239, 21);
            this.txtUrl.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn file:";
            // 
            // FormKhoiPhucDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 132);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Name = "FormKhoiPhucDuLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHÔI PHỤC DỮ LIỆU";
            this.Load += new System.EventHandler(this.FormKhoiPhucDuLieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKhoiPhuc;
        private DevExpress.XtraEditors.SimpleButton btnBrowser;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
    }
}