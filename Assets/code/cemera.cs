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
    int mode = 1;
    // Update is called once per frame
    void Update()
    {
        switch (mode % 2)
        {
            case 0:
                transform.position = car.transform.position - 2 * (new Vector3(Mathf.Sin(Mathf.Deg2Rad * car.transform.eulerAngles.y), -0.5f, Mathf.Cos(Mathf.Deg2Rad * car.transform.eulerAngles.y)));
                
        transform.LookAt(car.transform.position);break;
            case 1:
                transform.position = car.transform.position - 2 * (new Vector3(0, -0.175f,0));
                transform.eulerAngles = new Vector3(0, car.transform.eulerAngles.y, 0);
                break;
        }
    }
}
