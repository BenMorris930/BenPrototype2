using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] animals;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        index = Random.Range(0, animals.Length);
        if (Input.GetKeyDown(KeyCode.T))
        {
            Instantiate(animals[index], new Vector3(Random.Range(-12, 13), 0, Random.Range(22, 30)), animals[index].transform.rotation);
        }
    }
}
