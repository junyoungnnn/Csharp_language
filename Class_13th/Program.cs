namespace Class_13th
{
    internal class Program
    {
        public static void Merge(int[] arr, int[] newArr, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;

                Merge(arr, newArr, start, mid);

                Merge(arr, newArr, mid + 1, end);

                M(arr, start, mid, end);
                //MergeSort(arr, newArr, start, mid, end);
            }
        }

        public static void M(int[] arr, int start, int mid, int end)
        {
            int[] leftArr = new int[mid - start + 1];
            int[] rightArr = new int[end - mid];

            int index = start;
            int left = 0;
            int right = 0;

            for (left = 0; index <= mid; left++)
            {
                leftArr[left] = arr[index++];
            }

            for (right = 0; index <= end; right++)
            {
                rightArr[right] = arr[index++];
            }

            index = start;

            left = 0;
            right = 0;

            while (left < leftArr.Length && right < rightArr.Length)
            {
                if (leftArr[left] < rightArr[right])
                {
                    arr[index] = leftArr[left++];
                }
                else
                {
                    arr[index] = rightArr[right++];
                }

                index++;
            }

            while (left < leftArr.Length)
            {
                arr[index++] = leftArr[left++];
            }
            while (right < rightArr.Length)
            {
                arr[index++] = rightArr[right++];
            }
        }

        public static void MergeSort(int[] arr, int[] newArr, int start, int mid, int end)
        {
            //int rightSize = end - (start - end) / 2;

            int k = start;
            int j = mid + 1;
            int index = start;

            for (int i = start; i <= end; i++)
            {
                newArr[i] = arr[i];
            }

            while (k <= mid && j <= end)
            {
                if (newArr[k] < newArr[j])
                {
                    arr[index++] = newArr[k++];
                }
                else
                {
                    arr[index++] = newArr[j++];
                }
            }

            while (k <= mid)
            {
                arr[index++] = newArr[k++];
            }
            while (j <= end)
            {
                arr[index++] = newArr[j++];
            }

        }

        static void Main(string[] args)
        {
            #region 병합 정렬
            // 하나의 리스트를 두개의 균등한 크기로 분할하고
            // 분할된 부분 리스트를 정렬한 다음, 두개의 정렬된 부분
            // 리스트를 합하여 전체가 정렬된 리스트가 되게 하는 방법입니다.

            // 분할 : 입력 배열의 같은 크기의 2개의 부분 배열로 분할합니다.
            // 정복 : 부분 배열을 정렬하며, 부분 배열의 크기가 충분히 작지 않으면
            //        순환 호출을 이용하여 다시 분할 정복을 실행합니다.
            // 결합 : 정렬된 부분 배열들을 하나의 배열에 병합합니다.

            int[] arr = new int[9] { 5, 3, 8, 4, 9, 1, 6, 2, 7 };
            int[] newArr = new int[arr.Length];

            Merge(arr, newArr, 0, arr.Length - 1);

            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }

            #endregion
        }
    }
}