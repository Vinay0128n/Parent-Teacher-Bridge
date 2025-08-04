using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ParentTeacherBridge.API.Models;

[Table("subject")]
public partial class Subject
{
    [Key]
    [Column("subject_id")]
    public int SubjectId { get; set; }

    [Required]
    [Column("name")]
    public string? Name { get; set; }

    [Column("code")]
    public string? Code { get; set; }

    [Column("created_at")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [JsonIgnore]
    public virtual ICollection<Performance> Performances { get; set; } = new List<Performance>();

    [JsonIgnore]
    public virtual ICollection<Timetable> Timetables { get; set; } = new List<Timetable>();
}
