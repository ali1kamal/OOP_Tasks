namespace OOP_Tasks;
public class StandardShipment : Shipment
{
    public StandardShipment(string _trackingCode, string _description, decimal _weight, decimal _deliveryFee, DeliveryAddress _destination) :base(_trackingCode, _description, _weight, _deliveryFee, _destination)
    {
        
    }
}
