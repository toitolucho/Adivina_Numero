
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Controlador : MonoBehaviour
{
    int valorAzar;
    /// <summary>
    /// Numero maximo de intentos que puede relizar el jugador en el juego
    /// </summary>
    public int NroMaximoIntentos;
    /// <summary>
    /// El numero de intentos que ha intentando el jugador
    /// </summary>
    int NroIntentos;
    // Start is called before the first frame update

    public bool enJuego;

    GameObject fig1, fig2, fig3, fig4, fig5,fig6,fig7,fig8; //....etc fig8;
    //declaracion de objetos
    [SerializeField]
    AudioClip sonidoBien, sonidoError;

    AudioSource a;
    //int enJuego2;  //1 -> significa que esta en juego, y 0-> que no esta juego
    void Start()
    {
        
        


        generarNumero();
        print("Numero al azar          " + valorAzar);
        NroIntentos = 0;
        enJuego = true;

        fig1 = GameObject.Find("figura1");
        fig2 = GameObject.Find("figura2");
        fig3 = GameObject.Find("figura3");
        fig4 = GameObject.Find("figura4");
        fig5 = GameObject.Find("figura5");
        fig6 = GameObject.Find("figura6");
        fig7 = GameObject.Find("figura7");
        fig8 = GameObject.Find("figura8");

    }

    public void resaltar(int dato)
    {
        switch (dato)
        {
            case 1:
                fig1.GetComponent<Figura>().resaltar();
                break;
            case 2:
                fig2.GetComponent<Figura>().resaltar();
                break;
            case 3:
                fig3.GetComponent<Figura>().resaltar();
                break;
            case 4:
                fig4.GetComponent<Figura>().resaltar();
                break;
            case 5:
                fig5.GetComponent<Figura>().resaltar();
                break;
            case 6:
                fig6.GetComponent<Figura>().resaltar();
                break;
            case 7:
                fig7.GetComponent<Figura>().resaltar();
                break;
            case 8:
                fig8.GetComponent<Figura>().resaltar();
                break;
            

                //...
                //..
                //..



        }
    }

    public void deshabilitar(int numero)
    {
        switch (numero)
        {
            case 1:
                fig1.GetComponent<Figura>().deshabilitar();
                break;
            case 2:
                fig2.GetComponent<Figura>().deshabilitar();
                break;
            case 3:
                fig3.GetComponent<Figura>().deshabilitar();
                break;
            case 4:
                fig4.GetComponent<Figura>().deshabilitar();
                break;
            case 5:
                fig5.GetComponent<Figura>().deshabilitar();
                break;
            case 6:
                fig6.GetComponent<Figura>().deshabilitar();
                break;
            case 7:
                fig7.GetComponent<Figura>().deshabilitar();
                break;
            case 8:
                fig8.GetComponent<Figura>().deshabilitar();
                break;


        }
    }

    public void reproducirSonidoBien()
    {

    }
    public void reproducirSonidoMal()
    {

    }


    public void revisarIntento(int valorIntento)
    {
        NroIntentos++;
        //print("Presiono la tecla " + valorIntento);
        if (esCorrectoElNumero(valorIntento))
        {
            resaltar(valorIntento);
            reproducirSonidoBien();
            print("adivinaste");
            enJuego = false;
        }
        else
        {
            deshabilitar(valorIntento);
            reproducirSonidoMal();

            if (NroIntentos == NroMaximoIntentos)
            {
                print("PERDISTE");
                enJuego = false;
            }
            else
            {

                print("Intentalo nuevamente");


                //metodo permite buscar un objeto a partir de su nombre(el objeto debe estar en la escena
                //GameObject  ffigura = GameObject.Find("figura1");
                //if(ffigura != null)
                //{
                //     print(ffigura.name);
                //    //ffigura.saludar();
                //    //print(ffigura.transform.position.x);
                //    //SpriteRenderer renderizador =  ffigura.GetComponent<SpriteRenderer>()  ;
                //    //renderizador.color = Color.green;

                //    //BoxCollider2D collider =  ffigura.GetComponent<BoxCollider2D>();
                //    //collider.size = new Vector2(collider.size.x-1, collider.size.y-1);

                //    Figura figuraController =  ffigura.GetComponent<Figura>();
                //    //figuraController.saludar();
                //    figuraController.deshabilitar();

                //    figuraController.numero = 15;


                //}

                //  8           >   3
                if (valorIntento > valorAzar)
                {
                    print("El número es menor que " + valorIntento);
                }
                else
                {
                    print("El número es mayor que " + valorIntento);
                }
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (enJuego)
        {
            if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
            {
                revisarIntento(1);
            }
            if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
            {
                revisarIntento(2);

            }
            if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
            {
                revisarIntento(3);
            }
            if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
            {
                revisarIntento(4);
            }
            if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5))
            {
                revisarIntento(5);
            }
            if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6))
            {
                revisarIntento(6);
            }
            if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7))
            {
                revisarIntento(7);
            }
            if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8))
            {
                revisarIntento(8);
            }
        }
        //print("Hola Mundo");


    }

    public void generarNumero()
    {
        valorAzar = Random.Range(1, 8);
    }

    public bool esCorrectoElNumero(int valorPrueba)
    {
        bool esCorrecto = false;
        if (valorPrueba == valorAzar)
            esCorrecto = true;
        else
            esCorrecto = false;
        return esCorrecto;
    }




}
