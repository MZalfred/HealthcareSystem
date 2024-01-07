// Appointment.cs
public class Appointment
{
    public int Id { get; set; }
    public DateTime AppointmentDate { get; set; }
    public string Reason { get; set; }
    // Foreign key for Patient
    public int PatientId { get; set; }
    public Patient Patient { get; set; }
}