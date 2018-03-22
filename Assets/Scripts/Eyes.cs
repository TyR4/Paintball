using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour
{
    [SerializeField] private float _lookSpeed;

    private CameraInput _cameraInput;

    public void Start()
    {
        _cameraInput = GetComponent<CameraInput>();
    }
	
	// Update is called once per frame
	public void Update ()
	{
	    transform.eulerAngles += _cameraInput.Look * _lookSpeed;
	}
}
