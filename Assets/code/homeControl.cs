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

    }
    public void reset()
    {

        PlayerPrefs.SetInt("HIGH", 100000000);
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log((controlCar.times).ToString()+"   "+PlayerPrefs.GetInt("HIGH"));

        if (!PlayerPrefs.HasKey("HIGH") || PlayerPrefs.GetInt("HIGH")==0)
        {

            reset();
        }
        last.text = "Last record   " + (controlCar.times / 60).ToString() + "." + ((controlCar.times * 100 / 60) % 60).ToString();
        float a = PlayerPrefs.GetInt("HIGH");
        if (a > controlCar.times)
        {
            PlayerPrefs.SetInt("HIGH", controlCar.times);
        }
        high.text = "Highest record   " + (PlayerPrefs.GetInt("HIGH") / 60).ToString() + "." + ((PlayerPrefs.GetInt("HIGH") * 100 / 60) % 60).ToString();
    }
    public void START()
    {
        SceneManager.LoadScene("raceSuccess");
    }
}
