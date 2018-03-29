﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models.SmartDevice
{
    public class DeviceFactory
    {
      

        public SmartDevice getDevice(String type)
        {
            switch (type)
            {
                case "Aircon":
                    return new SmartAircon();
                
            }
        }

    }
}
