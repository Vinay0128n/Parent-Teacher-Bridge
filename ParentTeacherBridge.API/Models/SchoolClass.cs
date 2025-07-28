using System;
using System.Collections.Generic;

namespace ParentTeacherBridge.API.Models;

public partial class SchoolClass
{
    public int ClassId { get; set; }

    public string? ClassName { get; set; }

    public int? ClassTeacherId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual Teacher? ClassTeacher { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<Timetable> Timetables { get; set; } = new List<Timetable>();
}
