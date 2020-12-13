using quiz_management.Views.Student.InfoPersonal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Student.InfoPersonal
{
    class ProfilePresenter
    {
        IProfileView view;
        int currentUserCode;

        public ProfilePresenter(IProfileView v, int code)
        {
            view = v;
            currentUserCode = code;
        }
    }
}
