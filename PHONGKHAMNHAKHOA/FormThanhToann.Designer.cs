namespace PHONGKHAMNHAKHOA.GUI
{
    partial class FormThanhToann
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
            this.slkBenhNhan = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MABN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slkBenhNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // slkBenhNhan
            // 
            this.slkBenhNhan.Location = new System.Drawing.Point(117, 50);
            this.slkBenhNhan.Name = "slkBenhNhan";
            this.slkBenhNhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkBenhNhan.Properties.PopupView = this.searchLookUpEdit1View;
            this.slkBenhNhan.Size = new System.Drawing.Size(207, 20);
            this.slkBenhNhan.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MABN,
            this.HOTEN});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // MABN
            // 
            this.MABN.Caption = "MÃ BN";
            this.MABN.FieldName = "MABN";
            this.MABN.MaxWidth = 70;
            this.MABN.MinWidth = 70;
            this.MABN.Name = "MABN";
            this.MABN.Visible = true;
            this.MABN.VisibleIndex = 0;
            this.MABN.Width = 70;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "TÊN BỆNH NHÂN";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bệnh Nhân";
            // 
            // FormThanhToann
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slkBenhNhan);
            this.Name = "FormThanhToann";
            this.Text = "THANH TOÁN";
            this.Load += new System.EventHandler(this.FormThanhToann_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slkBenhNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit slkBenhNhan;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn MABN;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private System.Windows.Forms.Label label1;
    }
}