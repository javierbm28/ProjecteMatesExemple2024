using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operacio : MonoBehaviour
{

    private float _vel;
    private int valorOperacion;
    public Sprite[] _SpriteOperacions = new Sprite[4];
    // Start is called before the first frame update
    void Start()
    {
        _vel = 2f;

        //Cargar una imagen de numero aleatorio 
        System.Random aleatori = new System.Random();
        valorOperacion = aleatori.Next(0, 4); // Aleatorio entre 0 i 3 
        //Accedemos al Sprite Renderer y dentro de este el atributo Sprite
        gameObject.GetComponent<SpriteRenderer>().sprite = _SpriteOperacions[valorOperacion];
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
        if (objecteTocat.tag == "Bala" || objecteTocat.tag == "NauJugador")
        {

            Destroy(gameObject);

        }
    }

    private void DestrueixSiSurtFort()
    {
        Vector2 costatInferiorEsquerra = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        if (transform.position.y <= costatInferiorEsquerra.y)
        {

            Destroy(gameObject);

        }


    }
}
