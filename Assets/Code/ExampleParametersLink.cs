using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Code
{
    public class ExampleParametersLink : MonoBehaviour
    {
        private void Start()
        {
            int i = 5;
            First(i);
            Debug.LogError(i);

            int j = 5;
            Second(ref j);
            Debug.LogError(j);

            int k = 5;
            Third(out k);
            Debug.LogError(k);

            int t = 5;
            Fourth(in t);
            Debug.LogError(t);
        }

        private void First(int i)
        {
            i = 8;
        }

        private void Second(ref int i)
        {
            i = 8;
        }

        private void Third(out int i)
        {
            i = 8;
        }

        private void Fourth(in int i)
        {
            //i = 8;
        }
    }
}
