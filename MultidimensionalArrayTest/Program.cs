using MultidimensionalArrayLibrary;

namespace MultidimensionalArrayTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TwoDArray twoDArray = new(new[,] { { 1, 4, 2 }, { 3, 6, 8 } });//, { 7, 5, 9 }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}