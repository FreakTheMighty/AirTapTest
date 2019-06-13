using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImAwake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateCube()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = Camera.main.transform.position + (Camera.main.transform.forward * 8);
        cube.transform.rotation = Random.rotation;
        Destroy(cube, 3);
    }
}
