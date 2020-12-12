﻿using quiz_management.Views.Student.InfoPersonal;
using quiz_management.Views.Student.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Student.InfoPersonal
{
    class ProfilePersonalPresenter
    {
        IInfoPersonalView view;
        int currentUserCode;

        ProfilePersonalPresenter(InfoPersonalView v, int code)
        {
            view = v;
            currentUserCode = code;
            Initialize();
        }

        private void Initialize()
        {
           
        }
    }
}
