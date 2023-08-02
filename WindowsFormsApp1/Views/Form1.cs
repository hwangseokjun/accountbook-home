using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccess;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class Form1 : Form, IView
    {
        private DateTimePicker _dtp = new DateTimePicker();
        private Rectangle _rect;
        private List<ReportView> _reportViews;
        private List<Category> _categories;
        private List<Store> _stores;
        private List<ExpenseType> _expenseTypes;
        public event Action<int> OnDeleteReport;
        public event Action<Report> OnAddReport;
        public event Action OnReadAll;

        public List<Category> Categories 
        {
            get => _categories;
            set
            {
                _categories = value;
                cbx_category.DataSource = _categories;
                cbx_category.DisplayMember = "Name";
                dgv_category.DataSource = _categories;
            }
        }
        public List<Store> Stores 
        {
            get => _stores;
            set
            {
                _stores = value;
                cbx_store.DataSource = _stores;
                cbx_store.DisplayMember = "Name";
                dgv_store.DataSource = _stores;
            }
        }
        public List<ExpenseType> ExpenseTypes 
        {
            get => _expenseTypes;
            set
            {
                _expenseTypes = value;
                cbx_expenseType.DataSource = _expenseTypes;
                cbx_expenseType.DisplayMember = "Name";
                dgv_expenseType.DataSource = _expenseTypes;
            }
        }
        public List<ReportView> ReportViews 
        { 
            get => _reportViews;
            set 
            {
                _reportViews = value;
                dgv_report.DataSource = null;
                dgv_report.DataSource = _reportViews;
            }
        }

        public int TotalIncome 
        {
            set => lbl_incomeAmount.Text = value.ToString();
        }
        public int TotalExpense 
        {
            set => lbl_expenseAmount.Text = value.ToString();
        }
        public int TotalRemains 
        {
            set => lbl_remainAmount.Text = value.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            _dtp.Visible = false;
            _dtp.Format = DateTimePickerFormat.Custom;
            _dtp.TextChanged += new EventHandler(dtp_TextChanged);
            dgv_report.Controls.Add(_dtp);
        }

        private void dtp_TextChanged(object sender, EventArgs e)
        {
            dgv_report.CurrentCell.Value = _dtp.Text.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            OnDeleteReport?.Invoke(1);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int? income = txt_income.Text is null ? null : (int?)int.Parse(txt_income.Text);
            int? expense = txt_expense.Text is null ? null : (int?)int.Parse(txt_expense.Text);

            var report = new Report
            {
                Date = dtp_input.Value.ToString("yyyy-MM-dd"),
                CategoryId = ((Category)cbx_category.SelectedItem).Id,
                Description = txt_description.Text,
                IncomeAmount = income,
                ExpenseAmount = expense,
                StoreId = ((Store)cbx_store.SelectedItem).Id,
                ExpenseTypeId = ((ExpenseType)cbx_expenseType.SelectedItem).Id
            };
            OnAddReport?.Invoke(report);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void dgv_report_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _rect = dgv_report.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            var size = new Size(_rect.Width, _rect.Height);
            var point = new Point(_rect.X, _rect.Y);
            
            if (e.ColumnIndex == 0)
            {
                _dtp.Size = size;
                _dtp.Location = point;
                _dtp.Visible = true;
            }
            else if (e.ColumnIndex == 1) 
            {
                
            }
        }
    }
}
