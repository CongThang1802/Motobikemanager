using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity
{
    public static class DanhMuc_Data
    {
        public static List<DanhMuc> Get_DanhMucList()
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.DanhMuc.ToList();
            }
        }

        public static List<DanhMuc> Search_DanhMucList(string value)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.DanhMuc.Where(p => p.id_DanhMuc.Contains(value) || p.name_DanhMuc.Contains(value)).ToList();
            }
        }

        public static DanhMuc Get_DanhMuc(string id)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.DanhMuc.Where(p => p.id_DanhMuc == id).FirstOrDefault();
            }
        }

        public static Get_DanhMucCustom_Result Get_DanhMucItem(string id)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.Get_DanhMucCustom(id).FirstOrDefault();
            }
        }

        public static string Get_IdDanhMuc()
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.DanhMuc.Max(prop => prop.id_DanhMuc).Trim();
            }
        }

        public static bool Add_DanhMuc(DanhMuc obj)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                entities.DanhMuc.Add(obj);
                entities.SaveChanges();
            }
            return true;
        }

        public static bool Edit_DanhMuc(DanhMuc obj)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                DanhMuc danhMuc = entities.DanhMuc.Where(p => p.id_DanhMuc == obj.id_DanhMuc).FirstOrDefault();

                danhMuc.name_DanhMuc = obj.name_DanhMuc;
                danhMuc.breakend_DanhMuc = obj.breakend_DanhMuc;
                danhMuc.breakfont_DanhMuc = obj.breakfont_DanhMuc;
                danhMuc.engine_DanhMuc = obj.engine_DanhMuc;
                danhMuc.size_DanhMuc = obj.size_DanhMuc;
                danhMuc.price_DanhMuc = obj.price_DanhMuc;
                danhMuc.volume_DanhMuc = obj.volume_DanhMuc;
                danhMuc.tire_DanhMuc = obj.tire_DanhMuc;
                danhMuc.torque_DanhMuc = obj.torque_DanhMuc;
                danhMuc.weight_DanhMuc = obj.weight_DanhMuc;
                danhMuc.id_BaoHanh = obj.id_BaoHanh;
                danhMuc.id_HangSX = obj.id_HangSX;
                danhMuc.id_LoaiSP = obj.id_LoaiSP;
                danhMuc.image_DanhMuc = obj.image_DanhMuc;
                entities.SaveChanges();
            }
            return true;
        }

        public static bool Delete_DanhMuc(string id)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                entities.DanhMuc.Remove(entities.DanhMuc.Where(p => p.id_DanhMuc == id).FirstOrDefault());
                entities.SaveChanges();
                return true;
            }
        }
    }
}
