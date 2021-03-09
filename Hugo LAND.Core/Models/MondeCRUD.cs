﻿using Hugo_LAND.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.Core.Models
{
    public static class MondeCRUD
    {

        //Méthode pour les Mondes
        public static void CreerMonde(Monde monde)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                context.Mondes.Add(monde);
                //context.Mondes.Add(new Monde()
                //{
                //    Description = description,
                //    LimiteX = limX,
                //    LimiteY = limY
                //});
                context.SaveChanges();
            }
        }

        public static Monde RafraichirMonde(Monde monde) {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                Monde mondetemp = context.Mondes.Find(monde.Id);
                monde.Items = mondetemp.Items;
                monde.Monstres = mondetemp.Monstres;
                monde.ObjetMondes = mondetemp.ObjetMondes;
            }
            return monde;
        }
        public static void SupprimeMonde(int id)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                context.Mondes.Remove(context.Mondes.Find(id));
                context.SaveChanges();
            }
        }
        public static void ModifDimensions(int id, int limX, int limY)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                Monde result = context.Mondes.Find(id);
                result.LimiteX = limX;
                result.LimiteY = limY;
                context.SaveChanges();
            }
        }
        public static void ModifDescription(int id, string description)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                Monde result = context.Mondes.Find(id);
                result.Description = description;
                context.SaveChanges();
            }

        }
        public static List<Monde> ListeMonde()
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                return context.Mondes.ToList();
            }
        }

    }
}
