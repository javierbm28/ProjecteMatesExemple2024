using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestrueixObjete",2f);

    }

    private void DestrueixObjete() { 
    
        Destroy(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
