﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel
{
    public class ScrewViewModel : MaterialViewModel, INotifyPropertyChanged
    {
        public string ScrewHead { get; set; }
        public double Length { get; set; }
        public double Diameter { get; set; }



        public ScrewViewModel(Screw screw, int Quantity, string Treatment, string Name) : base(Quantity, Treatment, Name)
        {
            ScrewHead = screw.ScrewHead;
            Length = screw.Length;
            Diameter = screw.Diameter;
            
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}