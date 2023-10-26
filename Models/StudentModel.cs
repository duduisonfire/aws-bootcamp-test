namespace API;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("student")]
public class Student
{
    [Key]
    public int? Id { get; set; }

    [Required]
    [Column("name")]
    public required string Name { get; set; }

    [Column("age")]
    [Required]
    public required string Age { get; set; }

    [Column("first_grade")]
    [Required]
    public required string FirstGrade { get; set; }

    [Column("second_grade")]
    [Required]
    public required string SecondGrade { get; set; }

    [Column("professor_name")]
    [Required]
    public required string ProfessorName { get; set; }

    [Column("class_number")]
    [Required]
    public required string ClassNumber { get; set; }
}
