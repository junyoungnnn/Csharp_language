namespace Program
{
    internal class Program
    {
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void QuickSort(int[] arr, int left, int right)
        {
            // left가 right보다 크거나 같아졌을 때 종료
            if (left >= right)
            {
                return;
            }

            int pivot = arr[left];
            left++;

            while (left < right)
            {
                if (pivot > arr[left])
                {
                    left++;
                }

                if (pivot < arr[right])
                {
                    right--; 
                }
        }

        Swap(ref arr[left], ref arr[right]);
            QuickSort(arr, left, pivot - 1);
            QuickSort(arr, pivot + 1, right);


            static void Main(string[] args)
            {
                #region 퀵 정렬
                // 기준점을 획득한 다음 해당 기준점을 기준으로
                // 배열을 나누고 한 쪽에는 기준점보다 작은 항목들이
                // 위치하고 다른 쪽에는 기준점 보다 큰 항목들이 위치합니다.

                // 나뉘어진 하위 배열에 대해 재귀적으로 퀵 정렬을 호출하여
                // 모든 배열이 기본 배열이 될 때 까지 반복하면서 정렬하는 알고리즘입니다.

                // 시간 복잡도 : O(log n)

                int[] arr = { 5, 3, 8, 4, 9, 1, 6, 2, 7 };

                QuickSort(arr, 0, arr.Length - 1);

                #endregion
            }
        }
    }
}