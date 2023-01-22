using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class CameraStuff : MonoBehaviour
{
    public float timeLeft = 10.0f;
    public float commandTime = 2.0f;
    public GameObject VictoryObject;
    public GameObject FailureObject;
    public TextMeshProUGUI Timey;
    public TextMeshProUGUI Command;

    void Start()
    {
    FailureObject.SetActive(false);
    VictoryObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
               timeLeft -= Time.deltaTime;
        Timey.text = (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
          FailureObject.SetActive(true);
        }
         commandTime -= Time.deltaTime;
        Command.text = (commandTime).ToString("0");
        if (commandTime > 0)
        {
          Command.text = "Collect Apples!";
        }
        if (commandTime < 0)
        {
          Command.text = "";
        }
    }
}
