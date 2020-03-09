using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] animals;
    public float spawnTime = 2;
    int index;
    float count = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimals", 0f, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        /*count += Time.deltaTime;
        if (count > spawnTime)
        {
            SpawnAnimals();
            count = 0;
        }*/
    }

    void SpawnAnimals()
    {
        index = Random.Range(0, animals.Length);
        Instantiate(animals[index], new Vector3(Random.Range(-12, 13), 0, Random.Range(22, 30)), animals[index].transform.rotation);
    }
}
