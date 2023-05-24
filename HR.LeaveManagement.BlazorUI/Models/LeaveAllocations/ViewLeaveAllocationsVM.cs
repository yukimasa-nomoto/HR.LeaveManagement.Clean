namespace HR.LeaveManagement.BlazorUI.Models.LeaveAllocations
{
    public class ViewLeaveAllocationsVM
    {
        public string EmployeeId { get; set; } = string.Empty;
        public List<LeaveAllocationVM> LeaveAllocations { get; set; } = new List<LeaveAllocationVM>();
    }
}
