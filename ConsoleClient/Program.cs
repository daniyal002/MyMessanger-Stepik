using Newtonsoft.Json;

namespace MyMessanger_Stepik
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("Daniyal", "Hello", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Message dsmsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(output);
            Console.WriteLine(dsmsg);
        }
    }
}