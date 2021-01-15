﻿using quiz_management.Models;
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
    class ExamListPresenter
    {
        IExamListView view;
        BindingList<TestSchedule> lst;
        BindingSource lstbinding;
        int currentcode;
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
                var temp = db.lichThis.GroupBy(x => x.maLichThi).Select(xs => new { lt = xs.Select(d => d)}).ToList();
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
            if (view.dtgv.RowCount == 0)
                return;
            var x = view.dtgv.SelectedRows[0];
            var id = x.Cells["maLichThi"].Value.ToString();
            view.ShowUpdateExamView(int.Parse(id),currentcode);

        }

        private void view_CreateExam(object sender, EventArgs e)
        {
            view.ShowCreateExamView(currentcode);
        }

        private void View_Delete(object sender, EventArgs e)
        {
            if (view.dtgv.RowCount == 0)
                return;
            var x = view.dtgv.SelectedRows[0];
            var id = x.Cells["maLichThi"].Value.ToString();
            using (var db = new QuizDataContext())
            {
                var lt = db.lichThis.Where(p => p.maLichThi == int.Parse(id)).ToList();
                var itemdelete = lst.Where(i => i.MaLichThi == int.Parse(id)).ToList();

                for (int i=0;i<lt.Count();i++)
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
            lstbinding = new BindingSource();
            lstbinding.DataSource = lst;
            view.dtgv.DataSource = lstbinding;
        }
    }
}
