using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NauJugador : MonoBehaviour
{

    [SerializeField] private float _velNau;

    // Start is called before the first frame update
    void Start()
    {
        _velNau = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        float direccioHorizontal = Input.GetAxisRaw("Horizontal");
        float direccioVertical = Input.GetAxisRaw("Vertical");
        //Debug.Log(direccioHorizontal);

        Vector2 direccioIndicada = new Vector2(direccioHorizontal, direccioVertical);
        
        Vector2 novaPos = transform.position; //Ens retorna la posició actual de la nau.

        novaPos += direccioIndicada * _velNau * Time.deltaTime;

        transform.position = novaPos;
    }
}
