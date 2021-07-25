using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 3.0f;

    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");                               //Получаем значение нажатой клавиши от Unity
        Vector3 dir = new Vector3(hor, 0, 0);                               //Задаём вектор движения машины
        transform.Translate(dir.normalized * Time.deltaTime * Speed);    //Двигаем машинку

        if (transform.position.x < -1.8f)       //-1.8 — это точка, за которую машинка не должна заезжать(обочина слева)
        {
            Vector3 spawn = new Vector3(3f, Vector3.forward.y, Vector3.forward.y);  //Отталкаваем машину от этой точки
            transform.Translate(spawn * Time.deltaTime);
        }
        else if (transform.position.x > 1.8f)   //1.8 — это точка, за которую машинка не должна заезжать(обочина справа)
        {
            Vector3 spawn = new Vector3(-3f, Vector3.forward.y, Vector3.forward.y);
            transform.Translate(spawn * Time.deltaTime);                        //Отталкаваем машину от этой точки
        }
    }

    private void OnCollisionStay(Collision collision)   //Здесь мы проверяем столкновение машинки пользователя
    {                                                   //и встречных машинок
        if (collision.gameObject.CompareTag("Car")) 
        {
            Destroy(gameObject);                    //Уничтожаем машинку пользователя
        }
    }
}