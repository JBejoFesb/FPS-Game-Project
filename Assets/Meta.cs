using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Meta : MonoBehaviour
{
    public float hp = 10.0f;

  

    public void Hit(float vrijednostStete)
    {
        AddTime();
        hp -= vrijednostStete;
        if(hp<=0.0f)
        {
            
            UnistiMetu();
        }
    }

    void UnistiMetu()
    {
        Destroy(gameObject);
    }

    void AddTime()
    {
        //pronalazi game object koji sadrzi scriptu timer i dodaje sekunde
        GameObject.Find("TimeTrigger").GetComponent<Timer>().timeStart += 0.5f;
    }

}
