 //task3 Написать программу копирования массива
 
 static void Copy()
 {
        int[] array = {1, 3, 9, 23, 11};

        Console.Write("Original array: ");
        Console.WriteLine(String.Join(", ", array));
        
        int[] copy = new int[array.Length];
        array.CopyTo(copy, 0);

        Console.Write("Copy of array:  ");
        Console.WriteLine(String.Join(", ", copy));
 }

 Copy();
