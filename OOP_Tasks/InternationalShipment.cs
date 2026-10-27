namespace OOP_Tasks;

public class InternationalShipment : Shipment
{
    
    private string destinationCountry;

    public string DestinationCountry
    {
        get { return destinationCountry; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                destinationCountry = value;
        }
    }

    private decimal customsFee;
    public decimal CustomsFee
    {
        get { return customsFee; }
        set
        {
            if (value >= 0)
                customsFee = value;
        }
    }

    public InternationalShipment(string _trackingCode, string _description, decimal _weight, decimal _deliveryFee, DeliveryAddress _destination,string _DestinationCountry, decimal _CustomsFee) : base(_trackingCode, _description, _weight, _deliveryFee, _destination)
    {
        DestinationCountry = _DestinationCountry;
        CustomsFee = _CustomsFee;
    }

    public override decimal EstimatedCost => DeliveryFee + (Weight * 5) + CustomsFee;
}
