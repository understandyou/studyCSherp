using defaultGenerateDuiBi.Model.Context;

namespace defaultGenerateDuiBi.DAL
{
    public class StudentDAL
    {
        public void GetStudent()
        {
            var db = new DbStudentContext();
            var student = db.Students.Find("1");
            db.Dispose();
            
        }
    }
}