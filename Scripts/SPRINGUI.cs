using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SPRINGUI : MonoBehaviour
{
    public GameObject Memo1;
    public GameObject Memo2;
  



    void Awake()
    {

    }


    public void ShowSpringCode(bool bl)
    {
        Memo1.SetActive(bl);
        Memo2.SetActive(bl);
      
    }

}
