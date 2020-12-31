﻿using quiz_management.Models;
using quiz_management.Views.Student.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Student.Main
{
    internal class MainStudentPresenter
    {
        private IMainStudentView view;
        private int currentUserCode;

        private thongTin info = null;
        private string lop = null;

        public MainStudentPresenter(IMainStudentView v, int code)
        {
            view = v;
            currentUserCode = code;
            Initialize();
        }

        private void Initialize()
        {
            view.EditProfile += View_EditProfile;
            view.ContribuQuestion += View_ContribuQuestion;
            view.OfficialExamClick += View_OfficialExamClick;
            view.ResultExamClick += View_ResultExamClick;
            view.TestScheduleClick += View_TestScheduleClick;
            view.PracticExamClick += View_PracticExamClick;
            view.PracticStatisticClick += View_PracticStatisticClick;

            using (var user = new QuizDataContext())
            {
                var i = user.nguoiDungs.Join(user.thongTins,
                p => p.maNguoiDung,
                c => c.maNguoidung,
                (p, c) => new { p = p, c = c }).Where(a => a.p.maNguoiDung == currentUserCode)
                .Select(kq => kq.c).ToList();

                if (i.Count > 0)
                {
                    info = i[0];
                    var x = user.thongTins.Join(user.Lops,
                        p => p.maLopHoc,
                        c => c.maLopHoc,
                        (p, c) => new { p = p, c = c }).Where(a => a.p.maLopHoc == info.maLopHoc).Select(kq => kq.c.tenLopHoc);
                    var temp2 = x.ToList();

                    if (temp2.Count > 0) lop = temp2[0];
                }
            }
            FillLH();
        }

        private void View_PracticStatisticClick(object sender, EventArgs e)
        {
            view.ShowPracticStatisticView(currentUserCode);
        }

        private void View_PracticExamClick(object sender, EventArgs e)
        {
            view.ShowPracticExamView(currentUserCode);
        }

        private void View_TestScheduleClick(object sender, EventArgs e)
        {
            view.ShowTestScheduleView(currentUserCode);
        }

        private void View_ResultExamClick(object sender, EventArgs e)
        {
            view.ShowResultExamView(currentUserCode);
        }

        private void View_OfficialExamClick(object sender, EventArgs e)
        {
            view.ShowOfficialExamView(currentUserCode);
        }

        private void FillLH()
        {
            if (info != null)
            {
                view.IdHS = info.maNguoidung.ToString();
                view.NameHS = info.tenNguoiDung;
                view.DOBHS = info.ngaySinh.Value.Day + "/" + info.ngaySinh.Value.Month + "/" + info.ngaySinh.Value.Year;
                view.LopHS = lop;
            }
        }

        private void View_EditProfile(object sender, EventArgs e)
        {
            view.ShowEditProfileStudentView(currentUserCode);
        }

        private void View_ContribuQuestion(object sender, EventArgs e)
        {
            view.ShowContribuQuestionsView(currentUserCode);
        }
    }
}