using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity
{
    public static class LoaiTK_Data
    {
        public static List<Loai_TK> Get_LoaiTkList()
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.Loai_TK.ToList();
            }
        }

        public static List<Loai_TK> Search_LoaiTkList(string value)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.Loai_TK.Where(p => p.id_LoaiTK.Contains(value) || p.name_LoaiTK.Contains(value)).ToList();
            }
        }

        public static string Get_IdLoaiTk()
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.Loai_TK.Max(prop => prop.id_LoaiTK).Trim();
            }
        }

        public static Loai_SP Get_IdWithName(string value)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.Loai_SP.Where(prop => prop.name_LoaiSP.Contains(value)).FirstOrDefault();
            }
        }

        public static bool Add_LoaiTK(Loai_TK obj)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                entities.Loai_TK.Add(obj);
                entities.SaveChanges();
                return true;
            }
        }

        public static bool Edit_LoaiTK(Loai_TK obj)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                Loai_TK hang_SX = entities.Loai_TK.Find(obj.id_LoaiTK);
                hang_SX.name_LoaiTK = obj.name_LoaiTK;
                hang_SX.descrip_LoaiTK = obj.descrip_LoaiTK;

                entities.SaveChanges();
                return true;
            }
        }

        public static bool Delete_LoaiTK(string id)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                entities.Loai_TK.Remove(entities.Loai_TK.Where(p => p.id_LoaiTK == id).FirstOrDefault());
                entities.SaveChanges();
                return true;
            }
        }
    }
}
