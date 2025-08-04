using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ParentTeacherBridge.API.Models;


[Table("school_class")]
public partial class SchoolClass
{
    [Key]
    [Column("class_id")]
    public int ClassId { get; set; }

    [Column("class_name")]
    [Required(ErrorMessage = "Class name is required")]
    public string? ClassName { get; set; }

    [Column("class_teacher_id")]
    public int? ClassTeacherId { get; set; }

    [Column("created_at")]
    public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;


    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;

    [JsonIgnore]
    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    [ForeignKey(nameof(ClassTeacherId))]
    public virtual Teacher? ClassTeacher { get; set; }

    [JsonIgnore]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    [JsonIgnore]
    public virtual ICollection<Timetable> Timetables { get; set; } = new List<Timetable>();
}
