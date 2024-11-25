using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrayA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int counter=1;
        while(counter<=20)
        {
            int randomNumber=Random.Range(1,21);
            Debug.Log( randomNumber);
            counter++;
            if(randomNumber==5)
            {
                continue;
            }

            if(randomNumber==15)
            {
                break;
            }
        }
        Debug.Log("the end");


        
    }
}
