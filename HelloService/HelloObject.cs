using System.Runtime.Serialization;

namespace HelloService
{
    public class HelloObject
    {
        [DataMember]
        public bool Happy { get; set; } = false;
        [DataMember]
        public string HelloMessage { get; set; } = "qq all";
    }
}