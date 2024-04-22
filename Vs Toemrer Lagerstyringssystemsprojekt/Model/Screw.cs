﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Model
{
    public class Screw : Material
    {
        public string ScrewHead { get; set; }
        public double Length { get; set; }
        public double Diameter { get; set; }

        public Screw(string ScrewHead, double Length, double Diameter) : base()
        {
            this.ScrewHead = ScrewHead;
            this.Length = Length;
            this.Diameter = Diameter;
            this.Quantity = base.Quantity;
            this.Treatment = base.Treatment;

        }
    }
}
