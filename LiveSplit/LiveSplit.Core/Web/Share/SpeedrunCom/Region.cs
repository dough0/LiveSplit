﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiveSplit.Web.Share.SpeedrunCom
{
    public class Region
    {
        public int ID { get; private set; }
        public string Name { get; private set; }

        public static Region Parse(SpeedrunComClient client, dynamic regionElement)
        {
            throw new NotImplementedException();
        }
    }
}
