using System.Linq.Expressions;

namespace Program
{
    internal class Program
    {
        public static void Merge(int []arr, int start, int end)
        {
            int mid = (start + end) / 2;
            
            if(start == end) 
            {
                return;
            }

            Merge(arr, start, mid);

            Merge(arr, mid + 1, end);

        }

        public static void Conquer(int[]arr, int start, int end)
        {
            int rightSize = end - (start - end) / 2;
            int[] newArr = new int[rightSize];


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

            Merge(arr, 0, arr.Length - 1);

            #endregion
        }
    }
}
