using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLoops : MonoBehaviour
{
    [SerializeField]
    private int LoopNum;
    public GameObject loop;

    // Start is called before the first frame update
    void Start()
    {
        //generating the number of loops
        for (int i = 0; i < LoopNum; i++) 
            {
            //number is based on platform, lmk if theres an easier way to do this.
            Instantiate(loop, new Vector3(Random.Range(-42.9f, 44.3f), Random.Range(2, 30), Random.Range(40, -41)), Quaternion.identity);

        }
        
    }


            // Update is called once per frame
            void Update()
    {
        //Instantiate(loop, new Vector3(Random.Range(-42.9f, 44.3f), Random.Range(2,30), Random.Range(40, -41)),Quaternion.identity);

      //  tempObj.Rotate(90, 0, 0);
    }
}
