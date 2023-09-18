using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class Bala : MonoBehaviour
{

    public float velocity = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 novaPos = transform.position;
        novaPos.y += velocity * Time.deltaTime;
        transform.position = novaPos;

        float limitSuperior = Camera.main.orthographicSize;

        if (novaPos.y >= limitSuperior) {

            Destroy(gameObject);
        }

    }
}
