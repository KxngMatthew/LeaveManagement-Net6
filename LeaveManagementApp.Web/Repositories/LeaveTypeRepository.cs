using LeaveManagementApp.Web.Contracts;
using LeaveManagementApp.Web.Data;

namespace LeaveManagementApp.Web.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
