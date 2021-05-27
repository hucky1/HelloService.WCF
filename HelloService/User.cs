using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace UserService
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public bool PreferrerCustomer { get; set; }
        [DataMember]
        public float Income { get; set; }
        [DataMember]
        public List<int> HightScores{ get; set; }
       
        public User(int id, string name, bool preferrerCustomer, float income, List<int> hightScores)
        {
            Id = id;
            Name = name;
            PreferrerCustomer = preferrerCustomer;
            Income = income;
            HightScores = hightScores;
        }
    }
}