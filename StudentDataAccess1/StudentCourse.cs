//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentDataAccess1
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentCourse
    {
        public int Student_Course_Id { get; set; }
        public int Student_Id { get; set; }
        public int Course_Id { get; set; }
        public int Class_Schedule_Id { get; set; }
        public System.TimeSpan Enrollment_date { get; set; }
        public int Units { get; set; }
    
        public virtual ClassSchedule ClassSchedule { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
