using System.ComponentModel.DataAnnotations;
using static AlgorithmsLibrary.Enumaration;

namespace AlgorithmsLibrary
{
    public class Algorithms 
    {
        static void Main(string[] args)
        {
            return;
        }
        public  List<int> SortIntList(List<int> list, SortingType sorting)
        {
            List<int> listToSort = new List<int>();

            if (list == null || list.Count == 0)
            { 
                return listToSort; 
            }


            int tempValue = 0;

            if(sorting == Enumaration.SortingType.ASC)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    for (int z = 0; z < list.Count; z++)
                    {
                        if (list[i] < list[z])
                        {
                            tempValue = 0;

                            tempValue = list[z];
                            list[z] = list[i];
                            list[i] = tempValue;
                        }

                    }

                }
            }
            else if (sorting == Enumaration.SortingType.DESC)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    for (int z = 0; z < list.Count; z++)
                    {
                        if (list[i] > list[z])
                        {
                            tempValue = 0;

                            tempValue = list[z];
                            list[z] = list[i];
                            list[i] = tempValue;
                        }

                    }

                }
            }

            return list; ; 
        }

        public  int BinarySearchFindIndex(int[] array, int x)
        {
            int result = -1;
            int left = 0; 
            int right = array.Length - 1;

            var sortedList = SortIntList(array.ToList<int>(), SortingType.ASC);

            while (left <= right)
            {
                int mid = left + ((right - left) / 2);

                if(sortedList[mid]  == x)
                {
                    return sortedList[mid];
                }
                else if ( x < sortedList[mid])
                {
                    right = mid -1;
                }
                else
                {
                    left = mid + 1;
                }

            }

            return result;
        }

        public bool IsEqualList (List<int> list1, List<int> list2)
        {
            bool result = true;

            try
            {
                var firstNotSecond = list1.Except(list2).ToList();
                var secondNotFirst = list2.Except(list1).ToList();

                if(firstNotSecond.Any() || secondNotFirst.Any())
                {
                    result = false;
                }
            }
            catch
            {
                result = false;
            }

            return result;

        }
      
        public bool TestIsStringAnagram(string a , string b)
        {
            if(string.Equals(a,b))
            {
                return true;
            }

            if(string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                return false;
            }

            var array1 = a.ToArray();
            var array2 = b.ToArray();

            if(array1 != null && array1.Length != 0)
            {
                Array.Sort(array1);
            }

            if (array2 != null && array2.Length != 0)
            {
                Array.Sort(array2);
            }

            return array1.SequenceEqual(array2);

        }

        public bool TestIntArrayEqual(int[] a, int[] b)
        {
            return a.SequenceEqual(b);
        }
    }
}



