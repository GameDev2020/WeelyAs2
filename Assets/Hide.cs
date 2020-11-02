using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    public GameObject Ball; // GameObject Representing the ball
    bool RendererState = true; // checks if the object renderer is working or not

    void Update()
    {             
        if ((Input.GetKeyDown(KeyCode.H) || Input.GetMouseButtonDown(0)) && RendererState) //if h is pressed (I for Hide) and the rendered works
        {
            Ball.GetComponent<Renderer>().enabled = false; //disable renderer
            RendererState = false; //set object renderer to false
        }
        else if ((Input.GetKeyDown(KeyCode.H) || Input.GetMouseButtonDown(0)) && !RendererState) //if h is pressed (I for Hide) and the rendered doesnt work
        {
            Ball.GetComponent<Renderer>().enabled = true; //enable renderer
            RendererState = true; //set object renderer to true
        }

    }
}
