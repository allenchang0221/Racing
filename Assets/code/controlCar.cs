using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlCar : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    //private void OnCollisionEnter(Collision collision)
    //{
    //    //rb.velocity = Vector3.zero;
    //    rb.angularVelocity = Vector3.zero;
    //}

    public GameObject drift;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            transform.position = new Vector3(transform.position.x, 0, Mathf.Sin(transform.position.x / 8) * 50);
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        if (Input.GetKey(KeyCode.K))
        {
            //rb.AddForce(new Vector3(Mathf.Sin(Mathf.Deg2Rad * transform.eulerAngles.y), -0.25f, Mathf.Cos(Mathf.Deg2Rad * transform.eulerAngles.y))*-0.5f);
            rb.AddForce(rb.velocity * -0.3f);
            //rb.velocity = Vector3.zero;
            //rb.AddForce(-1*new Vector3(Mathf.Sin(Mathf.Deg2Rad * ((transform.eulerAngles.y + engleTurn) % 360)), 0, Mathf.Cos(Mathf.Deg2Rad * ((transform.eulerAngles.y + engleTurn) % 360))) );
            //rb.AddForce(-1 * Vector3.Project(rb.velocity, transform.right) * 0.00125f);
            GameObject driftLeft = Instantiate(drift);
            driftLeft.transform.position = transform.position + new Vector3(.21f, 0, 0) - transform.forward;
            GameObject driftRight = Instantiate(drift);
            driftRight.transform.position = transform.position - new Vector3(.42f, 0, 0) - transform.forward;
        }
        if (Input.GetKey(KeyCode.J) && rb.velocity.magnitude < 12)
        {
            rb.angularVelocity *= 0.98f;
            rb.AddForce(transform.forward);
        }

        rb.AddForce(rb.velocity * -0.08f);
        //transform.eulerAngles = rb.velocity;
        float limitRotation = 3f-(rb.velocity.magnitude)/10;
        if (rb.velocity.magnitude < 1f)
        {
            limitRotation = 0;
        }
        if (Input.GetKey(KeyCode.A) &&rb.angularVelocity.magnitude < limitRotation)
        {// Smooth physics-based rotation
            rb.AddTorque(new Vector3(0, -0.8f, 0));
        }
        if (Input.GetKey(KeyCode.D)&& rb.angularVelocity.magnitude < limitRotation)
        {// Smooth physics-based rotation
            //Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, 2, 0));
            //rb.MoveRotation(rb.rotation * deltaRotation);
            rb.AddTorque(new Vector3(0, 0.8f, 0));
            //rb.AddForce(new Vector3(Mathf.Sin(Mathf.Deg2Rad * transform.eulerAngles.y), 0, Mathf.Cos(Mathf.Deg2Rad * transform.eulerAngles.y)));
        }
        rb.angularVelocity *= 0.98f;
        Debug.Log(rb.velocity.magnitude+" "+rb.angularVelocity.magnitude);
    }
}
