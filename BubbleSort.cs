using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BubbleSort
{
    internal class BubbleSort
    {
        private int[] _numbers;
        private int intTemp;
        private bool isSorted;

        public int[] Numbers {
            get {
                return _numbers;
            }
            set {
                _numbers = value;
            } 
        }
     
        public void sort()
        {
            for( var i = 0; i < _numbers.Length; i++)
            {
                isSorted = true;
                for( var j = 1; j < _numbers.Length - i; j++)
                {
                    if (_numbers[j] < _numbers[j - 1])
                    {
                        swap(_numbers, j, j - 1);
                        isSorted = false;
                    }
                }
                if(isSorted)
                {
                    return;
                }
            }
        }

        public void swap(int[] array, int index1, int index2)
        {
            intTemp = array[index1];
            array[index1] = array[index2];
            array[index2] = intTemp;
        }
    }
}
