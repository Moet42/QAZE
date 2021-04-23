using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passW : MonoBehaviour
{
    public GameObject PE;

    void OnTriggerStay2D(Collider2D col){
        if(col.gameObject.tag=="grate"){
            if(Input.GetKeyDown(KeyCode.W)){
                PE.GetComponent<ParticleSystem>().Play();
            }
        }
        if(col.gameObject.tag=="good"){
            if(Input.GetKeyDown(KeyCode.W)){
                PE.GetComponent<ParticleSystem>().Play();
            }
        }
        if(col.gameObject.tag=="bad"){
            if(Input.GetKeyDown(KeyCode.W)){
                PE.GetComponent<ParticleSystem>().Play();
            }
        }
    }
}
