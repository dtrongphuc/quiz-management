using quiz_management.Models;
using quiz_management.Views.Administrator.SystemManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_management.Presenters.Administrator.SystemManagement
{
    class DecentralizationPresenter
    {
        BindingList<Authorization> lstinfo;
        List<string> phanquyen;
        DecentralizationView view;
        public DecentralizationPresenter(DecentralizationView v)
        {
            view = v;
            Initialize();

        }

        private void Initialize()
        {
            phanquyen = new List<string>();
            using (var db = new QuizDataContext())
            {
                var temp = db.thongTins.ToList();
                foreach(var x in temp)
                {
                    phanquyen.Add(x.nguoiDung.phanQuyen.ToString());
                }
                /*for(int i =0;i<temp.Count;i++)
                {
                    
                }*/
            }
            Fill();
        }

        private void Fill()
        {
            view.phanquyen = phanquyen;
        }
    }
}
