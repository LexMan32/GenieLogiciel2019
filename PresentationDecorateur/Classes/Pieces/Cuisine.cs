﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationDecorateur.Classes.Pieces
{
    public class Cuisine : AbstractPiece
    {
        public Cuisine()
        {

        }

        public override double getCout()
        {
            return 0;
        }

        public override string getDescription()
        {
            return "Cuisine";
        }
    }
}
