using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This script makes a certain object smaller or bigger in a heart-beat fashion  
 **/
public class HeartBeatScaler : MonoBehaviour
{
    [Tooltip("Defines max scale of the ball or the object")]
    public Vector3 maxScale=new Vector3(2f,2f,2f);
    [Tooltip("Defines minimum scale of the ball or the object")]
    public Vector3 minScale=new Vector3(1f,1f,1f);
    [Tooltip("Defines how fast the ball or object grows or getting smaller")]
    public Vector3 ScaleFactor=new Vector3(0.5f,0.5f,0.5f);
    bool makeLarger=true;        
    void Update()
    {
        
        if(this.transform.localScale.x<maxScale.x && this.transform.localScale.y < maxScale.y && makeLarger)
        {
            this.transform.localScale = this.transform.localScale + ScaleFactor * Time.deltaTime;            
        }

        if (this.transform.localScale.x >= maxScale.x && this.transform.localScale.y >= maxScale.y) makeLarger = false;

        if (this.transform.localScale.x >= minScale.x && this.transform.localScale.y >= minScale.y && !makeLarger)
        {
            this.transform.localScale = this.transform.localScale - ScaleFactor * Time.deltaTime;

        }
        if (this.transform.localScale.x <= minScale.x && this.transform.localScale.y <= minScale.y) makeLarger = true;


    }
}
