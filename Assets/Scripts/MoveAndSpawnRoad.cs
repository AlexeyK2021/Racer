using UnityEditor;
using UnityEngine;

public class MoveAndSpawnRoad : MonoBehaviour
{
    private float speed = 3.0f;

    public GameObject road;

    void FixedUpdate()
    {
        Vector3 direction = new Vector3(0, -1f, 0f);
        transform.Translate(direction * Time.deltaTime * speed); //Движение дороги
        
        if (transform.position.y < -6.3f)
        {
            //EditorApplication.isPaused = true; // установка паузы
            Instantiate(road, new Vector3(0.0f, 6.20f, 0.0f), Quaternion.identity); //Создание дороги в начале
            Destroy(gameObject); //Удаление дороги
        }
    }
}