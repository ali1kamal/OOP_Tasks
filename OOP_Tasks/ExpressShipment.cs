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
    public ExpressShipment(string TrackingCode) : base(TrackingCode)
    {

    }
    public ExpressShipment(string _trackingCode, string _description, decimal _weight, decimal _deliveryFee, DeliveryAddress _destination,decimal _ExtraFee) : base(_trackingCode, _description, _weight, _deliveryFee, _destination)
    {
        extraFee = _ExtraFee;
    }
    public override decimal EstimatedCost => DeliveryFee + (Weight * 5) + ExtraFee;
}
