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
            Thread.Sleep(500);
            RonVSKanyeAPI.Ron();
           
        }
    }
}
