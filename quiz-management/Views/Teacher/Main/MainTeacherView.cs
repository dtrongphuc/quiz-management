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
        public MainTeacherView()
        {
            InitializeComponent();
        }

        private void QuizManager_Click(object sender, EventArgs e)
        {
            timer2.Start();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed1)
            {
                btnQuizManager.Image = Resources.Collapse_Arrow_20px;
                panelQLCauHoi.Height += 10;
                if (panelQLCauHoi.Size == panelQLCauHoi.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed1 = false;
                }
            }
            else
            {
                btnQuizManager.Image = Resources.Expand_Arrow_20px;
                panelQLCauHoi.Height -= 10;
                if (panelQLCauHoi.Size == panelQLCauHoi.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed1 = true;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsed2)
            {
                btnQLDeThi.Image = Resources.Collapse_Arrow_20px;
                panelDeThi.Height += 10;
                if (panelDeThi.Size == panelDeThi.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed2 = false;
                }
            }
            else
            {
                btnQLDeThi.Image = Resources.Expand_Arrow_20px;
                panelDeThi.Height -= 10;
                if (panelDeThi.Size == panelDeThi.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed2 = true;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        
    }
}
