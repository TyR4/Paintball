using System;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public event Action<bool> OnPauseGame = delegate {  };
    private bool _gamePaused;

    public void Start ()
	{
	    Cursor.lockState = CursorLockMode.Locked;
	    _gamePaused = false;
	}

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            PauseGame();
    }
    
    public void PauseGame()
    {
        if (_gamePaused)
        {
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            _gamePaused = false;
        }
        else
        {
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            _gamePaused = true;
        }

        if (OnPauseGame != null)
            OnPauseGame(_gamePaused);
    }

}
