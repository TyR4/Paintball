using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public event Action<bool> OnPauseGame = delegate { };

    private bool _gamePaused;

    public void Start ()
	{
	    ToggleCursorLock(true);
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
            _gamePaused = false;
            ToggleCursorLock(_gamePaused);
        }
        else
        {
            Time.timeScale = 0f;
            _gamePaused = true;
            ToggleCursorLock(_gamePaused);
        }

        if (OnPauseGame != null)
            OnPauseGame(_gamePaused);
    }

    public void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private static void ToggleCursorLock(bool locked)
    {
        Cursor.visible = !locked;
        Cursor.lockState = locked == true 
            ? CursorLockMode.Locked 
            : CursorLockMode.None;
    }
}
