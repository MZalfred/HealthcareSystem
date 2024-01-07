// Billing.cs
public class Billing
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime BillingDate { get; set; }
    public int PatientId { get; set; }

    // Making Patient nullable
    public Patient? Patient { get; set; }
}
