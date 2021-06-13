using System.Collections.Generic;

namespace HomeFinance.UI.Model
{
    public class ReportTableModel
    {
        public TotalAmountModel TotalAmount { get; set; }
        public List<OperationModel> Operations { get; set; }
    }
}