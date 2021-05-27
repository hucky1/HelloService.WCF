using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {
        public string GetData(string value)
        {
            //create some answer based  on the value string 
            return "If your voice travels " + value + " feet, then the influence of your voice will cover " + int.Parse(value) * 3.14 + " sq feet!";
        }

       

        public string SayHello()
        {
            return "Dear friend, I pray that all may go well with you and that you may be in good health, as it goes  well with your soul.";
        }

        public HelloObject GetModelObject(string id)
        {
            HelloObject helloObject = new HelloObject();

            if (int.Parse(id) > 0)
            {
                helloObject.Happy = true;
                helloObject.HelloMessage = "Great day. Couldn't be better eh?";
            }
            else
            {
                helloObject.Happy = false;
                helloObject.HelloMessage = "Feeling very glum. I hope the sun    will come tommorow :(";
            }

            return helloObject;
        }
    }
}
