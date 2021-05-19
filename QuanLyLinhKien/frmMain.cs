using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLinhKien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void addForm(Form f)
        {
            
            this.pnlContent.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.AutoScroll = false;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void quanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon fhd = new frmHoaDon();
            addForm(fhd);
        }

        private void linhKienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLinhKien flk = new frmLinhKien();
            addForm(flk);
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien fnv = new frmNhanVien();
            addForm(fnv);

        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang fkh = new frmKhachHang();
            addForm(fkh);
        }
    }
}
