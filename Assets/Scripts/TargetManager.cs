using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    [SerializeField] private GameController _gameController;
    [SerializeField] private List<TargetShape> _targets;

    private int _numTargets;

    public void Start()
    {
        foreach (var target in _targets)
            target.Initialize(this);
        _numTargets = _targets.Count;
    }

    public void HitTarget()
    {
        _numTargets--;
        CheckWinCondition();
    }

    private void CheckWinCondition()
    {
        if (_numTargets == 0)
            _gameController.EndGame();
    }
}
