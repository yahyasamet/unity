using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teddy : MonoBehaviour
{
    public int rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.Euler(Vector3.up * Time.deltaTime * rotationSpeed);
    }
}
