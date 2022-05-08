// See https://aka.ms/new-console-template for more information
            const int index = 5;
            string [] s = new string[index] {"Denmark","1567","-2","world","war"};
            string[] s2 = new string[index];
            int j = 0;
            

            SortArray();
            PrintArray();

            // поиск элементов удовлетворяющих условиям задачи
            void SortArray ()
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i].Length <= 3)
                    {
                        s2[j] = s[i];
                        j++;
                    }
                }
            }
            // вывод нового массива на экран
            void PrintArray ()
            {
                for (int i = 0; i < j; i++)
                {

                    Console.Write(s2[i] + " ");


                }
            }
            Console.ReadKey();
