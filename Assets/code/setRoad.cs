using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setRoad : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        for (float i = 0; i < 100; i += 0.05f)
        {
            GameObject cubeCopy = Instantiate(cube);
            cubeCopy.transform.position = new Vector3(i, 0.5f, Mathf.Sin(i / 8) * 50-20);
        }
        for (float i = 0; i < 100; i += 0.05f)
        {
            GameObject cubeCopy = Instantiate(cube);
            cubeCopy.transform.position = new Vector3(i, 0.5f, Mathf.Sin(i / 8) * 50+20);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
