using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController kontroler;

    public float brzina = 12f;
    public float gravitacija = -9.81f;
    public float visinaSkoka = 3f;

    public Transform provjeraPodloge;
    public float radijusPodloge = 0.4f;
    public LayerMask maskPodloge;

    Vector3 trenutnaBrzina;

    bool podloga;

    // Update is called once per frame
    void Update()
    {
        //provjera poda
        podloga = Physics.CheckSphere(provjeraPodloge.position, radijusPodloge, maskPodloge);

        if (podloga && trenutnaBrzina.y < 0)
            trenutnaBrzina.y = -2f;

        //input preko pre definiranih funkcija
        if (!MainPauseMenu.IsGamePaused)
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            //vektor kordinata
            Vector3 kretanje = transform.right * x + transform.forward * z;
            //kretanje koje je osigurano da se ne ubrzava sa vecim frameratom
            kontroler.Move(kretanje * brzina * Time.deltaTime);
        }
            

        //skakanje
        if(!MainPauseMenu.IsGamePaused)
            if (Input.GetButtonDown("Jump") && podloga)
            {
                trenutnaBrzina.y = Mathf.Sqrt(visinaSkoka * -2f * gravitacija);
            }


        //gravitacija
        trenutnaBrzina.y += gravitacija * Time.deltaTime;

        kontroler.Move(trenutnaBrzina * Time.deltaTime);
    }
}
