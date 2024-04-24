using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numAttemps = 0;

            for(int i = 0; i <=10;i++)
                if(numAttemps <= 10)
            RonVSKanyeAPI.Kayne();
            RonVSKanyeAPI.Ron();
            Thread.Sleep(1000000);
        }
    }
}
