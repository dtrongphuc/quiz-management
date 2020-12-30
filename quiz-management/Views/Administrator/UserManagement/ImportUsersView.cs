using ExcelDataReader;
using quiz_management.Models;
using quiz_management.Presenters.Administrator.UserManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Views.Administrator.UserManagement
{
    public partial class ImportUsersView : Form, IImportUsersView
    {
        private ImportUsersPresenter presenter;

        public List<User> ListUsers { get => dataGridView1.DataSource as List<User>; }

        public event EventHandler Import;

        public ImportUsersView()
        {
            InitializeComponent();
            presenter = new ImportUsersPresenter(this);
            btnImport.Click += (_, e) =>
            {
                Import.Invoke(btnImport, e);
            };
        }

        private DataTableCollection tableCollection;

        private void btnFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx"
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilename.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });

                            tableCollection = result.Tables;
                            cbSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                            {
                                cbSheet.Items.Add(table.TableName);
                            }
                        }
                    }
                }
            }
        }

        private void cbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbSheet.SelectedItem.ToString()];
            if (dt != null)
            {
                List<User> users = new List<User>();
                foreach (DataRow row in dt.Rows)
                {
                    User user = new User
                    {
                        TenTaiKhoan = row["TenTaiKhoan"].ToString(),
                        MatKhau = row["MatKhau"].ToString(),
                        PhanQuyen = row["PhanQuyen"].ToString(),
                        TrangThai = row["TrangThai"].ToString(),
                        TenNguoiDung = row["TenNguoiDung"].ToString(),
                        NgaySinh = Convert.ToDateTime(row["NgaySinh"]),
                        MaLopHoc = int.Parse(row["MaLopHoc"].ToString())
                    };
                    users.Add(user);
                }
                dataGridView1.DataSource = users;
            }
        }
    }
}