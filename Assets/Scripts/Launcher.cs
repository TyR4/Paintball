using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    private IShoot _launcher;

    public void Start()
    {
        _launcher = GetComponent<IShoot>();
    }

    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            _launcher.Shoot(this);
    }
}
