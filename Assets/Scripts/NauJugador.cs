using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NauJugador : MonoBehaviour
{

    //[SerializeField] private float _velNau;
    public float _velNau;

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

        Vector2 direccioIndicada = new Vector2(direccioHorizontal, direccioVertical).normalized;

        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        float anchura = spriteRenderer.bounds.size.x / 2;
        float altura = spriteRenderer.bounds.size.y / 2;

        float limitEsquerra = -Camera.main.orthographicSize * Camera.main.aspect + anchura;
        float limitDreta = Camera.main.orthographicSize * Camera.main.aspect - anchura;

        float limitSuperior = Camera.main.orthographicSize - altura;
        float limitInferior = -Camera.main.orthographicSize + altura;


        Vector2 novaPos = transform.position; //Ens retorna la posici� actual de la nau.
        novaPos += direccioIndicada * _velNau * Time.deltaTime;

        
        
        novaPos.x = Mathf.Clamp(novaPos.x, limitEsquerra, limitDreta);
        novaPos.y = Mathf.Clamp(novaPos.y, limitInferior, limitSuperior);

        if (Input.GetKeyDown(KeyCode.Space)) {

            shoot();


        }

        transform.position = novaPos;
    }

    private void shoot() {

        GameObject bala = Instantiate(Resources.Load("Prefabs/Bala") as GameObject);
        bala.transform.position = transform.position;

    }

}
