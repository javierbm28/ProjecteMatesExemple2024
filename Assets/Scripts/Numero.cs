using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class Numero : MonoBehaviour
{

    private float _vel;
    private int valorNumero;
    public Sprite[] _SpriteNumeros = new Sprite[10];
    // Start is called before the first frame update
    void Start()
    {
        _vel = 2f;

        //Cargar una imagen de numero aleatorio 
        System.Random aleatori = new System.Random();
        valorNumero = aleatori.Next(0,10); // Aleatorio entre 0 i 9 
        //Accedemos al Sprite Renderer y dentro de este el atributo Sprite
        gameObject.GetComponent<SpriteRenderer>().sprite = _SpriteNumeros[valorNumero];
        

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 novaPos = transform.position;
        novaPos.y = novaPos.y - _vel * Time.deltaTime;
        transform.position = novaPos;
        DestrueixSiSurtFort();

    }

    private void OnTriggerEnter2D(Collider2D objecteTocat)
    {
       if (objecteTocat.tag == "Bala" || objecteTocat.tag == "NauJugador") { 
        
            Destroy(gameObject);

        }
    }

    private void DestrueixSiSurtFort(){
        Vector2 costatInferiorEsquerra = Camera.main.ViewportToWorldPoint(new Vector2(0,0));
        if (transform.position.y <= costatInferiorEsquerra.y) {

            Destroy(gameObject);

        }


    }
}
