using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System;

public class GlavniMeni : MonoBehaviour
{
    public TMP_InputField username;

    public TMP_Text[] data;

    public GameObject[] list;

    void Start()
    {

        string path = Application.dataPath + "/Run&Gun.txt";
        StreamReader reader = new StreamReader(path);
        for(int i=0;i<5;i++)
        {
            
            data[i].text = reader.ReadLine();
            Debug.Log(data[i].text);
            list[i].SetActive(true);
        }
    }

    public void PlayGame()
    {
        Timer.playerUserName = username.text;
        Debug.Log(Timer.playerUserName);
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

}
