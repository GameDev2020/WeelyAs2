using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector2 MovementSpeed=new Vector2(25f,25f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float inputX = Input.GetAxis("Horizontal");        
        Vector3 movement = new Vector3(MovementSpeed.x * inputX, 0, 0);
        movement *= Time.deltaTime;
        transform.Translate(movement);

    }
}
