



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusModels;

namespace BLLFactory
{
    public class StudentBLL : BaseBLL<StudentModel>
    {
        public StudentModel getDataByID(string tid)
        {
            return this.Fetch().FirstOrDefault(t => t.ID == tid);

        }


        public StudentModel getDataByStudentID(string tid)
        {
            return this.Fetch().FirstOrDefault(t => t.StudentID == tid);

        }

        public List<StudentModel> getDataByStudentName(string tid)
        {
            return this.Fetch(t => t.StudentName == tid).OrderBy(t => t.StudentID).ToList();

        }

        public List<StudentModel> getDataByClassName(string ClassName)
        {
            return this.Fetch(t => t.ClassName == ClassName).OrderBy(t => t.StudentID).ToList();

        }


        public List<StudentModel> getDataByAll()
        {
            return this.Fetch().OrderBy(t => t.StudentID).ToList();


        }
    }
}
