﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public class Magnitudes : IMagnitudeComposite
    {
        public List<IMagnitude> magnitudes
        {
            get { return magnitudes; }
            set { magnitudes = value;}
        }

        public void addMagnitude(IMagnitude magnitude)
        {
            magnitudes.Add(magnitude);
        }

        public void removeMagnitude(IMagnitude magnitude)
        {
            magnitudes.Remove(magnitude);
        }

        public ICoordinate returnValues()
        {
            int x = 0; int y = 0;
            foreach(var mag in magnitudes)
            {
                var coordinate = mag.returnValues();
                x += coordinate.coordinateX;
                y += coordinate.coordinateY;
            }
            return new Coordinate(x, y);
        }
    }
}
