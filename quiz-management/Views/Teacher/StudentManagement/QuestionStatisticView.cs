﻿using quiz_management.Models;
using quiz_management.Presenters.Teacher.StudentManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Teacher.StudentManagement
{
    public partial class QuestionStatisticView : Form, IQuestionStatisticView
    {
        private QuestionStatisticPresenter presenter;

        public List<QuestionStatistic> StatisticData { set => dgvQuestionStatistic.DataSource = value; }

        public QuestionStatisticView()
        {
            InitializeComponent();
            presenter = new QuestionStatisticPresenter(this);
        }
    }
}