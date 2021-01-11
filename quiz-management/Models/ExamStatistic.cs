using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Models
{
    public class ExamStatistic
    {
        private DateTime _examDay;
        private int _total;
        private int _totalStudentAboveAverage;
        private int _totalStudentBelowAverage;
        private int _totalMaxScore;

        public DateTime ExamDay { get => _examDay; set => _examDay = value; }
        public int Total { get => _total; set => _total = value; }
        public int TotalStudentAboveAverage { get => _totalStudentAboveAverage; set => _totalStudentAboveAverage = value; }
        public int TotalStudentBelowAverage { get => _totalStudentBelowAverage; set => _totalStudentBelowAverage = value; }
        public int TotalMaxScore { get => _totalMaxScore; set => _totalMaxScore = value; }
    }
}