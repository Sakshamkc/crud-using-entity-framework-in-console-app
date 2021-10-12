using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_using_entity_framework_in_console_app
{
    public class daleydb
    {
        DaleyramEntities _db = new DaleyramEntities();
        public List<daley> GetInfo()
        {
            return _db.daleys.ToList();
        }

        public void CreateStudent(daley da)
        {
            _db.daleys.Add(da);
            _db.SaveChanges();
        }
        public void UpdateStudent(daley da )
        {
            daley db = _db.daleys.Where(a => a.StudentId == da.StudentId).FirstOrDefault();
            db.Firstname = da.Firstname;
            db.Lastname = da.Lastname;
            db.Phone = da.Phone;
            db.Age = da.Age;
            _db.SaveChanges();
        }
        public void DeleteStudent(int studentId)
        {
            daley db = _db.daleys.Where(a => a.StudentId == studentId).FirstOrDefault();
            
            _db.daleys.Remove(db);
            _db.SaveChanges();
        }
    }
}
