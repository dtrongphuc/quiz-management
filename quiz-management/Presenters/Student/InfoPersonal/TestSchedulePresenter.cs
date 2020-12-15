using quiz_management.Models;
using quiz_management.Views.Student.InfoPersonal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Student.InfoPersonal
{
    class TestSchedulePresenter
    {
        ITestScheduleView view;
        int currentcode;
        List<TestSchedule> lst;
        public TestSchedulePresenter(ITestScheduleView v, int code)
        {
            view = v;
            currentcode = code;
            Initialize();
        }

        private void Initialize()
        {
            view.BackMain += View_BackMain;
            lst = new List<TestSchedule>();
            DateTime dt;
            using (var db = new QuizDataContext())
            {
                var linq = db.lichThis.Where(p => p.maNguoiDung == currentcode).ToList();
                
                foreach(lichThi lt in linq)
                {
                    dt = lt.ngayThi;
                    TestSchedule ts = new TestSchedule();
                    ts.TenMonHoc = lt.monHoc.tenMonHoc;
                    ts.NgayThi = dt.Day + "/" + dt.Month + "/" + dt.Year;
                    lst.Add(ts);
                }
            }
            Fill();

        }

        private void Fill()
        {
            view.TestSchedule = lst;
        }

        private void View_BackMain(object sender, EventArgs e)
        {
            view.swichMainStudent(currentcode);
        }
    }
}
