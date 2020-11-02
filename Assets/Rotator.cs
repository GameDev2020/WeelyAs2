using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Tooltip("Defines around which Axis the rotation should accour, Input is in Degrees per second")]
    public Vector3 Rotation=new Vector3(0f,0f,3f);    
   
    void Update()
    {
        this.transform.Rotate(Rotation);
    }
}
