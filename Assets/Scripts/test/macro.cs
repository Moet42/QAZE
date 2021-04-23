using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class macro : MonoBehaviour
{
    public Text judg;
    public GameObject grate,sc;
    private int combo = 0;
    private Animator scAni;
    private string[] s = {"Q(Clone)","R(Clone)","P(Clone)","U(Clone)","O(Clone)"
                        ,"EnterQ(Clone)","A(Clone)","A(Clone)","F(Clone)","D(Clone)"
                        ,"H(Clone)","L(Clone)","EnterA(Clone)","Z(Clone)","V(Clone)"
                        ,"C(Clone)","B(Clone)","M(Clone)","Z(Clone)","EnterZ(Clone)"
                        ,"Q(Clone)","Q(Clone)"};
    void Start(){
        scAni = sc.GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag=="center"){
            GameObject notes = GameObject.Find(s[combo]);
            scAni.SetTrigger("on");
            combo++;
            judg.text = ""+combo;
            Destroy(notes);
            grate.SetActive(true);
        }
    }
}
