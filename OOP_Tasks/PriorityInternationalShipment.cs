
namespace OOP_Tasks;

public class PriorityInternationalShipment : InternationalShipment
{
    public PriorityInternationalShipment(string _trackingCode, string _description, decimal _weight, decimal _deliveryFee, DeliveryAddress _destination,string _DestinationCountry, decimal _CustomsFee) : base(_trackingCode, _description, _weight, _deliveryFee, _destination, _DestinationCountry, _CustomsFee)
    {
        
    }
    public override sealed void GenerateCustomsReport()
    {
        Console.WriteLine("Generating PRIORITY Customs Report - Fast Track!");
    }
}
