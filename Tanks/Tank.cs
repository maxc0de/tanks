﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class Tank : GameObject
    {
        public Direction direction;

        private int dY = 1;
        private int dX = 1;
        private Direction nextDirection;

        int i = 0;

        public List<Bullet> bullets { get; set; }

        public Tank(int X, int Y)
        {
            this.X = X;
            this.Y = Y;

            bullets = new List<Bullet>();
        }

        public void Move()
        {
            if (i == 50)
            {
                nextDirection = (Direction)PackmanController.randomNum.Next(0, 4);
                if (nextDirection != direction)
                {
                    direction = nextDirection;
                    Fire();
                }

                i = 0;
            }
            else
            {
                i++;
            }

            Move(direction);
        }
        public void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.Up:
                    Move(0, -dY);
                    break;
                case Direction.Left:
                    Move(-dX, 0);
                    break;
                case Direction.Down:
                    Move(0, dY);
                    break;
                case Direction.Right:
                    Move(dX, 0);
                    break;
            }
        }
        public override GameObjectView GetView()
        {
            return new TankView(direction);
        }
        public void Fire()
        {
            bullets.Add(new Bullet(X + sizeX / 2, Y + sizeY / 2, direction, 3));
        }
    }
}
