using System.ComponentModel.DataAnnotations;

public class Student
{
    public Guid Id { get; set; }
    [Required, StringLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [Required, StringLength(50)]
    public string LastName { get; set; } = string.Empty;

    [Range(18, 100)]
    public int Age { get; set; }

    [EmailAddress]
    public string Email { get; set; }

    public DateTime Enrollment {  get; set; }

    public bool IsActive { get; set; } = true;

}



