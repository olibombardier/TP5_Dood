using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5_Dood.VuesModeles;
using TP5_Dood.Modeles;
using System.Windows.Input;

namespace TP5_Dood.VuesModeles
{
    public class ParcsVueModel : VueModeleBase, IDisposable
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
                    if (nomReservoirActuel.Length > 255)
                    {
                        nomReservoirActuel = nomReservoirActuel.Substring(0, 255);
                    }

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
                    if (typeHuileReservoirActuel.Length > 255)
                    {
                        nomReservoirActuel = nomReservoirActuel.Substring(0, 255);
                    }

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
                    seuil1ReservoirActuel = Math.Max(0, Math.Min(1, value));
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
                    seuil2ReservoirActuel = Math.Max(0, Math.Min(1, value));
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
                    seuil3ReservoirActuel = Math.Max(0, Math.Min(1, value));
                    NotifierProprieteAChangee();
                }
            }
        }

        private ICommand _sauvegarderReservoir;
        public ICommand SauvegarderReservoir
        {
            get
            {
                if (_sauvegarderReservoir == null)
                {
                    _sauvegarderReservoir = new CommandeRelais<object>(

                        (obj) =>
                        {
                            using (var entities = new BdEntities())
                            {
                                if(reservoirActuel != null)
                                {
                                    string ancienNom = NomReservoirActuel;
                                    reservoirActuel.Nom = NomReservoirActuel;
                                    reservoirActuel.Type_Huile = TypeHuileReservoirActuel;
                                    reservoirActuel.Seuil1 = Seuil1ReservoirActuel;
                                    reservoirActuel.Seuil2 = Seuil2ReservoirActuel;
                                    reservoirActuel.Seuil3 = Seuil3ReservoirActuel;
                                    entities.SaveChanges();
                                }
                            }
                        }
                    );
                }

                return _sauvegarderReservoir;
            }
        }

        private ICommand _annuler;
        public ICommand Annuler
        {
            get
            {
                if (_annuler == null)
                {
                    _annuler = new CommandeRelais<object>(

                        (obj) =>
                        {
                            using (var entities = new BdEntities())
                            {
                                NomReservoirActuel = reservoirActuel.Nom;
                                TypeHuileReservoirActuel = reservoirActuel.Type_Huile;
                                Seuil1ReservoirActuel = reservoirActuel.Seuil1;
                                Seuil2ReservoirActuel = reservoirActuel.Seuil2;
                                Seuil3ReservoirActuel = reservoirActuel.Seuil3;
                            }
                        }
                    );
                }

                return _annuler;
            }
        }

        public void Dispose()
        {
            context?.Dispose();
        }
    }
}
