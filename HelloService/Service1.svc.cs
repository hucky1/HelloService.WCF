using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace UserService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {
        Random _random = new Random();
        List<User> _usersList;
        public Service1()
        {
            _usersList = new List<User>()
            {
                new User(1,"Batia",true,92000,GetSomeRandomScores(_random)),
                new User(2,"Matia",true,45923,GetSomeRandomScores(_random)),
                new User(3,"Sania",false,11000,GetSomeRandomScores(_random)),
                new User(4,"Nikitka",true,64200,GetSomeRandomScores(_random)),
                new User(5,"Igorek",false,17900,GetSomeRandomScores(_random)),
                new User(6,"Leshka",true,455,GetSomeRandomScores(_random))
            };
        }

        private static List<int> GetSomeRandomScores(Random _random)
        {
            List<int> listOfScores = new List<int>();
            for (int i = 0; i < _random.Next(10); i++)
            {
                listOfScores.Add(_random.Next(100));
            }
            return listOfScores;
        }

        public UserDTO GetAllUsers()
        {
            UserDTO userDTO = new UserDTO();
            userDTO.MessageCode = 1;
            userDTO.MessageText = "Everybody is here!";
            userDTO.Users = _usersList; 
            return userDTO;
        }

        public string GetData(string value)
        {
            return $"You entered a {value}";
        }

        public UserDTO GetUserById(string id)
        {
            UserDTO userDTO = new UserDTO();
            List<User> returnThesePeople = _usersList.Where(x => x.Id == int.Parse(id)).ToList();
            userDTO.Users = returnThesePeople;
            userDTO.MessageCode = returnThesePeople.Count;
            userDTO.MessageText = $"This human have id = {id}";
            return userDTO;
        }

        public UserDTO GetUsersByName(string name)
        {
            UserDTO userDTO = new UserDTO(); 
            List<User> returnThesePeople = _usersList.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
            userDTO.Users = returnThesePeople;
            userDTO.MessageCode = returnThesePeople.Count;
            userDTO.MessageText = $"The people who have {name} in their name";
            return userDTO;
        }
    }
}
