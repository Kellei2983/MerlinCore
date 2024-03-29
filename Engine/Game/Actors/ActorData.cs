﻿using System;
using System.Collections.Generic;
using System.Text;
using TiledSharp;

namespace Merlin2d.Game.Actors
{
    internal class ActorData
    {
        public string Name { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public string Type { get; private set; }
        internal ActorData(TmxObject tmxObject)
        {
            Name = tmxObject.Name;
            X = (int)tmxObject.X;
            Y = (int)tmxObject.Y;
            if (tmxObject.Properties.ContainsKey("Class"))
            {
                Type = tmxObject.Properties["Class"];
            }
            else if (tmxObject.Properties.ContainsKey("Type"))
            {
                Type = tmxObject.Properties["Type"];
            }
            else
            {
                Type = tmxObject.Type;
            }

        }

        public static implicit operator ActorData(TmxObject tmxObject)
        {
            return new ActorData(tmxObject);
        }
    }
}
