﻿using quiz_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Views.Teacher.StudentManagement
{
    internal interface IQuestionStatisticView
    {
        List<QuestionStatistic> StatisticData { set; }
    }
}