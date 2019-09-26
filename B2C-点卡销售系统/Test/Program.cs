using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2C.DAL.Service;
using B2C.DTO.DTO;
using B2C.Service.Service;
using Service;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (B2CDbContext dbc = new B2CDbContext())
            //{
            //    dbc.Database.Delete();
            //    dbc.Database.Create();
            //}
            //AdviceService adviceService = new AdviceService();
            //adviceService.InsertAdvice(new B2C.DTO.AdviceDTO()
            //{
            //    Content = "aaaa",
            //    UserId = 1,
            //    UserName="lyc"
            //}); ;
            //UserInfoService userInfoService = new UserInfoService();
            //userInfoService.AddUserInfo(new B2C.DTO.UserInfoDTO()
            //{
            //    Address = "111",
            //    PassAnswer = "密码答案",
            //    Email = "122",
            //    Gender = true,
            //    IDCardNo = "11231313111",
            //    Money = 30,
            //    PassQuestion = "密码提示问题",
            //    Password = "111",
            //    PhoneNumber = "1111111",
            //    UserName = "aaaaa",

            //});

            //ApproveStateService approveStateService = new ApproveStateService();
            //ApproveStateDTO approveStateDTO = new ApproveStateDTO()
            //{
            //    ApproveStateName = "adasdasdasda"
            //};
            //approveStateService.InsertApproveState(approveStateDTO);
            Console.WriteLine("ok");
            Console.ReadKey();
        }
    }
}
