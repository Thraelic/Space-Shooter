﻿using System.Drawing;

namespace Game
{
    public class Bullet
    {
        private Point _bulletLocation;
        private byte _bulletImageID;
        private byte _damage;
        private byte _specialProperties;

        public Point BulletLocation { get { return _bulletLocation; } } 

    }
}
