using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float h_input;
    public float move_constraint = 15;
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h_input = Input.GetAxis("Horizontal");
        transform.Translate(speed * Time.deltaTime * h_input, 0, 0);
        if (transform.position.x > move_constraint) transform.position = new Vector3(move_constraint, 0, 0);
        if (transform.position.x < -move_constraint) transform.position = new Vector3(-move_constraint, 0, 0);
    }
}
