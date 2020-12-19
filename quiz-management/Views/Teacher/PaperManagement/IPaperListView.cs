using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Teacher.PaperManagement
{
    interface IPaperListView
    {
        string Teachername { set; }
        string PaperID{ get; }
        List<Papers> papers { set; }
        event EventHandler GobackBefore;
        event EventHandler Delete;
        event EventHandler UpdatePaper;

        void ShowCreatePaperView(int code);
        void ShowMessage(string text);
        void ShowUpdatePaperView(int code, int paperid);
    }
}
