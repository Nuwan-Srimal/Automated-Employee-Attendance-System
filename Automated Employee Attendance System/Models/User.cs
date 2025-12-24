namespace Automated_Employee_Attendance_System.Models
{
    public class User
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }

        public bool Dashbord { get; set; }
        public bool Employee { get; set; }
        public bool Attendance { get; set; }
        public bool Report { get; set; }
        public bool Settings { get; set; }
       
    }
}
