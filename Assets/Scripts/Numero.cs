using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numero : MonoBehaviour
{

    private float _vel;
    // Start is called before the first frame update
    void Start()
    {
        _vel = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 novaPos = transform.position;
        novaPos.y = novaPos.y - _vel * Time.deltaTime;
        transform.position = novaPos;
        DestrueixSiSurtFort();
        /*
        float limitInferior = -Camera.main.orthographicSize;

        if (novaPos.y <= limitInferior)
        {

            Destroy(gameObject);
        }
        */
    }

    private void DestrueixSiSurtFort(){
        Vector2 costatInferiorEsquerra = Camera.main.ViewportToWorldPoint(new Vector2(0,0));
        if (transform.position.y <= costatInferiorEsquerra.y) {

            Destroy(gameObject);

        }


    }
}
