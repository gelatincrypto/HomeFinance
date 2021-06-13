using HomeFinance.UI.Model;
using Microsoft.AspNetCore.Components;

namespace HomeFinance.UI.Tables
{
    public partial class ReportTable
    {
        [Parameter]
        public ReportTableModel ReportTableModel { get; set; }
        string _incomeColor = "#8dc1aa";
        string _expenseColor = "#FF4500";
    }
}
