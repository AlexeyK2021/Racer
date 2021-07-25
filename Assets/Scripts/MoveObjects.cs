using UnityEngine;
using Random = UnityEngine.Random;


public class MoveObjects : MonoBehaviour
{
    private float speed = 0;

    private void Start()
    {
        speed = Random.value * 3 + 3.5f;    //Создаем случайное число от 3,5 до 6,5
    }
    
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed); //Придаём движение машинке
        if (transform.position.y < -6f)
        {
            Destroy(gameObject); //Если машинка доехала до точки уничтожения, уничтожаем
        }
    }
}