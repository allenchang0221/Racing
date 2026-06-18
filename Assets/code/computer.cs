using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class computer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }
    float a = 0;
    float i = 0;
    // Update is called once per frame
    void Update()
    {
        a += 0.1f;

        //if (a > 60)
        //{
        transform.position = new Vector3(i, 0.5f, Mathf.Sin(i / 8) * 50);
        a = 0;
        i += 0.048f;
        //}

    }
}
