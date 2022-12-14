using LeaveManagementApp.Web.Data;

namespace LeaveManagementApp.Web.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
       Task LeaveAllocation (int leaveTypeId);
       Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);
    }
}
