using UnityEngine;
using System.Collections;

public class SpawnCars : MonoBehaviour
{
    public GameObject[] cars;//Массив с образцами встречных машин
    private float[] positions = {-0.93f, -0.33f, 0.30f, 0.98f};     //Координаты точек появления встречных машин

    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while (true)  //генерируем машинки на координатах из массива
        {
            Instantiate(
                cars[Random.Range(0, cars.Length)],
                new Vector3(positions[Random.Range(0, positions.Length)], 5f, 0),
                Quaternion.Euler(new Vector3(90, 180, 0))
            );
            yield return new WaitForSeconds(1.5f);  //Делаем задержку для комфортной игры
        }
    }
}