using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity
{
    public static class NhaCC_Data
    {
        public static List<NhaCungCap> Get_NhaCcList()
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.NhaCungCap.ToList();
            }
        }

        public static string Get_IdNhaCc()
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.NhaCungCap.Max(prop => prop.id_NhaCC).Trim();
            }
        }

        public static List<NhaCungCap> Search_NhaCcList(string value)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.NhaCungCap.Where(p => p.id_NhaCC.Contains(value) || p.name_NhaCC.Contains(value)).ToList();
            }
        }

        public static bool Add_NhaCc(NhaCungCap obj)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                entities.NhaCungCap.Add(obj);
                entities.SaveChanges();
                return true;
            }
        }

        public static bool Edit_NhaCc(NhaCungCap obj)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                NhaCungCap nha_CC = entities.NhaCungCap.Find(obj.id_NhaCC);
                nha_CC.name_NhaCC = obj.name_NhaCC;
                nha_CC.phone_NhaCC = obj.phone_NhaCC;
                nha_CC.email_NhaCC = obj.email_NhaCC;
                nha_CC.address_NhaCC = obj.address_NhaCC;

                entities.SaveChanges();
                return true;
            }
        }

        public static bool Delete_NhaCc(string id)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                entities.NhaCungCap.Remove(entities.NhaCungCap.Where(p => p.id_NhaCC == id).FirstOrDefault());
                entities.SaveChanges();
                return true;
            }
        }
    }
}
