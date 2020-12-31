﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class TrainScript
    {
        int _sTT;
        string _studentName;
        string _subjectName;
        int _paperID; // mã bộ đề
        DateTime _date;//ngày thi
        float _score;

        public int STT { get => _sTT; set => _sTT = value; }
        public string StudentName { get => _studentName; set => _studentName = value; }
        public string SubjectName { get => _subjectName; set => _subjectName = value; }
        public int PaperID { get => _paperID; set => _paperID = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public float Score { get => _score; set => _score = value; }
    }
}
