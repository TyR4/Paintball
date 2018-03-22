using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Vector3 Rotate { get; private set; }
    public Vector3 Move { get; private set; }

    public void Update()
    {
        var deltaTime = Time.deltaTime;
        Rotate = new Vector3(0f, Input.GetAxis("Mouse X"), 0f) * deltaTime;
        Move = new Vector3(Input.GetAxisRaw("Horizontal"), Physics.gravity.y, Input.GetAxisRaw("Vertical")) * deltaTime;
    }
}

