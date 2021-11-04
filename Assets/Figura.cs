using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figura : MonoBehaviour
{
    //atributos
    public int numero; //1,2,3,4,5,6,7,8,9
    public Controlador manejador;
    bool estado;   //1 habilitado, 0 deshabilitado
    [SerializeField]
    Sprite estadoDeshabilitado;
    [SerializeField]
    Sprite estadoResaltado;

    // Start is called before the first frame update
    void Start()
    {
        //debuguear -> ver valores 
        estado = true;
    }

    // Update is called once per frame
    void Update()
    {
        //print(numero);

        if (Input.GetKeyDown(KeyCode.Space))
            print(numero);
    }

    //public void OnCollisionEnter2D(Collision2D collision)
    //{

    //   // print("hiciste click");
    //}

    public void OnMouseDown()
    { 
        
        if(manejador.enJuego && estado == true)
        {
            manejador.revisarIntento(numero);
        }
        

    }

    public void saludar()
    {
        print("Hola soy la figura "+ numero);
    }

    public void deshabilitar()
    {
        estado = false;
        SpriteRenderer render = GetComponent<SpriteRenderer>();
        render.sprite = estadoDeshabilitado;
    }

    public void resaltar()
    {
        SpriteRenderer render = GetComponent<SpriteRenderer>();
        render.sprite = estadoResaltado;
    }
}
