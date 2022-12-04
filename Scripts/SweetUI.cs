using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SweetUI : MonoBehaviour
{
    public GameObject startMemo;
    public GameObject BestIce;
    public GameObject BestDonuts;
 


    void Awake()
    {
        
    }


    public void ShowCode(bool bl)
    {
        startMemo.SetActive(bl);
        BestIce.SetActive(bl);
        BestDonuts.SetActive(bl);
    }
    
}
