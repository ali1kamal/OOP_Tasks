namespace OOP_Tasks;
public class Shipment
{
    private string trackingCode;
    private string description;
    private decimal weight;
    private decimal deliveryFee;
    public DeliveryAddress Destination { get; set; }
    public virtual decimal EstimatedCost => DeliveryFee + (decimal)(Weight * 5);

    public Shipment(string TrackingCode) : this(TrackingCode, "Unknown", 1, 50, default)
    {
      
    }
    public Shipment(string _trackingCode, string _description, decimal _weight, decimal _deliveryFee, DeliveryAddress _destination)
    {
        trackingCode = !string.IsNullOrWhiteSpace(_trackingCode) ? _trackingCode : "UNKNOWN";
        description = !string.IsNullOrWhiteSpace(_description) ? _description : "Unknown";
        weight = _weight > 0 ? _weight : 1;
        deliveryFee = _deliveryFee > 0 ? _deliveryFee : 50;
        Destination = _destination;
    }
    public decimal DeliveryFee
    {
        get {  return deliveryFee; }
       private set { if(value > 0) deliveryFee = value; }
    }
    public string TrackingCode
    {
        get { return trackingCode; }
        private set { if(!string.IsNullOrWhiteSpace(value)) trackingCode = value; }
    }
    public string Description
    {
        get { return description; }
        set { if (!string.IsNullOrWhiteSpace(value)) description = value; }
    }

    public decimal Weight
    {
        get { return weight; }
        set { if(value > 0) weight = value; }
    }


    public void UpdateDeliveryFee(decimal newFee)
    {
        if(newFee>0)
            deliveryFee = newFee;
    }
    public void PrintShipment()
    {
        Console.WriteLine($"Tracking Code: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight} KG");
        Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
        Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
    }
}
