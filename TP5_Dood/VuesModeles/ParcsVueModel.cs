﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5_Dood.VuesModeles;
using TP5_Dood.Modeles;

namespace TP5_Dood.VuesModeles
{
    class ParcsVueModel : VueModeleBase, IDisposable
    {
        private BdEntities context;

        public ParcsVueModel()
        {
            context = new BdEntities();
        }

        ~ParcsVueModel()
        {
            Dispose();
        }

        public List<Parc> Parcs
        {
            get
            {
                return context.Parcs.ToList();
            }
        }

        private Parc parcActuel;

        public Parc ParcActuel
        {
            get
            {
                return parcActuel;
            }
            set
            {
                if (parcActuel != value)
                {
                    parcActuel = value;
                    NotifierProprieteAChangee();
                }
            }
        }

        private Reservoir reservoirActuel;

        public Reservoir ReservoirActuel
        {
            get { return reservoirActuel; }
            set
            {
                if (reservoirActuel != value)
                {
                    reservoirActuel = value;

                    NomReservoirActuel = reservoirActuel.Nom;
                    TypeHuileReservoirActuel = reservoirActuel.Type_Huile;
                    Seuil1ReservoirActuel = reservoirActuel.Seuil1;
                    Seuil2ReservoirActuel = reservoirActuel.Seuil2;
                    Seuil3ReservoirActuel = reservoirActuel.Seuil3;
                }
            }
        }

        private string nomReservoirActuel;
        public string NomReservoirActuel
        {
            get { return nomReservoirActuel; }
            set
            {
                if (nomReservoirActuel != value)
                {
                    nomReservoirActuel = value;
                    NotifierProprieteAChangee();
                }
            }
        }

        private string typeHuileReservoirActuel;
        public string TypeHuileReservoirActuel
        {
            get { return typeHuileReservoirActuel; }
            set
            {
                if (typeHuileReservoirActuel != value)
                {
                    typeHuileReservoirActuel = value;
                    NotifierProprieteAChangee();
                }
            }
        }

        private double seuil1ReservoirActuel;
        public double Seuil1ReservoirActuel
        {
            get { return seuil1ReservoirActuel; }
            set
            {
                if (seuil1ReservoirActuel != value)
                {
                    seuil1ReservoirActuel = value;
                    NotifierProprieteAChangee();
                }
            }
        }

        private double seuil2ReservoirActuel;
        public double Seuil2ReservoirActuel
        {
            get { return seuil2ReservoirActuel; }
            set
            {
                if (seuil2ReservoirActuel != value)
                {
                    seuil2ReservoirActuel = value;
                    NotifierProprieteAChangee();
                }
            }
        }

        private double seuil3ReservoirActuel;
        public double Seuil3ReservoirActuel
        {
            get { return seuil3ReservoirActuel; }
            set
            {
                if (seuil3ReservoirActuel != value)
                {
                    seuil3ReservoirActuel = value;
                    NotifierProprieteAChangee();
                }
            }
        }

        public void Dispose()
        {
            context?.Dispose();
        }
    }
}
