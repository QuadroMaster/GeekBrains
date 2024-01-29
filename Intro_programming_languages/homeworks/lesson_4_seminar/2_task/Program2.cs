int[] CreateArray(int size)
    {
        int[] arr = new int[size];
        Random rnd = new Random();
        for(int i = 0; i < size; i++)
        {
            
            arr[i] = rnd.Next(100, 1000);
            
        }
        for (int j = 0; j < size; j++)
        {
            Console.WriteLine(arr[j]);
        }
        return arr;
    }

int EvenCounter (int[] array)
    {   
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            counter += 1;
        } 
        Console.WriteLine($"\nКоличество четных чисел в массиве: {counter}");
        return counter;
    }


EvenCounter(CreateArray(5));

//Console.Write(x);