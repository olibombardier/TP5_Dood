using System;
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

        public void Dispose()
        {
            context?.Dispose();
        }
    }
}
