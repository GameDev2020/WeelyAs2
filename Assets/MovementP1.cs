using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementP1 : MonoBehaviour
{        
    public float SidewaysForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            this.transform.Translate(new Vector3(SidewaysForce, 0f, 0f) * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            this.transform.Translate(new Vector3(-SidewaysForce, 0f, 0f) * Time.deltaTime);

    }
}
