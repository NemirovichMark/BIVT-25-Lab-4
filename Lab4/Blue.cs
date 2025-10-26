// ﻿using System.Runtime.InteropServices;

// namespace Lab4
// {
//     public class Blue
//     {
//         public void Task1(int[] array)
//         {

//             // code here

//             // end

//         }
//         public int[] Task2(int[] array, int P)
//         {
//             int[] answer = null;

//             // code here

//             // end

//             return answer;
//         }
//         public int[] Task3(int[] array)
//         {
//             int[] answer = null;

//             // code here

//             // end

//             return answer;
//         }
//         public void Task4(double[] array)
//         {

//             // code here

//             // end

//         }
//         public int Task5(int[] A, int[] B)
//         {
//             int sum = 0;

//             // code here

//             // end

//             return sum;
//         }
//         public int[] Task6(int[] array)
//         {
//             int[] indexes = null;

//             // code here

//             // end

//             return indexes;
//         }
//         public int Task7(int[] array)
//         {
//             int count = 0;

//             // code here

//             // end

//             return count;
//         }
//         public int[] Task8(int[] array)
//         {
//             int[] answer = null;

//             // code here

//             // end

//             return answer;
//         }
//         public double[] Task9(int[] array)
//         {
//             double[] normalized = null;

//             // code here

//             // end

//             return normalized;
//         }
//         public int Task10(int[] array, int P)
//         {
//             int index = 0;

//             // code here

//             // end

//             return index;
//         }
//         public int[] Task11(int a, int b, int c)
//         {
//             int[] array = null;

//             // code here

//             // end

//             return array;
//         }

//         public int[] Task12(int[] magazine)
//         {
//             int[] indexes = null;

//             // code here

//             // end

//             return indexes;
//         }
//     }

// }

