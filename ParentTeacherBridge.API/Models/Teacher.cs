using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ParentTeacherBridge.API.Models;

[Table("teacher")]
public partial class Teacher
{
    [Key]
    [Column("teacher_id")]
    public int TeacherId { get; set; }

    [Column("name")]
    [Required(ErrorMessage = "Name is required")]
    public string? Name { get; set; }


    [Column("email")]
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string? Email { get; set; }

    [Column("password")]
    public string? Password { get; set; }

    [Column("phone")]
    [StringLength(10, ErrorMessage = "Phone number cannot exceed 20 characters")]
    public string? Phone { get; set; }

    [Column("gender")]
    public string? Gender { get; set; }

    [Column("photo")]
    public string? Photo { get; set; }

    [Column("qualification")]
    public string? Qualification { get; set; }

    [Column("experience_years")]
    [Range(0, 50, ErrorMessage = "Experience years must be between 0 and 50")]
    public int? ExperienceYears { get; set; }

    [Column("is_active")]
    public bool? IsActive { get; set; } = true;

    [Column("created_at")]
    public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;

    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;

    [JsonIgnore]
    public virtual ICollection<Behaviour> Behaviours { get; set; } = new List<Behaviour>();

    [JsonIgnore]
    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    [JsonIgnore]
    public virtual ICollection<Performance> Performances { get; set; } = new List<Performance>();

    [JsonIgnore]
    public virtual ICollection<SchoolClass> SchoolClasses { get; set; } = new List<SchoolClass>();

    [JsonIgnore]
    public virtual ICollection<Timetable> Timetables { get; set; } = new List<Timetable>();
}
