namespace OOP_Tasks;

public class ExpressShipment : Shipment
{
    decimal extraFee;
    public decimal ExtraFee
    {
        get
        {
            return extraFee;
        }
        set
        {
            if (value >= 0)
                extraFee = value;

        }
    }
    public override decimal EstimatedCost => base.EstimatedCost + ExtraFee;
    public ExpressShipment(string TrackingCode) : base(TrackingCode)
    {

    }
    public ExpressShipment(string _trackingCode, string _description, decimal _weight, decimal _deliveryFee, DeliveryAddress _destination,decimal _ExtraFee) : base(_trackingCode, _description, _weight, _deliveryFee, _destination)
    {
        extraFee = _ExtraFee;
    }
    
    public override void PrintShipment()
    {
        base.PrintShipment();
        Console.WriteLine($"Extra Fee: {extraFee} EGP");
        
    }
}
