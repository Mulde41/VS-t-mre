﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel
{
    public class ScrewViewModel : IMaterial
    {
        public string ScrewHead { get; set; }
        public double Length { get; set; }
        public double Diameter { get; set; }
        public int Quantity { get; set; }
        public string Treatment { get; set; }
        public string Name { get => $"{ScrewHead} {Length}x{Diameter}mm {Treatment}"; }

        public ScrewViewModel(Screw screw)
        {
            this.ScrewHead = screw.ScrewHead;
            this.Length = screw.Length;
            this.Diameter = screw.Diameter;
            this.Quantity = screw.Quantity;
            this.Treatment = screw.Treatment;
        }
    }
}
