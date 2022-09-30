using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    public GameObject sphere;
    public int skor;
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            skor += 10;

            if (skor >= 100)
            {
                ColorChange();
            }
        }

     //Klavyeden space tuşuna basarak skoru 10 10 artır skor 100 gelince ChangeColor metodunu çalıştır.
    }


    void ColorChange()
    {
        GameObject.Find("Sphere").GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0);
        //Kod açıklama:Shepere adlı gameobject bul.Sphere'nin meshrenderer ulaş ve material.color kısmına yeni renk ata.
    }
}
