namespace Class_12th
{
    internal class Program
    {
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Qsort(int[] arr, int start, int end)
        {
            // left가 right보다 크거나 같아졌을 때 종료
            if (start >= end)
            {
                return;
            }

            // pivot 변수의 값을 설정합니다.
            int pivot = start;

            // left 변수의 값을 설정합니다.
            int left = start + 1;

            // right 변수의 값을 설정합니다.
            int right = end;

            // left가 right보다 크거나 같을 때까지 반복합니다.
            while (left <= right)
            {
                // left가 end보다 작거나 같다면 반복하도록 실행하고 그다음
                // pivot 값보다 left의 값이 작을 때 left를 오른쪽으로 이동시킵니다.
                while (left <= end && arr[pivot] >= arr[left])
                {
                    left++;
                }
                // right가 start보다 크다면 반복하도록 실행하고 그다음
                // pivot 값보다 right의 값이 클 때 right를 왼쪽으로 이동시킵니다.
                while (right > start && arr[pivot] <= arr[right])
                {
                    right--;
                }

                if (left > right)
                {
                    Swap(ref arr[pivot], ref arr[right]);
                }
                else
                {
                    Swap(ref arr[left], ref arr[right]);
                }
            }

            Qsort(arr, start, right - 1);
            Qsort(arr, right + 1, end);

        }
        static void Main(string[] args)
        {
            #region 퀵 정렬
            // 기준점을 획득한 다음 해당 기준점을 기준으로
            // 배열을 나누고 한 쪽에는 기준점보다 작은 항목들이
            // 위치하고 다른 쪽에는 기준점 보다 큰 항목들이 위치합니다.

            // 나뉘어진 하위 배열에 대해 재귀적으로 퀵 정렬을 호출하여
            // 모든 배열이 기본 배열이 될 때 까지 반복하면서 정렬하는 알고리즘입니다.

            // 시간 복잡도 : O(nlog n)

            int[] arr = new int[9] { 5, 3, 8, 4, 9, 1, 6, 2, 7 };

            Qsort(arr, 0, arr.Length - 1);

            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }

            #endregion
        }
    }
}