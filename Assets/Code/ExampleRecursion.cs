using UnityEngine;

namespace Code
{
    public class ExampleRecursion : MonoBehaviour
    {
        public int N;

        private void Start()
        {
            Cycle();
            int i = Recursion(N);
            Debug.LogError(i);
        }

        private void Cycle()
        {
            int a0 = 0;
            int a1 = 1;
            int temp = 0;

            for (int i = 1; i <= N; i++)
            {
                temp = a0 + a1;
                a0 = a1;
                a1 = temp;
            }

            Debug.LogError(temp);
        }

        private int Recursion(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            int i = Recursion(n - 1) + Recursion(n - 2);
            return i;
        }
    }
}

