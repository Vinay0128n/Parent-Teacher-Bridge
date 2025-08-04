using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParentTeacherBridge.API.Models;

[Table("timetable")]
public partial class Timetable
{
    [Key]
    [Column("timetable_id")]
    public int TimetableId { get; set; }

    [Column("class_id")]
    public int? ClassId { get; set; }

    [Column("subject_id")]
    public int? SubjectId { get; set; }

    [Column("teacher_id")]
    public int? TeacherId { get; set; }

    [Column("weekday")]
    public string? Weekday { get; set; }

    [Column("start_time")]
    public TimeOnly? StartTime { get; set; }

    [Column("end_time")]
    public TimeOnly? EndTime { get; set; }

    [Column("created_at")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey(nameof(ClassId))]
    public virtual SchoolClass? Class { get; set; }

    [ForeignKey(nameof(SubjectId))]
    public virtual Subject? Subject { get; set; }

    [ForeignKey(nameof(TeacherId))]
    public virtual Teacher? Teacher { get; set; }
}
