using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxMove : MonoBehaviour
{
    public float speed = 3;
    public float foxBound = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.x > foxBound) transform.rotation = Quaternion.Euler(0, 270, 0);
        if (transform.position.x < -foxBound) transform.rotation = Quaternion.Euler(0, 90, 0);
    }
}
