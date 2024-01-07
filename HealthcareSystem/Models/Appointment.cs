// Appointment.cs
public class Appointment
{
    public int Id { get; set; }
    public DateTime AppointmentDate { get; set; }

    // Making Reason nullable
    public string? Reason { get; set; }

    // Foreign key for Patient
    public int PatientId { get; set; }

    // Making Patient reference nullable
    public Patient? Patient { get; set; }
}

