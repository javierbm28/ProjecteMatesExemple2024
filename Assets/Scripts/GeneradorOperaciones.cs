using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorOperaciones : MonoBehaviour
{

    public GameObject _PrefabOperacions;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarOperacions", 1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerarOperacions()
    {

        GameObject numero = Instantiate(_PrefabOperacions);
        Vector2 CostatSuperiorDret = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        Vector2 CostatInferiorEsquerre = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        numero.transform.position = new Vector2(Random.Range(CostatInferiorEsquerre.x, CostatSuperiorDret.x), CostatSuperiorDret.y);




    }
}
