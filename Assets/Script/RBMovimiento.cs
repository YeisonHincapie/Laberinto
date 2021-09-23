using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBMovimiento : MonoBehaviour
{
    //movimineto camara 1
    private float _movimientoHorizontal;
    private float _movimientoVertical;
    public float speed = 1f;

    public Renderer colorFloor;
    public GameObject enemy;
    public GameObject nivelsecreto;
    public GameObject puertasecreta;
    public int vidaplayer = 100;
    public GameObject vida;
    public GameObject vidas0;
    public GameObject vidas;
    public GameObject vida2;
    public GameObject vidas2;
    public GameObject vida3;
    public GameObject vidas3;
    public GameObject vida4;
    public GameObject vidas4;
    public GameObject vidas5;
    public GameObject vidas6;
    public GameObject vidas7;
    public GameObject vidas8;
    public GameObject vidas9;
    public GameObject gameover1;
    public GameObject gameover2;
    public GameObject player;
    public GameObject ganar;
    public GameObject estrella;

    public GameObject camara1;
    public GameObject camara2;
    public GameObject camara3;
    public GameObject sensor;


    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _movimientoHorizontal = Input.GetAxis("Horizontal");
        _movimientoVertical = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(_movimientoHorizontal, 0, _movimientoVertical) * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        /////////////Enemigos/////////////
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //colorFloor.material.color = Color.red;

            if (vidas4.activeSelf == true)
            {
                vidas4.SetActive(false);
                vidas9.SetActive(false);
            }
            else
            {
                if (vidas3.activeSelf == true)
                {
                    vidas3.SetActive(false);
                    vidas8.SetActive(false);
                }
                else
                {
                    if (vidas2.activeSelf == true)
                    {
                        vidas2.SetActive(false);
                        vidas7.SetActive(false);
                    }
                    else
                    {
                        if (vidas.activeSelf == true)
                        {
                            vidas.SetActive(false);
                            vidas6.SetActive(false);
                        }
                        else
                        {
                            
                            vidas0.SetActive(false);
                            vidas5.SetActive(false);
                            gameover1.SetActive(true);
                            gameover2.SetActive(true);
                            player.SetActive(false);
                        }
                    }
                }
            }
        }

        //////////vida del jugador /////////////
        if (collision.gameObject.CompareTag("vida"))
        {
            vida.SetActive(false);
            if (vidas0.activeSelf == true)
            {
                vidas.SetActive(true);
                vidas6.SetActive(true);
            }
            else
            {
                vidas0.SetActive(true);
                vidas5.SetActive(true);
            }
        }
        if (collision.gameObject.CompareTag("vida2"))
        {
            vida2.SetActive(false);
            if (vidas.activeSelf == true)
            {
                vidas2.SetActive(true);
                vidas7.SetActive(true);
            }
            else
            {
                vidas.SetActive(true);
                vidas6.SetActive(true);
            }
        }
        if (collision.gameObject.CompareTag("vida3"))
        {
            vida3.SetActive(false);
            if (vidas2.activeSelf == true)
            {
                vidas3.SetActive(true);
                vidas8.SetActive(true);
            }
            else
            {
                if (vidas.activeSelf == true)
                {
                    vidas2.SetActive(true);
                    vidas7.SetActive(true);
                }
                else
                {
                    vidas.SetActive(true);
                    vidas6.SetActive(true);
                }
            }
        }
    
        if (collision.gameObject.CompareTag("vida4"))
        {
            vida4.SetActive(false);
            if (vidas3.activeSelf == true)
            {
                vidas4.SetActive(true);
                vidas9.SetActive(true);
            }
            else
            {
                if (vidas2.activeSelf == true)
                {
                    vidas3.SetActive(true);
                    vidas8.SetActive(true);
                }
                else
                {
                    if (vidas.activeSelf == true)
                    {
                        vidas2.SetActive(true);
                        vidas7.SetActive(true);
                    }
                    else
                    {
                        vidas.SetActive(true);
                        vidas6.SetActive(true);
                    }
                }
            }
        }


        ///////////nivel secreto/////////////
        if (collision.gameObject.CompareTag("puertasecreta"))
        {
            nivelsecreto.SetActive(true);
            puertasecreta.SetActive(false);
            camara1.SetActive(false);
            camara2.SetActive(true);

        }

        ///////////ganar juego/////////////
        if (collision.gameObject.CompareTag("ganar"))
        {
            ganar.SetActive(true);
            estrella.SetActive(false);
            player.SetActive(false);
        }
        ///////////girar player/////////////
        if (collision.gameObject.CompareTag("sensor"))
        {
            sensor.SetActive(false);
            camara2.SetActive(false);
            camara3.SetActive(true);
        }
    }

}
