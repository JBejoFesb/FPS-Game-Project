using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class Victory : MonoBehaviour
{
    
    public TMP_Text textBox;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    void Update()
    {
        string ime = Timer.playerUserName;
        float vrijeme = Timer.playerTime;
        Debug.Log(ime);
        Debug.Log(vrijeme);
        textBox.text = ime+" got to the end with "+vrijeme+" seconds left";
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void TryAgain()
    {
        SceneManager.LoadScene("Game");
    }
}
