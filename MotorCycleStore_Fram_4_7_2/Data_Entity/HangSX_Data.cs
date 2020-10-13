using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity
{
    public static class HangSX_Data
    {
        public static List<Hang_SX> Get_HangSXList()
        {
            using(ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.Hang_SX.ToList();
            }
        }

        public static List<Hang_SX> Search_HangSXList(string value)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.Hang_SX.Where(p => p.id_HangSX.Contains(value) || p.name_HangSX.Contains(value)).ToList();
            }
        }

        public static string Get_IdHangSX()
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.Hang_SX.Max(prop => prop.id_HangSX).Trim();
            }
        }

        public static Hang_SX Get_IdWithName(string value)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.Hang_SX.Where(prop => prop.name_HangSX.Contains(value)).FirstOrDefault();
            }
        }

        public static bool Add_HangSX(Hang_SX obj)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                entities.Hang_SX.Add(obj);
                entities.SaveChanges();
                return true;
            }
        }

        public static bool Edit_HangSX(Hang_SX obj)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                Hang_SX hang_SX = entities.Hang_SX.Find(obj.id_HangSX);
                hang_SX.name_HangSX = obj.name_HangSX;
                hang_SX.descrip_HangSX = obj.descrip_HangSX;

                entities.SaveChanges();
                return true;
            }
        }

        public static bool Delete_HangSX(string id)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                entities.Hang_SX.Remove(entities.Hang_SX.Where(p => p.id_HangSX == id).FirstOrDefault());
                entities.SaveChanges();
                return true;
            }
        }
    }
}