using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {
            if (array == null || array.Length == 0)
                return;

            // 1. Encontrar índice del máximo elemento
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                    maxIndex = i;
            }

            // 2. Calcular la suma de los elementos después del máximo
            int sumAfterMax = 0;
            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                sumAfterMax += array[i];
            }

            // 3. Encontrar primer elemento negativo y reemplazarlo
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = sumAfterMax;
                    break; // solo el primero
                }
            }
        }
        public int[] Task2(int[] array, int P)
        {
            if (array == null || array.Length == 0)
                return array;

            // 1. Buscar el índice del último elemento positivo
            int lastPositiveIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    lastPositiveIndex = i;
            }

            // 2. Si no hay positivos, devolver copia del array original
            if (lastPositiveIndex == -1)
            {
                int[] copy = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                    copy[i] = array[i];
                return copy;
            }

            // 3. Crear nuevo array con un espacio más
            int[] answer = new int[array.Length + 1];

            // 4. Copiar hasta el último positivo inclusive
            for (int i = 0; i <= lastPositiveIndex; i++)
            {
                answer[i] = array[i];
            }

            // 5. Insertar P después del último positivo
            answer[lastPositiveIndex + 1] = P;

            // 6. Copiar el resto de elementos
            for (int i = lastPositiveIndex + 1; i < array.Length; i++)
            {
                answer[i + 1] = array[i];
            }

            return answer;
        }

        public int[] Task3(int[] array)
        {
            if (array == null || array.Length == 0)
                return array;

            // 1. Buscar el índice del mínimo elemento positivo
            int minPositiveIndex = -1;
            int minPositiveValue = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < minPositiveValue)
                {
                    minPositiveValue = array[i];
                    minPositiveIndex = i;
                }
            }

            // 2. Si no hay elementos positivos, devolver copia del array
            if (minPositiveIndex == -1)
            {
                int[] copy = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                    copy[i] = array[i];
                return copy;
            }

            // 3. Crear nuevo array con un elemento menos
            int[] answer = new int[array.Length - 1];

            // 4. Copiar todo menos el elemento a eliminar
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i != minPositiveIndex)
                {
                    answer[j] = array[i];
                    j++;
                }
            }

            return answer;
        }

        public void Task4(double[] array)
        {
            if (array == null || array.Length == 0)
                return;

            // 1. Calcular el promedio (media aritmética)
            double sum = 0;
        for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double average = sum / array.Length;

            // 2. Restar el promedio a cada elemento
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= average;
            }
        }
        public int Task5(int[] A, int[] B)
        {
            if (A == null || B == null) return 0;
            if (A.Length != B.Length) return 0;

            int sum = 0;
            for (int i = 0; i < A.Length; i++)
                sum += A[i] * B[i];

            return sum;
        }


        public int[] Task6(int[] array)
        {
            if (array == null || array.Length == 0)
                return new int[0];

            // 1. Calcular el promedio
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double average = sum / array.Length;

            // 2. Contar cuántos elementos son menores que el promedio
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < average)
                    count++;
            }   

            // 3. Crear el nuevo array para los índices
            int[] result = new int[count];

            // 4. Llenarlo con los índices de los elementos menores al promedio
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < average)
                {
                    result[j] = i;
                    j++;
                }
            }

            return result;
        }       

        public int Task7(int[] array)
        {
            if (array == null || array.Length == 0) return 0;
            if (array.Length == 1) return 1;

            int incLen = 1; // no-decreciente
            int decLen = 1; // no-creciente
            int maxLen = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    incLen += 1;
                    decLen = 1;
                }
                else if (array[i] < array[i - 1])
                {
                    decLen += 1;
                    incLen = 1;
                }
                else // iguales
                {
                    incLen += 1;
                    decLen += 1;
                }

                if (incLen > maxLen) maxLen = incLen;
                if (decLen > maxLen) maxLen = decLen;
            }

            return maxLen;
        }


        public int[] Task8(int[] array)
        {
            int[] answer = null;

            if (array == null)
                return null;

            // crear el nuevo arreglo con el doble de longitud
            answer = new int[array.Length * 2];

            // duplicar cada elemento manteniendo el orden
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                answer[j++] = array[i];
                answer[j++] = array[i];
            }

            return answer;
        }


        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            if (array == null || array.Length == 0)
                return null;

            int min = array[0];
            int max = array[0];

            // 1. Encontrar el mínimo y máximo
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }

            // 2. Si todos los elementos son iguales → devolver null
            if (min == max)
                return null;

            // 3. Crear el nuevo array normalizado
            normalized = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = (double)(array[i] - min) / (max - min);
            }

            return normalized;
        }

        public int Task10(int[] array, int P)
        {
            int index = -1; // -1 por defecto, si no se encuentra

            if (array == null || array.Length == 0)
                return -1;

            // 1. Ordenar el array
            Array.Sort(array);

            // 2. Búsqueda binaria
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < P)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return index;
        }

        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            if (b <= 0) return null;   // b debe ser positivo
            if (a > c)  return null;   // no hay elementos

            int count = ((c - a) / b) + 1;
            array = new int[count];

            for (int i = 0; i < count; i++)
                array[i] = a + i * b;

                return array;
        }


        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            if (magazine == null || magazine.Length == 0)
                return Array.Empty<int>();

            int n = magazine.Length;

            // Si hay menos de 3 habitaciones, devolvemos todos los índices existentes
            if (n <= 3)
            {
                indexes = new int[n];
                for (int i = 0; i < n; i++)
                    indexes[i] = i;
                return indexes;
            }

            // Ventana inicial de tamaño 3: [0,1,2]
            int currentSum = magazine[0] + magazine[1] + magazine[2];
            int maxSum = currentSum;
            int bestStart = 0;

            // Deslizamos la ventana: [1,2,3], [2,3,4], ..., [n-3, n-2, n-1]
            for (int start = 1; start <= n - 3; start++)
            {
                // actualizar suma quitando el que sale y añadiendo el que entra
                currentSum = currentSum - magazine[start - 1] + magazine[start + 2];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    bestStart = start;
                }
            }

            // Devolver los tres índices del mejor bloque
            indexes = new int[3];
            indexes[0] = bestStart;
            indexes[1] = bestStart + 1;
            indexes[2] = bestStart + 2;

            return indexes;
        }

    }
}
