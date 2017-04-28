using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindFactors : MonoBehaviour
{
    public int x;
    List<int> ints = new List<int>();
    private void Update()
   {
        for(int i = x; i > 0; i--)
        {
            if(x % i == 0)
            {
                print(i);
                //ints.Add(i);
                //ints.Add(x / i);
            }
        }

        //ints.Sort();

        //foreach (int i in ints)
            //print(i);
    }
}
