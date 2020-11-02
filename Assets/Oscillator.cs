using UnityEngine;

public class Oscillator : MonoBehaviour
{
    
    [SerializeField]
    float frequency = 20f;
    [SerializeField]
    float length = 0.5f;
    Vector3 location;

    // Use this for initialization
    void Start()
    {

        location = transform.position;       

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = location + transform.right * Mathf.Sin(Time.time * frequency) * length;        
    }

}
