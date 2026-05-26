using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlCar : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            rb.AddForce(new Vector3(Mathf.Sin(Mathf.Deg2Rad * transform.eulerAngles.y), -0.25f, Mathf.Cos(Mathf.Deg2Rad * transform.eulerAngles.y)));
        }
        if (Input.GetKey(KeyCode.K))
        {
            rb.AddForce(new Vector3(Mathf.Sin(Mathf.Deg2Rad * transform.eulerAngles.y), -0.25f, Mathf.Cos(Mathf.Deg2Rad * transform.eulerAngles.y))*-0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0);
        }
    }
}
