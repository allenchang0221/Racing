using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            //cubeCopy.transform.position = new Vector3(i,0.5f,Mathf.Abs(i-50)+5-50);
        }
        for (float i = 0; i < 100; i += 0.05f)
        {
            GameObject cubeCopy = Instantiate(cube);
            cubeCopy.transform.position = new Vector3(i, 0.5f, Mathf.Sin(i / 8) * 50+20);
            //cubeCopy.transform.position = new Vector3(i, 0.5f, Mathf.Abs(i - 50) - 5-50);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
