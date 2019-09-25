using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Entitie
{
    public class UserInfoEntity:BaseEntity
    {
        public string UserName { get; set; }//用户姓名
        public string PassWordSalt { get; set; }//密码盐
        public string PassWordHash { get; set; }//哈希密码
        public virtual RoleInfoEntity RoleInfo { get; set; }//用户角色
        public long RoleInfoId { get; set; }//用户角色Id
        public bool Gender { get; set; }//性别
        public string PassQuestion { get; set; }//密码提示问题
        public string PassAnswer { get; set; } //密码提示答案
        public string Email { get; set; } //电子邮箱
        public  string PhoneNumber { get; set; } //电话号码
        public string Address { get; set; } //联系地址
        public string IDCardNo { get; set; } //身份证号
        public float Money { get; set; } //用户余额

        public virtual UserStateEntity UserState { get; set; }//用户状态对象
        public long UserStateId { get; set; } //用户状态
        public virtual ICollection<CardTypeDTO> CardTypes { get; set; } = new List<CardTypeDTO>();
    }
}
