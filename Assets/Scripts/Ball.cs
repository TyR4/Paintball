using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float shotVelocity = 3000f;
    private Rigidbody _rb;

	// Use this for initialization
	public void Start ()
	{
	    _rb = GetComponent<Rigidbody>();
        _rb.AddForce(transform.forward * shotVelocity);
	}
}
