using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spot_Find : MonoBehaviour
{
    // Start is called before the first frame update

    public int Model_Index;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Avatar")
        {
            UI_Mgr.Instance.SetARTrigger(true);

            StaticData.TriggerModelIndex = Model_Index;
        }
    }
}
