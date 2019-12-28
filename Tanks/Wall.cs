﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    public class Wall : GameObject
    {
        public Wall(int X, int Y, int sizeX, int sizeY)
        {
            this.X = X;
            this.Y = Y;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
        }
        public override GameObjectView GetView()
        {
            return new WallView(sizeX, sizeY);
        }
    }
}
