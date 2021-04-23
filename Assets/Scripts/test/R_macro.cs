using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_macro : MonoBehaviour
{
    public GameObject QS,AS,ZS,EQ,EA,EZ;
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag=="center"){
            if(QS.activeSelf){
                AS.SetActive(true);
                QS.SetActive(false);
                ZS.SetActive(false);

                EA.SetActive(true);
                EQ.SetActive(false);
                EZ.SetActive(false);
            }
            else if(AS.activeSelf){
                ZS.SetActive(true);
                QS.SetActive(false);
                AS.SetActive(false);

                EZ.SetActive(true);
                EQ.SetActive(false);
                EA.SetActive(false);
            }
            else if(ZS.activeSelf){
                QS.SetActive(true);
                AS.SetActive(false);
                ZS.SetActive(false);

                EQ.SetActive(true);
                EA.SetActive(false);
                EZ.SetActive(false);
            }
        }
    }
}
