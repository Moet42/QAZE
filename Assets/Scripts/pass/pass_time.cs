using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pass_time : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag=="center"){
            Debug.Log("pass:"+Time.time);
        }
    }
}
