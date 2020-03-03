using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMove : MonoBehaviour
{
    public GameObject animal;
    public float speed = 3;
    public int hp = 1;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if(transform.position.z < -5)
        {
            transform.position = new Vector3(Random.Range(-12, 13), 0, Random.Range(20, 25));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        count++;
        if (count >= hp)
        {
            transform.position = new Vector3(Random.Range(-12, 13), 0, Random.Range(30, 38));
            count = 0;
        }
    }
}
