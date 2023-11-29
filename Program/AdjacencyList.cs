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
        private List<int>[] adjacencyList;

        // 그래프의 사이즈
        private int size;

        public AdjacencyList(int vertexSize)
        {
            size = vertexSize;
            adjacencyList = new List<int>[vertexSize];

            for(int i = 0; i< vertexSize; i++)
            {
                adjacencyList[i] = new List<int>();
            }
        }

        public void AddEdge(int vertex, int edge)
        {
            adjacencyList[vertex].Add(edge);
        }

        public void Display()
        {
            for(int i = 0; i< size; i++)
            {
                Console.Write("adjacencyList[" + i + "] : ");
                for (int j = 0; j< adjacencyList[i].Count; j++)
                {
                    Console.Write(adjacencyList[i][j] + "->");
                }
                Console.WriteLine("");
            }
        }

        public void BFS(int rootNode)
        {
            bool[] visited = new bool[size];
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(rootNode);

            visited[rootNode] = true;

            while(queue.Count > 0)
            {
                int index;
                index = queue.Dequeue();

                Console.Write(index + " ");

                for (int j = 0; j < adjacencyList[index].Count; j++)
                {
                    if (visited[adjacencyList[index][j]] == false)
                    {
                        visited[adjacencyList[index][j]] = true;
                        queue.Enqueue((adjacencyList[index][j]));
                    }
                }          
            }
        }
    }
}
