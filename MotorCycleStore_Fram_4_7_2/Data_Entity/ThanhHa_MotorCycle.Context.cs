﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ThanhHa_MotorCycleEntities : DbContext
    {
        public ThanhHa_MotorCycleEntities()
            : base("name=ThanhHa_MotorCycleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Hang_SX> Hang_SX { get; set; }
        public virtual DbSet<Loai_SP> Loai_SP { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCap { get; set; }
        public virtual DbSet<DanhMuc> DanhMuc { get; set; }
        public virtual DbSet<Loai_TK> Loai_TK { get; set; }
        public virtual DbSet<Bao_Hanh> Bao_Hanh { get; set; }
        public virtual DbSet<CT_HoaDon> CT_HoaDon { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<TT_TaiKhoan> TT_TaiKhoan { get; set; }
    
        public virtual ObjectResult<Get_DanhMucCustom_Result> Get_DanhMucCustom(string iD)
        {
            var iDParameter = iD != null ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_DanhMucCustom_Result>("Get_DanhMucCustom", iDParameter);
        }
    
        public virtual ObjectResult<Get_TaiKhoan_Result> Get_TaiKhoan(string value)
        {
            var valueParameter = value != null ?
                new ObjectParameter("value", value) :
                new ObjectParameter("value", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_TaiKhoan_Result>("Get_TaiKhoan", valueParameter);
        }
    }
}