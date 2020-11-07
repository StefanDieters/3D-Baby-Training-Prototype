using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alwaysRotate : MonoBehaviour
{
    public int turnSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime, Space.World);
    }
}
