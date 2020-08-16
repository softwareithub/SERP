using SERP.Core.ViewModelEntities.BasicReport;
using System.Threading.Tasks;

namespace SERP.Core.Repository.Report
{
    public interface IAttandenceReportRepository
    {
        Task<AttandenceReportVm> GetStudentAttandenceReportAsync(int year, int month, int studentId);
    }
}
