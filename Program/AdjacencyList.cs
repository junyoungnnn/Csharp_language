using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class AdjacencyList
    {
        // 그래프의 노드

        // 그래프의 인접 리스트
        private List<char>[] adjacencyList;

        private int size;
        private int edgeSize;

        public AdjacencyList(int maxSize)
        {
            size = 0;
            adjacencyList = new List<char>[maxSize];
        }

        public void AddVertex(char data)
        {
            size++;
            adjacencyList[size++] = data;
        }

        public void AddEdge(List<char> adjacencyList)
        {
            edgeSize++;
        }

        public void Display()
        {
            for(int i = 0; i< size; i++)
            {
                for(int j = 0; j< edgeSize; j++)
                {
                    Console.Write(adjacencyList[j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
