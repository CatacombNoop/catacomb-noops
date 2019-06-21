using Microsoft.Xna.Framework;

namespace CatacombNoops
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var g = new Game ()) {
                g.Run ();
            }   
        }
    }
}