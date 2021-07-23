using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 3.0f;

    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        Vector3 dir = new Vector3(hor, 0, 0);
        transform.Translate(dir.normalized * Time.deltaTime * Speed);

        if (transform.position.x < -1.8f)
        {
            Vector3 spawn = new Vector3(3f, Vector3.forward.y, Vector3.forward.y);
            transform.Translate(spawn * Time.deltaTime);
        }
        else if (transform.position.x > 1.8f)
        {
            Vector3 spawn = new Vector3(-3f, Vector3.forward.y, Vector3.forward.y);
            transform.Translate(spawn * Time.deltaTime);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car")) //Для машин
        {
            Destroy(gameObject);
        }
    }
}