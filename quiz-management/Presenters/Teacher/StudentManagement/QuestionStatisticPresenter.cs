using quiz_management.Models;
using quiz_management.Views.Teacher.StudentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Teacher.StudentManagement
{
    internal class QuestionStatisticPresenter
    {
        private IQuestionStatisticView view;
        public List<QuestionStatistic> ListBinding = new List<QuestionStatistic>();

        public QuestionStatisticPresenter(IQuestionStatisticView v)
        {
            view = v;
            CalcData();
        }

        public void CalcData()
        {
            using (var db = new QuizDataContext())
            {
                var ExamCount = db.lichThis.Select(s => s.maBoDe).Count();

                ListBinding.Clear();

                foreach (cauHoi ch in db.cauHois)
                {
                    double Total = db.cTKetQuas.Where(ct =>
                                    (ct.maCauHoi == ch.maCauHoi) && (ch.trangThai == 1)).Count();

                    QuestionStatistic q = new QuestionStatistic
                    {
                        MaCauHoi = ch.maCauHoi,
                        CauHoi = ch.cauHoi1,
                        TiLeRaDe = Math.Round(db.lichThis.Where(l =>
                                        l.boDe.cTBoDes.FirstOrDefault(c =>
                                        c.maCauHoi == ch.maCauHoi).maCauHoi == ch.maCauHoi).Count() * 100 * 1.0 / ExamCount),
                        TiLeChonDung = Math.Round(Total != 0 ? (db.cTKetQuas.Where(ct =>
                                        (ct.maCauHoi == ch.maCauHoi) &&
                                        (ct.maCauTraLoi == ct.dapAn.maCauTraloi) &&
                                        (ct.dapAn.dapAn1 == 1)).Count() * 100 * 1.0 / Total) : 0),
                        TiLeChonSai = Math.Round(Total != 0 ? (db.cTKetQuas.Where(ct =>
                                        (ct.maCauHoi == ch.maCauHoi) &&
                                        (ct.maCauTraLoi == ct.dapAn.maCauTraloi) &&
                                        (ct.dapAn.dapAn1 == 0)).Count() * 100 * 1.0 / Total) : 0),
                    };

                    ListBinding.Add(q);
                }

                view.StatisticData = ListBinding;
            }
        }
    }
}