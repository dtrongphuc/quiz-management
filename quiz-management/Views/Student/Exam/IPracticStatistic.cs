using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Student.Exam
{
    internal interface IPracticStatistic
    {
        BindingSource bs { set; }
        ReportDataSource rd { set; }
    }
}