using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tasks
{
    public class DeliveryCenter
    {
        public string CenterName { get; set; }
        private Shipment[] shipments;

        public DeliveryCenter() 
        {
            shipments = new Shipment[20];
        }

        public Shipment this[int position]
        {
            get
            {
                if(position>=0&&position>shipments.Length&& shipments !=null)
                    return shipments[position];
                return default;
            }
            set
            {
                if (position >= 0 && position < shipments.Length && shipments != null)
                    shipments[position] = value;
            }
        }

        public string this[string code]
        {
            get
            {
                if(shipments!=null)
                for(int i = 0; i < shipments.Length; i++)
                    if (shipments[i].TrackingCode == code)
                        return shipments[i].TrackingCode;

                return default;
            }
        }
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (string.IsNullOrEmpty(shipments[i].TrackingCode))
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
             
            for(int i = 0;i < shipments.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(shipments[i].TrackingCode) && shipments[i].TrackingCode== trackingCode)
                {
                    shipments[i] = default;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            foreach(var shipment in shipments)
                Console.WriteLine(shipment);
        }
    }
}
