﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// 原始文件名:
// 生成日期: 2019/5/27 22:32:04
namespace 门诊药房
{
    
    /// <summary>
    /// 架构中不存在 userinfoEntities 的注释。
    /// </summary>
    public partial class userinfoEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// 请使用应用程序配置文件的“userinfoEntities”部分中的连接字符串初始化新 userinfoEntities 对象。
        /// </summary>
        public userinfoEntities() : 
                base("name=userinfoEntities", "userinfoEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// 初始化新的 userinfoEntities 对象。
        /// </summary>
        public userinfoEntities(string connectionString) : 
                base(connectionString, "userinfoEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// 初始化新的 userinfoEntities 对象。
        /// </summary>
        public userinfoEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "userinfoEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// 架构中不存在 Tb_userinfo 的注释。
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Data.Objects.ObjectQuery<Tb_userinfo> Tb_userinfo
        {
            get
            {
                if ((this._Tb_userinfo == null))
                {
                    this._Tb_userinfo = base.CreateQuery<Tb_userinfo>("[Tb_userinfo]");
                }
                return this._Tb_userinfo;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Data.Objects.ObjectQuery<Tb_userinfo> _Tb_userinfo;
        /// <summary>
        /// 架构中不存在 Tb_userinfo 的注释。
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public void AddToTb_userinfo(Tb_userinfo tb_userinfo)
        {
            base.AddObject("Tb_userinfo", tb_userinfo);
        }
    }
    /// <summary>
    /// 架构中不存在 userinfoModel.Tb_userinfo 的注释。
    /// </summary>
    /// <KeyProperties>
    /// Userid
    /// Userpassword
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="userinfoModel", Name="Tb_userinfo")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Tb_userinfo : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// 创建新的 Tb_userinfo 对象。
        /// </summary>
        /// <param name="userid">Userid 的初始值。</param>
        /// <param name="userpassword">Userpassword 的初始值。</param>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public static Tb_userinfo CreateTb_userinfo(string userid, string userpassword)
        {
            Tb_userinfo tb_userinfo = new Tb_userinfo();
            tb_userinfo.Userid = userid;
            tb_userinfo.Userpassword = userpassword;
            return tb_userinfo;
        }
        /// <summary>
        /// 架构中不存在属性 Userid 的任何注释。
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string Userid
        {
            get
            {
                return this._Userid;
            }
            set
            {
                this.OnUseridChanging(value);
                this.ReportPropertyChanging("Userid");
                this._Userid = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Userid");
                this.OnUseridChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _Userid;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnUseridChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnUseridChanged();
        /// <summary>
        /// 架构中不存在属性 Userpassword 的任何注释。
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string Userpassword
        {
            get
            {
                return this._Userpassword;
            }
            set
            {
                this.OnUserpasswordChanging(value);
                this.ReportPropertyChanging("Userpassword");
                this._Userpassword = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Userpassword");
                this.OnUserpasswordChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _Userpassword;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnUserpasswordChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnUserpasswordChanged();
    }
}
