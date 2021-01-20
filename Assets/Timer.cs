using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeStart = 20.0f;

    public TMP_Text textBox;

    public static string playerUserName;

    public static float playerTime;
    void Start()
    {
        textBox.text = "";
        enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        playerTime = timeStart;
        Debug.Log(playerTime);
        timeStart -= Time.deltaTime;
        textBox.text = timeStart.ToString("F2");
        if (timeStart <= 0.0f)
            timeRanOut();
        
    }

    void timeRanOut()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        SceneManager.LoadScene("TimerRanOut");
    }

    
}
