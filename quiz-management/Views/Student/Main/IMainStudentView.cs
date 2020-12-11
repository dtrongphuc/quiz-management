using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Student.Main
{
    interface IMainStudentView
    {
       
        string DOBHS { set; }
        string IdHS { set; }
        string NameHS { set; }
        string LopHS { set; }

        event EventHandler EditProfile;
        event EventHandler ContribuQuestion;
        void ShowEditProfileStudentView(int userCode);
        void ShowContribuQuestionsView(int userCode);
    }
}
