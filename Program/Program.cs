using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BFS (너비 우선 탐색)

            // Queue에 root노드를 넣어줍니다.

            // visited 배열에 방문 체크

            // 반복문이 돌아가는 위치
            // 1. Queue가 비어있을 때 까지 반복합니다.

            // 2. Queue에서 데이터를 뽑습니다.

            // 3. Queue에서 뽑은 데이터를 출력합니다.

            // 4. 반복문을 이용해서 자기와 인접한 노드를 Queue에 넣습니다.

            // 5. 방문하지 않는 정점이라고 한다면

            // 6. 해당 vertex 방문 체크해주고 Queue에 데이터를 넣어줍니다.

            AdjacencyList adjacencylist = new AdjacencyList(7);

            adjacencylist.AddEdge(0, 1);
            adjacencylist.AddEdge(0, 2);
            adjacencylist.AddEdge(1, 3);
            adjacencylist.AddEdge(1, 4);
            adjacencylist.AddEdge(2, 5);
            adjacencylist.AddEdge(2, 6);

            adjacencylist.Display();

            adjacencylist.BFS(0);

            #endregion

        }
    }
}
