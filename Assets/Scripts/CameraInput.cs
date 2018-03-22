using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInput : MonoBehaviour
{

    public Vector3 Look { get; private set; }
    
    public void Update()
    {
        Look = new Vector3(-Input.GetAxisRaw("Mouse Y"), 0f, 0f) * Time.deltaTime;
    }

}
