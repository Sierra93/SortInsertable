using System;

namespace SortInsertable {
    class Program {
        static void Main() {
            int[] arr = { 2, 2, 1, 5, 6, 9 };
            int x, i, j;
            for (i = 0; i < arr.Length; i++) {
                x = arr[i];
                for (j = i - 1; j >= 0 && arr[j] > x; j--)
                    arr[j + 1] = arr[j];
                arr[j + 1] = x;
            }
            for (int z = 0; z < arr.Length; z++) {
                Console.WriteLine(arr[z]);
            }
            Console.ReadLine();
        }
    }
}
