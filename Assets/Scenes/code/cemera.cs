using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cemera : MonoBehaviour
{
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = car.transform.position -2*(new Vector3(Mathf.Sin(Mathf.Deg2Rad * car.transform.eulerAngles.y), -0.5f, Mathf.Cos(Mathf.Deg2Rad * car.transform.eulerAngles.y)));
        //transform.position = new Vector3(5, 5, 5);
        transform.LookAt(car.transform.position);
    }
}
