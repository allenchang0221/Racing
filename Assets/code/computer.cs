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
    int a = 0;
    // Update is called once per frame
    void Update()
    {
        a += 1;
        for (int i = 0; i < 100; i++)
        {
            if (a > 60)
            {
                transform.position = new Vector3(i, 0, Mathf.Sin(i / 8) * 10);
                a = 0;
            }
        }
    }
}
