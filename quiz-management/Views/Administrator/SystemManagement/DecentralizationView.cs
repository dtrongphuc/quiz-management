using quiz_management.Presenters.Administrator.SystemManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Administrator.SystemManagement
{
    public partial class DecentralizationView : Form,IDecentralization
    {
        DecentralizationPresenter presenter;
        public DecentralizationView()
        {
            InitializeComponent();
            presenter = new DecentralizationPresenter(this);
        }

        public List<string> phanquyen { set => quyen.DataSource = value; }
        

}
}
