using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (B2CDbContext dbc = new B2CDbContext())
            {
                dbc.Database.Delete();
                dbc.Database.Create();
            }
            Console.WriteLine("ok");
            // string salt=CommonHelper.CreateVerifyCode(5);
            // string pwd = "123";
            //string count= CommonHelper.CalcMD5(salt+pwd);
            //string count1 = CommonHelper.CalcMD5(salt + pwd);
            // Console.WriteLine(count);
            // Console.WriteLine(count1);
            Console.ReadKey();
        }
    }
}
