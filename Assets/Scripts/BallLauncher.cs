using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour, IShoot
{
    [SerializeField] private GameController _gameController;
    [SerializeField] private Transform _ballSpawner;
    [SerializeField] private GameObject _ballPrefab;

    private bool _gamePaused;

    public void Awake()
    {
        _gameController.OnPauseGame += Pause;
    }
    
    public void Shoot(Launcher launcher)
    {
        if (!CanShoot()) return;
        var ball = Instantiate(_ballPrefab, _ballSpawner.position, _ballSpawner.rotation);
        Destroy(ball, 5f);
    }

    public void Pause(bool gamePaused)
    {
        _gamePaused = gamePaused;
    }

    public bool CanShoot()
    {
        return !_gamePaused;
    }

    public void OnDestroy()
    {
        _gameController.OnPauseGame -= Pause;
    }
}
