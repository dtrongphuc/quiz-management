﻿using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Student.Main
{
    internal interface IMainStudentView
    {
        string DOBHS { set; }
        string IdHS { set; }
        string NameHS { set; }
        string LopHS { set; }

        event EventHandler EditProfile;

        event EventHandler ContribuQuestion;

        event EventHandler OfficialExamClick;

        event EventHandler ResultExamClick;

        event EventHandler TestScheduleClick;

        event EventHandler PracticExamClick;

        event EventHandler PracticStatisticClick;
        event EventHandler LogoutClick;

        void ShowEditProfileStudentView(int userCode);

        void ShowContribuQuestionsView(int userCode);

        void ShowOfficialExamView(int userCode);

        void ShowResultExamView(int userCode);

        void ShowTestScheduleView(int userCode);

        void ShowPracticExamView(int userCode);

        void ShowPracticStatisticView(int userCode);
        void ShowLogin();
    }
}