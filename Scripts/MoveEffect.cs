using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEffect : MonoBehaviour
{
    private float radian = 0;
    private float perRad = 0.01f;
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

        transform.position = posOri + new Vector3(0, add, 0);

        transform.Rotate(0, Time.deltaTime * 25f, 0, Space.World);
        //Rotate around Y Axis

    }
}
