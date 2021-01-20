using UnityEngine;

public class Pistolj : MonoBehaviour
{
    public float steta = 10.0f;
    public float domet = 100.0f;

    public Camera fpsKamera;

    // Update is called once per frame
    void Update()
    {
        if(!MainPauseMenu.IsGamePaused)
            if (Input.GetButtonDown("Fire1"))
            {
                Pucanje();
            }

    }

    void Pucanje()
    {
        RaycastHit Pogodak;
        //Stvara zraku od trenutne pozicije kamere do trenutne tocke gdje kamera gleda, zatim vraca informaciju o pogotku
        if(Physics.Raycast(fpsKamera.transform.position, fpsKamera.transform.forward, out Pogodak, domet))
        {
            Debug.Log(Pogodak.transform.name);

            Meta meta = Pogodak.transform.GetComponent<Meta>();
            if(meta!=null)
            {
                meta.Hit(steta);
            }
        }

    }
}
