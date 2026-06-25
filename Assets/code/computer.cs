using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class computer : MonoBehaviour
{
    public GameObject arrow;
    // Start is called before the first frame update
    float a;
    void Start()
    {
        Application.targetFrameRate = 60;
        a = 0;
    }
    float i = 0;
    // Update is called once per frame
    void Update()
    {
        a += 0.2f;
        GameObject arrowCopy=Instantiate(arrow);
        arrowCopy.transform.position = transform.position;
        arrowCopy.transform.rotation=transform.rotation;
        //if (a > 60)
        //{
        transform.position = new Vector3(i, 0.1f, Mathf.Sin(i / 8) * 50);
        float angle=-6.25f*Mathf.Cos(i / 8);
        transform.eulerAngles=new Vector3(0,Mathf.Atan(angle)*Mathf.Rad2Deg+90,0);
        a = 0;
        i += 0.5f;
        //}

    }
}
