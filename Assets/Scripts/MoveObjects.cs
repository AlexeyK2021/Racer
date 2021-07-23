using System;
using UnityEngine;
using Random = UnityEngine.Random;


public class MoveObjects : MonoBehaviour
{
    private float speed = 0;

    private void Start()
    {
        speed = Random.value * 3 + 3.5f;
    }
    
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}