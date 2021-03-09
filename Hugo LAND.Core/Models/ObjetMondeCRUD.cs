using Hugo_LAND.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.Core.Models
{
    public static class ObjetMondeCRUD
    {
        public static void CreeObjetMonde(ObjetMonde om)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {

                context.Mondes.Find(om.Monde.Id).ObjetMondes.Add(new ObjetMonde
                {
                    x = om.x,
                    y = om.y,
                    Description = om.Description,
                    TypeObjet = om.TypeObjet,
                });

                context.SaveChanges();
            }
        }

        public static void SupprimeObjetMonde(ObjetMonde om)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                context.ObjetMondes.Remove(context.ObjetMondes.Find(om.Id));
                context.SaveChanges();
            }

        }
        public static void ChangeDescriptionObjetMonde(ObjetMonde om)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                ObjetMonde objetMonde = context.ObjetMondes.Where(o => (o.x == om.x && o.y == om.y) && o.Monde == om.Monde)
                                                            .FirstOrDefault();
                objetMonde.Description = om.Description;
                objetMonde.TypeObjet = om.TypeObjet;
                objetMonde.x = om.x;
                objetMonde.y = om.y;

                context.SaveChanges();
            }
        }
    }
}
