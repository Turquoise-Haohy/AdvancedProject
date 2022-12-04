using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARInsModel : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] traPos;

    private GameObject[] models;

    void Start()
    {
        models = Resources.LoadAll<GameObject>("Models");

        InsModel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InsModel()
    {
        int _index = Random.Range(0, traPos.Length);

        Transform _tra = traPos[_index];

        GameObject _model = Instantiate(models[StaticData.TriggerModelIndex], _tra.position, _tra.rotation);

    }
}
