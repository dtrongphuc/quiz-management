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
        private bool isCollapsed2;
        private bool isCollapsed3;
        private bool isCollapsed4;
        private bool isCollapsed5;
        public MainTeacherView()
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
                if (!isCollapsed5)
                {
                    btnThongKe.Image = Resources.Expand_Arrow_20px;
                    panelThongKe.Height = 57;
                    if (panelThongKe.Size == panelThongKe.MinimumSize)
                    {
                        timerThongKe.Stop();
                        isCollapsed5 = true;
                    }
                }
                if (!isCollapsed4)
                {
                    btnQLOnTap.Image = Resources.Expand_Arrow_20px;
                    panelQLOnTap.Height = 57;
                    if (panelQLOnTap.Size == panelQLOnTap.MinimumSize)
                    {
                        timerQLThiThu.Stop();
                        isCollapsed4 = true;
                    }
                }
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

        private void timerQLDeThi_Tick(object sender, EventArgs e)
        {
            if (isCollapsed2)
            {
                if (!isCollapsed1)
                {
                    btnQuizManager.Image = Resources.Expand_Arrow_20px;
                    panelQLCauHoi.Height = 57;
                    if (panelQLCauHoi.Size == panelQLCauHoi.MinimumSize)
                    {
                        timerQLCauHoi.Stop();
                        isCollapsed1 = true;
                    }
                }

                if (!isCollapsed)
                {
                    btnLamBaiThi.Image = Resources.Expand_Arrow_20px;
                    panelLamBaiThi.Height = 57;
                    if (panelLamBaiThi.Size == panelLamBaiThi.MinimumSize)
                    {
                        timerLamBaiThi.Stop();
                        isCollapsed = true;
                    }
                }

                btnQLDeThi.Image = Resources.Collapse_Arrow_20px;
                panelDeThi.Height += 10;
                if (panelDeThi.Size == panelDeThi.MaximumSize)
                {
                    timerQLDeThi.Stop();
                    isCollapsed2 = false;
                }
            }
            else
            {

                btnQLDeThi.Image = Resources.Expand_Arrow_20px;
                panelDeThi.Height -= 10;
                if (panelDeThi.Size == panelDeThi.MinimumSize)
                {
                    timerQLDeThi.Stop();
                    isCollapsed2 = true;
                }
            }
        }

        private void QLCauHoi_Tick(object sender, EventArgs e)
        {
            if (isCollapsed1)
            {
                if (!isCollapsed2)
                {
                    btnQLDeThi.Image = Resources.Expand_Arrow_20px;
                    panelDeThi.Height = 57;
                    if (panelDeThi.Size == panelDeThi.MinimumSize)
                    {
                        timerQLDeThi.Stop();
                        isCollapsed2 = true;
                    }
                }
                if (!isCollapsed)
                {
                    btnLamBaiThi.Image = Resources.Expand_Arrow_20px;
                    panelLamBaiThi.Height = 57;
                    if (panelLamBaiThi.Size == panelLamBaiThi.MinimumSize)
                    {
                        timerLamBaiThi.Stop();
                        isCollapsed = true;
                    }
                }

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
                if (!isCollapsed1)
                {
                    btnQuizManager.Image = Resources.Expand_Arrow_20px;
                    panelQLCauHoi.Height = 57;
                    if (panelQLCauHoi.Size == panelQLCauHoi.MinimumSize)
                    {
                        timerQLCauHoi.Stop();
                        isCollapsed1 = true;
                    }
                }

                if (!isCollapsed2)
                {
                    btnQLDeThi.Image = Resources.Expand_Arrow_20px;
                    panelDeThi.Height = 57;
                    if (panelDeThi.Size == panelDeThi.MinimumSize)
                    {
                        timerQLDeThi.Stop();
                        isCollapsed2 = true;
                    }
                }

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

        private void QLThiThu_Tick(object sender, EventArgs e)
        {
            if (isCollapsed4)
            {
                if (!isCollapsed5)
                {
                    btnThongKe.Image = Resources.Expand_Arrow_20px;
                    panelThongKe.Height = 57;
                    if (panelThongKe.Size == panelThongKe.MinimumSize)
                    {
                        timerThongKe.Stop();
                        isCollapsed5 = true;
                    }
                }
                if (!isCollapsed3)
                {
                    btnQLKyThi.Image = Resources.Expand_Arrow_20px;
                    panelQLKyThi.Height = 57;
                    if (panelQLKyThi.Size == panelQLKyThi.MinimumSize)
                    {
                        timeQLKyThi.Stop();
                        isCollapsed3 = true;
                    }
                }
                btnQLOnTap.Image = Resources.Collapse_Arrow_20px;
                panelQLOnTap.Height += 10;
                if (panelQLOnTap.Size == panelQLOnTap.MaximumSize)
                {
                    timerQLThiThu.Stop();
                    isCollapsed4 = false;
                }
            }
            else
            {
                btnQLOnTap.Image = Resources.Expand_Arrow_20px;
                panelQLOnTap.Height -= 10;
                if (panelQLOnTap.Size == panelQLOnTap.MinimumSize)
                {
                    timerQLThiThu.Stop();
                    isCollapsed4 = true;
                }
            }
        }

        private void btnQLOnTap_Click(object sender, EventArgs e)
        {
            timerQLThiThu.Start();
        }

        private void ThongKe_Tick(object sender, EventArgs e)
        {
            if (isCollapsed5)
            {
                if (!isCollapsed3)
                {
                    btnQLKyThi.Image = Resources.Expand_Arrow_20px;
                    panelQLKyThi.Height  = 57;
                    if (panelQLKyThi.Size == panelQLKyThi.MinimumSize)
                    {
                        timeQLKyThi.Stop();
                        isCollapsed3 = true;
                    }
                }

                if (!isCollapsed4)
                {
                    btnQLOnTap.Image = Resources.Expand_Arrow_20px;
                    panelQLOnTap.Height = 57;
                    if (panelQLOnTap.Size == panelQLOnTap.MinimumSize)
                    {
                        timerQLThiThu.Stop();
                        isCollapsed4 = true;
                    }
                }
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
