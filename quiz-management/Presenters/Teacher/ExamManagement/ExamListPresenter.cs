using quiz_management.Models;
using quiz_management.Views.Teacher.ExamManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Presenters.Teacher.ExamManagement
{
    class ExamListPresenter
    {
        IExamListView view;
        List<TestSchedule> lst;
        int currentcode;
        public ExamListPresenter(IExamListView v, int code)
        {
            view = v;
            currentcode = code;
            Initialize();
        }

        private void Initialize()
        {
            lst = new List<TestSchedule>();
            view.GobackBefore += View_GoBackBefore;
            view.Delete += View_Delete;
            using (var db = new QuizDataContext())
            {
                var temp = db.lichThis.ToList();

                foreach (lichThi i in temp)
                {
                    TestSchedule ts = new TestSchedule();
                    ts.MaLichThi = i.maLichThi;
                    ts.MaDe = i.maBoDe;
                    ts.TenMonHoc = i.monHoc.tenMonHoc;
                    ts.SLThiSinh = db.lichThis.Where(p => p.maLichThi == i.maLichThi).Count();
                    ts.NgayThi = i.ngayThi;
                    lst.Add(ts);
                }

                Fill();
            }
        }

        private void View_Delete(object sender, EventArgs e)
        {
            var x = view.lichthichon.SelectedRows[0];
            var id = x.Cells["maLichThi"].Value.ToString();
            using (var db = new QuizDataContext())
            {
                var lt = db.lichThis.Where(p => p.maLichThi == int.Parse(id)).ToList();
                db.lichThis.DeleteOnSubmit(lt[0]);
                db.SubmitChanges();
                var itemdelete = lst.Where(i => i.MaLichThi == int.Parse(id)).ToList();
                lst.Remove(itemdelete[0]);
            }
            Fill();
        }

        private void View_GoBackBefore(object sender, EventArgs e)
        {
            view.ShowMainTeachView(currentcode);
        }

        private void Fill()
        {
            if (lst.Count != 0)
                view.dtgv = lst;
            else
                view.dtgv = null;
        }
    }
}
