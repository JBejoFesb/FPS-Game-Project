using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    //registrira kameru
    public Transform kamera = null;
    public float osjetljivostMisa = 0.6f;

    float nagibKamere = 0.0f;



    // Start is called before the first frame update
    void Start()
    {
        //Sakriva mis i ne dopusta mu prijelaz iz ekrana odnosno zakljucava ga na sredinu
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Sprema input iz misa u vektor
        if(!MainPauseMenu.IsGamePaused)
        {


            Vector2 pomakMisa = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            //Iduce 3 linije se brinu da se pogled mice gore i dole te ima limitiran okret
            nagibKamere -= pomakMisa.y * osjetljivostMisa;

            nagibKamere = Mathf.Clamp(nagibKamere, -90.0f, 90.0f);

            kamera.localEulerAngles = Vector3.right * nagibKamere;

            //rotira samog igraca zajedno sa kamerom
            transform.Rotate(Vector3.up * pomakMisa.x * osjetljivostMisa);
        }

    }

    public void ChangeMouseSens(float newSens)
    {
        osjetljivostMisa = newSens;
    }
}
