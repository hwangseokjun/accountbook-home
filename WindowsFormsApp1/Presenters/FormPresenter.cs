using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataAccess;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1.Presenters
{
    public class FormPresenter
    {
        private readonly IView _view;
        private readonly IRepository _repository;

        public FormPresenter(IView view, IRepository repository)
        {
            _view = view;
            _repository = repository;
            _view.OnAddReport += AddReport;
            _view.OnDeleteReport += RemoveReport;
        }

        /// <summary>
        /// 초기화. 콤보박스 값 입력 등.
        /// </summary>
        public void Initialize() 
        {
            ReadAll();
        }

        /// <summary>
        /// 가계부 추가
        /// </summary>
        public void AddReport(Report report) 
        {
            _repository.SaveReport(report);
            var reports = _view.ReportViews;
            var categories = _view.Categories;
            var expenseTypes = _view.ExpenseTypes;
            var stores = _view.Stores;
            reports.Add(new ReportView(report, categories, stores, expenseTypes));
            _view.ReportViews = reports;
        }

        /// <summary>
        /// 가계부 모두 읽기
        /// </summary>
        public void ReadAll() 
        {
            var reports = _repository.GetAllReports();
            var categories = _repository.GetCategories();
            var expenseTypes = _repository.GetExpenseTypes();
            var stores = _repository.GetStores();
            var reportViews = new List<ReportView>();

            foreach (var report in reports)
            {
                reportViews.Add(new ReportView(report, categories, stores, expenseTypes));
            }

            _view.ReportViews = reportViews;
            _view.Categories = categories;
            _view.ExpenseTypes = expenseTypes;
            _view.Stores = stores;
        }

        /// <summary>
        /// 가계부 삭제
        /// </summary>
        /// <param name="id"></param>
        public void RemoveReport(int id) 
        {
            _repository.RemoveReport(id);
            var reports = _view.ReportViews;
            var report = reports.First(x => x.Id == id);
            reports.Remove(report);
            _view.ReportViews = reports;
        }
    }
}
