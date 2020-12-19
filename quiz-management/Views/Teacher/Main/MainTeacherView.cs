using quiz_management.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Teacher.Main
{
    public partial class MainTeacherView : Form
    {
        private bool isCollapsed;
        private bool isCollapsed1;
        
        private bool isCollapsed3;
        
        private bool isCollapsed5;
        public MainTeacherView(int code)
        {
            InitializeComponent();
        }

        private void QuizManager_Click(object sender, EventArgs e)
        {
            timerQLCauHoi.Start();
        }

        private void btnQLDeThi_Click(object sender, EventArgs e)
        {
            timerQLDeThi.Start();
        }

       

        private void btnLamBaiThi_Click(object sender, EventArgs e)
        {
            timerLamBaiThi.Start();
        }

        private void timeQLKyThi_Tick(object sender, EventArgs e)
        {
            if (isCollapsed3)
            {
                btnQLKyThi.Image = Resources.Collapse_Arrow_20px;
                panelQLKyThi.Height += 10;
                if (panelQLKyThi.Size == panelQLKyThi.MaximumSize)
                {
                    timeQLKyThi.Stop();
                    isCollapsed3 = false;
                }
            }
            else
            {
                btnQLKyThi.Image = Resources.Expand_Arrow_20px;
                panelQLKyThi.Height -= 10;
                if (panelQLKyThi.Size == panelQLKyThi.MinimumSize)
                {
                    timeQLKyThi.Stop();
                    isCollapsed3 = true;
                }
            }
        }

        

        private void QLCauHoi_Tick(object sender, EventArgs e)
        {
            if (isCollapsed1)
            {
                btnQuizManager.Image = Resources.Collapse_Arrow_20px;
                panelQLCauHoi.Height += 10;
                if (panelQLCauHoi.Size == panelQLCauHoi.MaximumSize)
                {
                    timerQLCauHoi.Stop();
                    isCollapsed1 = false;
                }
            }
            else
            {
                btnQuizManager.Image = Resources.Expand_Arrow_20px;
                panelQLCauHoi.Height -= 10;
                if (panelQLCauHoi.Size == panelQLCauHoi.MinimumSize)
                {
                    timerQLCauHoi.Stop();
                    isCollapsed1 = true;
                }
            }
        }

        private void LamBaiThi_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btnLamBaiThi.Image = Resources.Collapse_Arrow_20px;
                panelLamBaiThi.Height += 10;
                if (panelLamBaiThi.Size == panelLamBaiThi.MaximumSize)
                {
                    timerLamBaiThi.Stop();
                    isCollapsed = false;
                }
            }
            else
            {

                btnLamBaiThi.Image = Resources.Expand_Arrow_20px;
                panelLamBaiThi.Height -= 10;
                if (panelLamBaiThi.Size == panelLamBaiThi.MinimumSize)
                {
                    timerLamBaiThi.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnQLKyThi_Click(object sender, EventArgs e)
        {
            timeQLKyThi.Start();
        }

        

        

        private void ThongKe_Tick(object sender, EventArgs e)
        {
            if (isCollapsed5)
            {
                btnThongKe.Image = Resources.Collapse_Arrow_20px;
                panelThongKe.Height += 10;
                if (panelThongKe.Size == panelThongKe.MaximumSize)
                {
                    timerThongKe.Stop();
                    isCollapsed5 = false;
                }
            }
            else
            {
                btnThongKe.Image = Resources.Expand_Arrow_20px;
                panelThongKe.Height -= 10;
                if (panelThongKe.Size == panelThongKe.MinimumSize)
                {
                    timerThongKe.Stop();
                    isCollapsed5 = true;
                }
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            timerThongKe.Start();
        }

        
    }
}
