using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class AdjacencyMatrix <T>
    {
        // 속성
        // 1. 정점의 수 (size)
        // 2. 정점의 이름 (vertex)
        // 3. 인접 행렬 (2차원 배열)

        private int size;
        private T[] vertex;
        private int[,] arr;


        public AdjacencyMatrix(int matrixSize)
        {
            size = 0;
            arr = new int[matrixSize, matrixSize];
            vertex = new T[matrixSize];
        }

        public void InsertVertex(T data)
        {
            vertex[size++] = data;
        }

        public void InsertEdge(int x, int y)
        {
            arr[x, y] = 1;
            arr[y, x] = 1;
        }

        public void Display()
        {
            Console.WriteLine("Vertex Size : " + size);

            Console.WriteLine("");

            for(int i =0; i<size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
