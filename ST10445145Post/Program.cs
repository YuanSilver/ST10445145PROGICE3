using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ST10445145Post
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions functions = new Functions();
           Console.WriteLine(PostRespository.GetSamplePosts().Count);
           Functions.MostLikedPost();
           Functions.MorninPost();
            Console.WriteLine("Average amount of likes: " + Functions.AverageLikes());
           Functions.Top3Post(); 
        }
    }
}
