using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity
{
    public static class LoaiSP_Data
    {
        public static List<Loai_SP> Get_LoaiSpList()
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.Loai_SP.ToList();
            }
        }

        public static List<Loai_SP> Search_LoaiSpList(string value)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.Loai_SP.Where(p => p.id_LoaiSP.Contains(value) || p.name_LoaiSP.Contains(value)).ToList();
            }
        }

        public static string Get_IdLoaiSp()
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.Loai_SP.Max(prop => prop.id_LoaiSP).Trim();
            }
        }

        public static Loai_SP Get_IdWithName(string value)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.Loai_SP.Where(prop => prop.name_LoaiSP.Contains(value)).FirstOrDefault();
            }
        }

        public static bool Add_LoaiSp(Loai_SP obj)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                entities.Loai_SP.Add(obj);
                entities.SaveChanges();
                return true;
            }
        }

        public static bool Edit_LoaiSp(Loai_SP obj)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                Loai_SP hang_SX = entities.Loai_SP.Find(obj.id_LoaiSP);
                hang_SX.name_LoaiSP = obj.name_LoaiSP;
                hang_SX.descrip_LoaiSP = obj.descrip_LoaiSP;

                entities.SaveChanges();
                return true;
            }
        }

        public static bool Delete_LoaiSp(string id)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                entities.Loai_SP.Remove(entities.Loai_SP.Where(p => p.id_LoaiSP == id).FirstOrDefault());
                entities.SaveChanges();
                return true;
            }
        }
    }
}
