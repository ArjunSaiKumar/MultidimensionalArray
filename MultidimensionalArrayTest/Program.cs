using MultidimensionalArrayLibrary;

namespace MultidimensionalArrayTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[,] twoDArray = new[,] { { 1, 4, 2 }, { 3, 6, 8 }, { 7, 5, 9 } };//, { 7, 5, 9 }
                string[,] twoDArray2 = new[,] { { "1", "1", "1" }, { "1", "1", "1" }, { "1", "1", "1" } };
                TwoDArray<int> twoDArrays = new(new[,] { { 1, 4, 2 }, { 3, 6, 8 }, { 7, 5, 9 } });//, { 7, 5, 9 }
                var r = twoDArrays.GetColumn(2);
                var t = twoDArray.GetType();
                var t2 = twoDArray2.GetType();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}