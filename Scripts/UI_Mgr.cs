using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UI_Mgr : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ARTrigger;
    public static UI_Mgr Instance;
    //apply for static instance

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

    public void SetARTrigger(bool bl)
    {
        ARTrigger.SetActive(bl);
    }


    public void Btn_GoAR()
    {
        SceneManager.LoadScene("ARScene");
    }

    public void Btn_GoMain()
    {
        SceneManager.LoadScene("OpeningScene");
    }
    public void Btn_GoCol()
    {
        SceneManager.LoadScene("CollectionScene");
    }
    public void Btn_GoMap()
    {
        SceneManager.LoadScene("MapScene");
    }
}
