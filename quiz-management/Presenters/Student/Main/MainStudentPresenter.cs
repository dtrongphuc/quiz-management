using quiz_management.Views.Student.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Student.Main
{
    class MainStudentPresenter
    {
        IMainStudentView view;
        string currentUserCode;

        public MainStudentPresenter(IMainStudentView v, string code)
        {
            view = v;
            currentUserCode = code; 
        }
    }
}
