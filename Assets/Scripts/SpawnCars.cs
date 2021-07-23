using UnityEngine;
using System.Collections;

public class SpawnCars : MonoBehaviour
{
    public GameObject[] cars;
    private float[] positions = {-0.93f, -0.33f, 0.30f, 0.98f};

    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while (true)
        {
            Instantiate(
                cars[Random.Range(0, cars.Length)],
                new Vector3(positions[Random.Range(0, positions.Length)], 5f, 0),
                Quaternion.Euler(new Vector3(90, 180, 0))
            );
            yield return new WaitForSeconds(1.5f);
        }
    }


    // Update is called once per frame
    void Update()
    {
    }
}