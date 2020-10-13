using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity
{
    public static class BaoHanh_Data
    {
        public static List<Bao_Hanh> Get_BaoHanhList()
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.Bao_Hanh.ToList();
            }
        }

        public static List<Bao_Hanh> Search_BaoHanhList(string value)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.Bao_Hanh.Where(p => p.id_BaoHanh.Contains(value) || p.lim_BaoHanh.ToString().Contains(value)).ToList();
            }
        }

        public static string Get_IdBaoHanh()
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.Bao_Hanh.Max(prop => prop.id_BaoHanh).Trim();
            }
        }

        //public static Bao_Hanh Get_IdWithName(string value)
        //{
        //    string[] arr = value.Split('-');
        //    int km = int.Parse(arr[0]);
        //    int time = int.Parse(arr[1]);

        //    using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
        //    {
        //        return entities.Bao_Hanh.Where(prop => prop.km_BaoHanh == km && prop.time_BaoHanh == time).FirstOrDefault();
        //    }
        //}

        public static bool Add_BaoHanh(Bao_Hanh obj)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                entities.Bao_Hanh.Add(obj);
                entities.SaveChanges();
                return true;
            }
        }

        public static bool Edit_BaoHanh(Bao_Hanh obj)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                Bao_Hanh baoHanh = entities.Bao_Hanh.Find(obj.id_BaoHanh);
                baoHanh.lim_BaoHanh = obj.lim_BaoHanh;
                baoHanh.descript = obj.descript;

                entities.SaveChanges();
                return true;
            }
        }

        public static bool Delete_BaoHanh(string id)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                entities.Bao_Hanh.Remove(entities.Bao_Hanh.Where(p => p.id_BaoHanh == id).FirstOrDefault());
                entities.SaveChanges();
                return true;
            }
        }
    }
}
