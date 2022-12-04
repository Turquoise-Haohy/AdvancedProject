using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointEvent : MonoBehaviour
{

    public GameObject[] Spots;
    // Start is called before the first frame update
    void Awake()
    {
        Spots = Resources.LoadAll<GameObject>("Pets");
    }
    void Start()
    {
        InsSpots();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void InsSpots()
    {
        int _spotIndex = Random.Range(0, Spots.Length);
        GameObject MapSpot = Instantiate(Spots[_spotIndex], transform.position + new Vector3(0, 5f, 0), transform.rotation);

        MapSpot.GetComponent<Spot_Find>().Model_Index = _spotIndex;

    }
  
}
