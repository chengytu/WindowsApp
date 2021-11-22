using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class StudentModel : BaseModel
    {
        /// <summary>
        /// 课程表
        /// </summary>
        public StudentModel()
        {
            ID = Guid.NewGuid().ToString("N");
            StudentID = "";
            StudentName = "";
            ClassName = "";
            Gender = "";

        }


        /// <summary>
        /// 名称
        /// </summary>
        [DisplayName("学号")]
        public string StudentID { get; set; }



        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("学生姓名")]
        public string StudentName { get; set; }



        [DisplayName("班级")]
        public string ClassName { get; set; }

        [DisplayName("性别")]
        public string Gender { get; set; }
       



    }
}


