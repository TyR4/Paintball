using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetShape : MonoBehaviour
{
    public bool Hit { get; private set; }

    private Renderer _rend;
    private TargetManager _targetManager;
    private bool _hit;

    public void Start()
    {
        _rend = GetComponent<MeshRenderer>();
        _rend.material.color = Color.yellow;
        Hit = false;
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "PaintBall" || Hit) return;
        _rend.material.color = Color.green;
        Hit = true;
        _targetManager.HitTarget();
    }

    public void Initialize(TargetManager targetManager)
    {
        _targetManager = targetManager;
    }
}