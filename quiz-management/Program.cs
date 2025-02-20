﻿using quiz_management.Presenters.Teacher.ExamManagement;
using quiz_management.Views;
using quiz_management.Views.Administrator.MainAdmin;
using quiz_management.Views.Administrator.UserManagement;
using quiz_management.Views.Student;
using quiz_management.Views.Student.ContribuQuestions;
using quiz_management.Views.Student.Exam;
using quiz_management.Views.Student.InfoPersonal;
using quiz_management.Views.Student.Main;
using quiz_management.Views.Teacher.ExamManagement;
using quiz_management.Views.Teacher.Main;
using quiz_management.Views.Teacher.MockExamManagement;
using quiz_management.Views.Teacher.PaperManagement;
using quiz_management.Views.Teacher.QuestionManagement;
using quiz_management.Views.Teacher.StudentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginView());
        }
    }
}