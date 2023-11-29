namespace Class_14th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 그래프
            // 정점(Vertex)과 간선(Edge)들이 서로 복잡하게 연결되어 있는 자료구조 입니다.

            // 정점(Vertex)
            // 노드(node)라고도 하며, 데이터가 저장되는 그래프의 기본 원소입니다.

            // 간선(Edge)
            // 링크(link)라고도 하며, 정점 간의 관계를 나타냅니다.

            // 인접 정점(adjacent vertex)
            // 하나의 정점에서 간선의 

            // 차수(Degree)
            // 정점에 연결되어 있는 간선의 수를 의미합니다.

            // 진입 차수
            // 외부에서 오는 간선의 수를 의미합니다.

            // 진출 차수
            // 외부로 향하는 간선의 수를 의미합니다.

            // 단순 경로(Simple Path)
            // 경로 중에서 반복되는 간선이 없는 경로를 의미합니다.

            // 사이클(Cycle)
            // 시작 정점과 종료 정점이 같은 단순 경로를 의미합니다.

            #endregion

            #region 인접 행렬
            // 그래프에서 어느 노드들이 간선으로 연결되어 있는지를 나타내는 행렬이며,
            // 2차원 배열로 구현되어 있고 노드 사이에 간선이 있다면 1, 없다면 0으로 표현합니다.

            /*
            AdjacencyMatrix<char> adjacency = new AdjacencyMatrix<char>(4);

            adjacency.InsertVertex('A');
            adjacency.InsertVertex('B');
            adjacency.InsertVertex('C');
            adjacency.InsertVertex('D');

            adjacency.InsertEdge(0, 1);
            adjacency.InsertEdge(0, 2);
            adjacency.InsertEdge(0, 3);
            adjacency.InsertEdge(1, 2);
            adjacency.InsertEdge(2, 3);

            adjacency.Display();
            */
            #endregion

            #region 인접 리스트
            // 각 노드에 연결된 노드들을 원소를 갖는 리스트들의 배열을 의미하며,
            // 인접 리스트가 있다면 [i]는 i번째 노드에 연결된 노드을 원소로
            // 가지는 리스트입니다.

            /*
            AdjacencyList adjacencylist = new AdjacencyList(6);

            adjacencylist.AddEdge(0, 1);
            adjacencylist.AddEdge(0, 2);
            adjacencylist.AddEdge(1, 3);
            adjacencylist.AddEdge(1, 4);
            adjacencylist.AddEdge(2, 5);
            adjacencylist.AddEdge(2, 6);

            adjacencylist.Display();
            */

            //           0
            //       1       2
            //     3  4    5   6
            #endregion

        }
    }
}