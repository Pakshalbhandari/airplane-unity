using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropleelor : MonoBehaviour
{
    // Start is called before the first frame update
    private float propellorSpeed = 1800;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, propellorSpeed * Time.deltaTime);
    }
}
