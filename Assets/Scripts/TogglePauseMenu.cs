using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePauseMenu : MonoBehaviour
{

    [SerializeField] private GameController _gameController;

    [SerializeField] private Transform _pauseMenu;

    public void Awake()
    {
        _gameController.OnPauseGame += Toggle;

    }

    public void Toggle(bool gamePaused)
    {
        _pauseMenu.gameObject.SetActive(_pauseMenu.gameObject.activeInHierarchy == false);
        
    }

    public void OnDestroy()
    {
        _gameController.OnPauseGame -= Toggle;
    }
}
