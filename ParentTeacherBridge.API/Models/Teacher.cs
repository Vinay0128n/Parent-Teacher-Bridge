using System;
using System.Collections.Generic;

namespace ParentTeacherBridge.API.Models;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Phone { get; set; }

    public string? Gender { get; set; }

    public string? Photo { get; set; }

    public string? Qualification { get; set; }

    public int? ExperienceYears { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Behaviour> Behaviours { get; set; } = new List<Behaviour>();

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual ICollection<Performance> Performances { get; set; } = new List<Performance>();

    public virtual ICollection<SchoolClass> SchoolClasses { get; set; } = new List<SchoolClass>();

    public virtual ICollection<Timetable> Timetables { get; set; } = new List<Timetable>();
}
