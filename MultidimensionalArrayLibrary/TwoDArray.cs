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
    public class TwoDArray<T>
    {
        private int _rank;
        public int RowLenght;
        public int ColumnLenght;
        private T[,] _array;
        public TwoDArray(T[,] _2DArray)
        {
            _rank = _2DArray.Rank;
            RowLenght = _2DArray.GetLength(0);
            
            if (_rank != 2)
                throw new Exception("Invalid array, An array should be 2D form");

            ColumnLenght = _2DArray.GetLength(1);

            if (RowLenght != ColumnLenght)
                throw new Exception("Invalid array, An array should be in cube form. (equal in both lenghts)");

            _array = _2DArray;
        }

        /// <summary>
        /// Get row of a multdimensional array base on given row index
        /// </summary>
        /// <param name="rowIndex">Represents the index of a row</param>
        /// <returns>The result will be in the form of Array</returns>
        public T[] GetRow(int rowIndex)
        {
            try
            {
                T[] array = new T[RowLenght];
                for (int i = 0; i < RowLenght; i++)
                {
                    array.SetValue(_array.GetValue(rowIndex, i), i);
                }
                return array;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Get reversed row of a multdimensional array base on given row index
        /// </summary>
        /// <param name="rowIndex">Represents the index of a row</param>
        /// <returns>The result will be in the form of Array</returns>
        public T[] GetRowReverse(int rowIndex)
        {
            try
            {
                var array  = GetRow(rowIndex).Reverse();
                return array.ToArray();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Get column of a multdimensional array base on given column index
        /// </summary>
        /// <param name="rowIndex">Represents the index of a column</param>
        /// <returns>The result will be in the form of Array</returns>
        public T[] GetColumn(int rowIndex)
        {
            try
            {
                T[] array = new T[ColumnLenght];
                for (int i = 0; i < ColumnLenght; i++)
                {
                    array.SetValue(_array.GetValue(i, rowIndex), i);
                }
                return array;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Get reversed column of a multdimensional array base on given column index
        /// </summary>
        /// <param name="rowIndex">Represents the index of a column</param>
        /// <returns>The result will be in the form of Array</returns>
        public T[] GetColumnReverse(int rowIndex)
        {
            try
            {
                var array = GetColumnReverse(rowIndex).Reverse();
                return array.ToArray();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
