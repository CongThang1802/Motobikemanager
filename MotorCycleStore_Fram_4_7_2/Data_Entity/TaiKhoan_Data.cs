using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity
{
    public static class TaiKhoan_Data
    {
        public static List<TT_TaiKhoan> Get_TtTaiKhoanList()
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.TT_TaiKhoan.ToList();
            }
        }

        public static List<TT_TaiKhoan> Search_TtTaiKhoanList(string value)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.TT_TaiKhoan.Where(p => p.user_Acc.Contains(value) || p.name_User.Contains(value)).ToList();
            }
        }

        public static List<Loai_TK> Get_LoaiTkList()
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.Loai_TK.ToList();
            }
        }

        public static Get_TaiKhoan_Result Get_TaiKhoan(string value)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                return entities.Get_TaiKhoan(value).FirstOrDefault();
            }
        }

        public static bool Add_TaiKhoan(TaiKhoan taiKhoan, TT_TaiKhoan tT_TaiKhoan)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                entities.TaiKhoan.Add(taiKhoan);
                entities.TT_TaiKhoan.Add(tT_TaiKhoan);
                entities.SaveChanges();
                return true;
            }
        }
        public static bool Edit_TaiKhoan(TaiKhoan taiKhoan, TT_TaiKhoan tT_TaiKhoan)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                TaiKhoan taiKhoan_Tmp = entities.TaiKhoan.Where(p => p.user_Acc == taiKhoan.user_Acc).FirstOrDefault();
                taiKhoan_Tmp.status = taiKhoan.status;
                taiKhoan_Tmp.id_LoaiTK = taiKhoan.id_LoaiTK;
                TT_TaiKhoan tT_TaiKhoan_Tmp = entities.TT_TaiKhoan.Where(p => p.user_Acc == taiKhoan.user_Acc).FirstOrDefault();
                tT_TaiKhoan_Tmp.name_User = tT_TaiKhoan.name_User;
                tT_TaiKhoan_Tmp.phone_User = tT_TaiKhoan.phone_User;
                tT_TaiKhoan_Tmp.email_User = tT_TaiKhoan.email_User;
                tT_TaiKhoan_Tmp.address_User = tT_TaiKhoan.address_User;

                entities.SaveChanges();
                return true;
            }
        }

        public static bool Delete_TaiKhoan(string value)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                entities.TaiKhoan.Remove(entities.TaiKhoan.Where(p => p.user_Acc == value).FirstOrDefault());
                entities.TT_TaiKhoan.Remove(entities.TT_TaiKhoan.Where(p => p.user_Acc == value).FirstOrDefault());
                entities.SaveChanges();
                return true;
            }
        }

        public static bool Update_TaiKhoanPass(string userName, string pass)
        {
            using (ThanhHa_MotorCycleEntities entities = new ThanhHa_MotorCycleEntities())
            {
                TaiKhoan taiKhoan = entities.TaiKhoan.Where(p => p.user_Acc == userName).FirstOrDefault();
                taiKhoan.pass_Acc = pass;
                entities.SaveChanges();
                return true;
            }
        }
    }
}
