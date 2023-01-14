namespace API.Dtos
{
    public class FilteredStudentsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string EmergencyContactName { get; set; }
        public int ClassId { get; set; }
        public int GradeId { get; set; }
        public int EnrollmentsId { get; set; }
        public List<string> AppUserRole { get; set; }
        public int AttendancesId { get; set; }
        public int BillingsId { get; set; }
    }
}
