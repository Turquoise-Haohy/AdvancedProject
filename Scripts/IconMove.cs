using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconMove : MonoBehaviour
{
    private float radian = 0;
    private float perRad = 0.05f;
    private float add = 0f;
    private Vector3 posOri;

    // Start is called before the first frame update
    void Start()
    {
        posOri = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        radian += perRad;
        add = Mathf.Sin(radian);

        transform.position = posOri + new Vector3(0, add*6, 0);

       
    }
}
