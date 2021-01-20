using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class EndTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        string username = Timer.playerUserName;
        float time = Timer.playerTime;
        Debug.Log(time);
        Debug.Log(username);
        string path = Application.dataPath + "/Run&Gun.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, time + " " + username + "\n");

        }
        else
            File.AppendAllText(path, time + " " + username + "\n");

        var contents = File.ReadAllLines(path);
        Array.Sort(contents);
        Array.Reverse(contents);
        File.WriteAllLines(path, contents);

        
        SceneManager.LoadScene("Victory");
    }
}   
  
