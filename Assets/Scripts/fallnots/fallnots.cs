using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallnots : MonoBehaviour
{
    //1.5s
    private float fspeed = 6.31f;
    //1.2s
    //private float fspeed = 7.93f;
    //1s
    //private float fspeed = 9.7f;
    

    void Update()
    {
        Transform myT = this.transform;
        Vector3 myP = myT.position;
        myP -= new Vector3(0,fspeed*Time.deltaTime,0);
        myT.position = myP;
        
        if(myP.y<=-7.0f){
            Destroy(gameObject);
        }
    } 
}
