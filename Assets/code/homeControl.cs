using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homeControl : MonoBehaviour
{
    public TextMeshProUGUI last,high;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetFloat("HIGH") == 0)
        {
            PlayerPrefs.SetFloat("HIGH", 1000000);
        }
        last.text = "Last record   " + (controlCar.times/60).ToString("F2");
        float a = PlayerPrefs.GetFloat("HIGH");
        if (a > controlCar.times)
        {
            PlayerPrefs.SetFloat("HIGH", controlCar.times);
        }
        high.text = "Highest record   " + (PlayerPrefs.GetFloat("HIGH")/60).ToString("F2");

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log((controlCar.times).ToString()+"   "+PlayerPrefs.GetFloat("HIGH"));
    }
    public void START()
    {
        SceneManager.LoadScene("raceSuccess");
    }
}
