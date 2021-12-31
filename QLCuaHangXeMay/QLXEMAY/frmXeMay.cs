using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLXEMAY.Model;
using DevExpress.XtraGrid.Views.Grid;

namespace QLXEMAY
{
    public partial class frmXeMay : DevExpress.XtraEditors.XtraForm
    {
        public frmXeMay()
        {
            InitializeComponent();
        }

        bool cal(Int32 _Width, GridView _view)
        {
            _view.IndicatorWidth = _view.IndicatorWidth < _Width ? _Width : _view.IndicatorWidth;
            return true;
        }
        private void gvDanhSach_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator) //Nếu là dòng Indicator
            {
                if (e.RowHandle < 0)
                {
                    e.Info.ImageIndex = 0;
                    e.Info.DisplayText = string.Empty;
                }
                else
                {
                    e.Info.ImageIndex = -1; //Nếu hiển thị
                    e.Info.DisplayText = (e.RowHandle + 1).ToString(); //Số thứ tự tăng dần
                }
                SizeF sizeF = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lây kích thước của vùng hiển thị Text
                Int32 _Width = Convert.ToInt32(sizeF.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvXeMay); })); // Tăng kích thước nếu text vượt quá
            }
        }
        void loadHangXe()
        {
            cmbNhaCungCap.DataSource = myClass.getData("select * from NHACUNGCAP");
            cmbNhaCungCap.DisplayMember = "TENNCC";
            cmbNhaCungCap.ValueMember = "MANCC";
        }
        private void frmXeMay_Load(object sender, EventArgs e)
        {
            gcXeMay.DataSource = myClass.getData("select * from XEMAY a, NHACUNGCAP b where a.MANCC=b.MANCC");
            gvXeMay.ExpandAllGroups();
            loadHangXe();
            cmbTinhTrang.Items.Add("Mới");
            cmbTinhTrang.Items.Add("Like new");
            cmbTinhTrang.Items.Add("99%");
            cmbTinhTrang.Items.Add("Đi được 1000km");
            cmbTinhTrang.Items.Add("Đi 1 năm");
        }


    }
}