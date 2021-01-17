using quiz_management.Models;
using quiz_management.Views.Teacher.ExamManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Presenters.Teacher.ExamManagement
{
    internal class ExamListPresenter
    {
        private IExamListView view;
        private BindingList<TestSchedule> lst;
        private int currentcode;

        public ExamListPresenter(IExamListView v, int code)
        {
            view = v;
            currentcode = code;
            Initialize();
        }

        private void Initialize()
        {
            lst = new BindingList<TestSchedule>();
            view.GobackBefore += View_GoBackBefore;
            view.Delete += View_Delete;
            view.AddExam += view_CreateExam;
            view.UpdateExam += View_UpdateExam;
            using (var db = new QuizDataContext())
            {
                var temp = db.lichThis.GroupBy(x => x.maLichThi).Select(xs => new { lt = xs.Select(d => d) }).ToList();
                foreach (var i in temp)
                {
                    var lstlichthi = i.lt.ToList();
                    TestSchedule ts = new TestSchedule();
                    ts.MaLichThi = lstlichthi[0].maLichThi;
                    ts.MaDe = lstlichthi[0].maBoDe;
                    ts.TenMonHoc = lstlichthi[0].monHoc.tenMonHoc;
                    ts.SLThiSinh = db.lichThis.Where(p => p.maLichThi == lstlichthi[0].maLichThi).Count();
                    ts.NgayThi = lstlichthi[0].ngayThi;
                    lst.Add(ts);
                }
                Fill();
            }
        }

        private void View_UpdateExam(object sender, EventArgs e)
        {
            if (view.lichthichon.RowCount == 0)
                return;
            var x = view.lichthichon.SelectedRows[0];
            var id = x.Cells["maLichThi"].Value.ToString();
            bool check = false;
            using (var db = new QuizDataContext())
            {
                var temp = db.ketQuas.Where(p => p.malichthi == int.Parse(id)).ToList();
                if (temp == null || temp.Count == 0)
                    check = true;
            }
            if (check == false)
            {
                view.ShowMessage("Lich thi này đã được thi nên không thể chỉnh sửa");
                return;
            }
            view.ShowUpdateExamView(int.Parse(id), currentcode);
        }

        private void view_CreateExam(object sender, EventArgs e)
        {
            view.ShowCreateExamView(currentcode);
        }

        private void View_Delete(object sender, EventArgs e)
        {
            if (view.lichthichon.RowCount == 0)
                return;

            var x = view.lichthichon.SelectedRows[0];
            var id = x.Cells["maLichThi"].Value.ToString();
            var de = x.Cells["MaDe"].Value.ToString();
            bool check = false;
            using (var db = new QuizDataContext())
            {
                var temp = db.ketQuas.Where(p => p.malichthi == int.Parse(id))
                                    .Where(c => c.maBoDe == int.Parse(de)).ToList();
                if (temp == null || temp.Count == 0)
                    check = true;
            }
            if (check == false)
            {
                view.ShowMessage("Lich thi này đã được thi nên không thể Xóa");
                return;
            }

            using (var db = new QuizDataContext())
            {
                var lt = db.lichThis.Where(p => p.maLichThi == int.Parse(id)).ToList();
                var itemdelete = lst.Where(i => i.MaLichThi == int.Parse(id)).ToList();

                for (int i = 0; i < lt.Count(); i++)
                {
                    db.lichThis.DeleteOnSubmit(lt[i]);
                }
                lst.Remove(itemdelete[0]);
                db.SubmitChanges();
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