using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GreenMemo_UI : MonoBehaviour
{
    public GameObject GreenMemo;
    public GameObject GreenMemo1;
    public static GreenMemo_UI Instance;


    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowText(bool bl)
    {
        GreenMemo.SetActive(bl);
    }
    public void ShowText1(bool bl)
    {
        GreenMemo1.SetActive(bl);
    }
}
