using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private readonly float _shotVelocity = 3000f;
    private Rigidbody _rb;
    
	public void Start ()
	{
	    _rb = GetComponent<Rigidbody>();
        _rb.AddForce(transform.forward * _shotVelocity);
	}
}
