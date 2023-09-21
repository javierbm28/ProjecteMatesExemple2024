using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorNumeros : MonoBehaviour
{


    public GameObject _PrefabNumero;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarNumero", 1f,3f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void GenerarNumero() {

        GameObject numero = Instantiate(_PrefabNumero);
        Vector2 CostatSuperiorDret = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        Vector2 CostatInferiorEsquerre = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        numero.transform.position = new Vector2(Random.Range(CostatInferiorEsquerre.x, CostatSuperiorDret.x), CostatSuperiorDret.y);


    
    
    }
}
