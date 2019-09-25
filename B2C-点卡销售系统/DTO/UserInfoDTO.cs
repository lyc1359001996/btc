using System;
using System.Collections.Generic;
using System.Text;

namespace B2C.DTO
{
    public class UserInfoDTO:BaseDTO
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户角色名
        /// </summary>
        public string UserRoleName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public bool Gender { get; set; }
        /// <summary>
        /// 密码提示问题
        /// </summary>
        public string PassQuestion { get; set; }
        /// <summary>
        /// 码提示答案
        /// </summary>
        public string PassAnswer { get; set; }
        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 联系地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string IDCardNo { get; set; }
        /// <summary>
        /// 用户余额
        /// </summary>
        public float Money { get; set; }
        /// <summary>
        /// 用户状态
        /// </summary>
        public string UserState { get; set; }
        /// <summary>
        /// 角色id
        /// </summary>
        public long RoleId { get; set; }
        /// <summary>
        /// 用户状态id
        /// </summary>
        public long UserStateId { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        public long[] CardTypeIds { get; set; }
    }
}
