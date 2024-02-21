using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class AttackingCock : MonoBehaviour
{

    public GameObject Kecoanya;

    public float Delay;

    public float DelayCurrent;

    public bool BisaMukul;

    public bool DelayMukul;

    public bool Kena;

    public GameObject Raket;

    private Vector2 consoleCursorPosition;

    public int Skor;

    public int BanyakMukul;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(BisaMukul)
        {
            if (Input.GetMouseButtonDown(0))
            {
                BisaMukul = false;
                DelayMukul = true;
                if (Kecoanya != null)
                {
                    Destroy(Kecoanya);
                    Skor += 100;
                    Debug.LogFormat("{0} {1}", "Skornya adalah :", Skor);
                } else
                {

                    Skor -= 100;
                    Debug.LogFormat("{0} {1}", "Skornya adalah :", Skor);
                    BanyakMukul++;
                    Debug.LogFormat("{0} {1}", "Jumlah Pukulan Miss adalah :", BanyakMukul);
                }
                Raket.SetActive(true);
                
            }
           
        }
        else
        {
            Raket.SetActive(false);
        }


        if (DelayMukul)
        {
            if (DelayCurrent < 0)
            {
                BisaMukul = true;
                DelayCurrent = Delay;
                DelayMukul = false;
            }
            else
            {
                DelayCurrent -= Time.deltaTime;
            }
        }


        //UpdateStatus();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Kena = true;

        if(collision.gameObject.tag == "Kecoa")
        {
            Kecoanya = collision.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Kecoanya = null;
    }

}
