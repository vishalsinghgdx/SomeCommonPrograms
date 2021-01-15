using System;

/// <summary>
/// Implementing custom array methods
/// </summary>
namespace CommonProgram
{
    class CustomArray
    {
        int[] numbers;
        int count;

        public CustomArray(int len)
        {
            numbers = new int[len];
        }

        public void Insert(int number)
        {
            if (numbers.Length == count)
            {
                // create new array
                int[] newArray = new int[count * 2];
                // copy old array items to new array
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = numbers[i];
                }
                // assing new array to old array
                numbers = newArray;
            }
            numbers[count++] = number;
        }

        public void RemoveAt(int index) 
        {
            if (index > count - 1 || index < 0)
            {
                Console.WriteLine("Index is out of bound");
                return;
            }
            for (int i = index; i < count - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            count--;
        }

        public void ItemAtIndex(int index)
        {
            if(index < 0 || index >= count)
            {
                Console.WriteLine("Searched index out of bound");
                return;
            }
            Console.WriteLine(numbers[index]);
        }

        public int IndexOf(int item)
        {
            for(int i = 0; i < count; i++)
            {
                if(numbers[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
