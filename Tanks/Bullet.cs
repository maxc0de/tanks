﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks.Properties;

namespace Tanks
{
    class Bullet : GameObject
    {
        private int dY;
        private int dX;

        public Direction direction;
        public int speed;
        public Bullet(int X, int Y, Direction dir, int speed)
        {
            this.X = X;
            this.Y = Y;
            this.dX = speed;
            this.dY = speed;
            this.sizeX = 10;
            this.sizeY = 10;
            Move(dir);
        }
        public bool Move(Direction dir)
        {
            direction = dir;
            switch (dir)
            {
                case Direction.Up:
                    return Move(0, -dY);

                case Direction.Left:
                    return Move(-dX, 0);

                case Direction.Down:
                    return Move(0, dY);

                case Direction.Right:
                    return Move(dX, 0);

            }
            return false;
        }
        public override GameObjectView GetView()
        {
            return new BulletView();
        }
        //public override GameObjectView GetTankView()
        //{
        //    return new TankBulletView();
        //}
    }

    class BulletView : GameObjectView
    {
        Bitmap bmp = new Bitmap(Resources.kolobok_bullet);

        public override Bitmap GetBitmap()
        {
            return bmp;
        }
    }

    class TankBulletView : GameObjectView
    {
        Bitmap bmp = new Bitmap(Resources.tank_bullet);

        public override Bitmap GetBitmap()
        {
            return bmp;
        }
    }
}
