using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NauJugador : MonoBehaviour
{

    //[SerializeField] private float _velNau;
    public float _velNau;
    public GameObject _PrefabExplosion;

    // Start is called before the first frame update
    void Start()
    {
        _velNau = 5f;
    }

    // Update is called once per frame
    void Update()
    {

        MovimentNau();

        DispararBala();
        
    }

    private void OnTriggerEnter2D(Collider2D ObjecteTocat)
    {
        /*Cuan la nau toqui algun objecte, automaoticament se llamara este metodo.
         El valor de Objetotocado, sera el objeto que hemos tocado */
        if (ObjecteTocat.tag == "Numero") {

            GameObject explosion = Instantiate(_PrefabExplosion);
            explosion.transform.position = transform.position;
            Destroy(gameObject);


        }
    }   
    private void MovimentNau()
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


        Vector2 novaPos = transform.position; //Ens retorna la posició actual de la nau.
        novaPos += direccioIndicada * _velNau * Time.deltaTime;



        novaPos.x = Mathf.Clamp(novaPos.x, limitEsquerra, limitDreta);
        novaPos.y = Mathf.Clamp(novaPos.y, limitInferior, limitSuperior);



        transform.position = novaPos;


    }

    private void DispararBala() {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            GameObject bala = Instantiate(Resources.Load("Prefabs/Bala") as GameObject);

            bala.transform.position = transform.position;


        }


    }

}
