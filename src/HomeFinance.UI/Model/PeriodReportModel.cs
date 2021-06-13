using System;

namespace HomeFinance.UI.Model
{
    public class PeriodReportModel
    {
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public ReportTableModel ReportTable { get; set; }
    }
}