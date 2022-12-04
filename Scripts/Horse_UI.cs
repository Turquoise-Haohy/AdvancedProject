using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Horse_UI : MonoBehaviour
{

    public GameObject TextTrigger;
    public Animator horses;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTextTrigger(bool bl)
    {
        TextTrigger.SetActive(bl);
    }

    public void Btn_Round()
    {
        horses.SetBool("rollHorse",true);
    }
}
