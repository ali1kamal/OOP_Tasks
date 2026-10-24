using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tasks
{
    public struct DeliveryCenter
    {
        private Shipment[] shipments;

        public DeliveryCenter() 
        {
            shipments = new Shipment[10];
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
        public void AddShipment(Shipment shipment)
        {
            shipments[0] = shipment;
        }
    }
}
