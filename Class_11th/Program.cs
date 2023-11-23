namespace Class_11th
{
    internal class Program
    {
        public static void BinarySearch(int data, int[] arr, int left, int right)
        {
            int mid = (left + right) / 2;

            if (data < left || data > right)
            {
                Console.WriteLine(data + "을 찾을 수 없습니다");
                return;
            }
            if (data == mid)
            {
                Console.WriteLine(data + "을 찾았습니다");
            }
            else if (data > mid)
            {
                BinarySearch(data, arr, mid + 1, right);
            }
            else if (data < mid)
            {
                BinarySearch(data, arr, left, mid - 1);
            }

        }

        static void Main(string[] args)
        {
            #region 이진 탐색
            // 오름차순으로 정렬된 리스트에서 특정한 값의 위치를 찾는 알고리즘입니다.

            // 1. 배열의 가운데 요소의 인덱스를 pivot으로 설정합니다.

            // 2. [pivot]의 값이 찾고자 하는 요소가 같다면 검색완료

            // 3. [pivot]의 값이 찾는 값보다 크다면 left ~ pivot 사이를 검색합니다.

            // 4. [pivot]의 값이 찾는 값보다 작다면 pivot ~ right 사이를 검색합니다.

            //int[] array = { 1, 2, 3, 4, 5, 6 };

            //BinarySearch(10, array, 0, 6);

            #endregion
        }
    }
}