using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrayLibrary
{
    /// <summary>
    /// This TwoDArray class will operate with multiple functionalites.
    /// </summary>
    public class TwoDArray
    {
        private int _rank;
        public int RowLenght;
        public int ColumnLenght;

        public TwoDArray(Array _2DArray)
        {
            _rank = _2DArray.Rank;
            RowLenght = _2DArray.GetLength(0);
            if (_rank != 2)
                throw new Exception("Invalid array, An array should be 2D form");

            ColumnLenght = _2DArray.GetLength(1);

            if (RowLenght != ColumnLenght)
                throw new Exception("Invalid array, An array should be in cube form. (equal in both lenghts)");

        }
    }
}
