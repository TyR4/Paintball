using UnityEngine;
using UnityEngine.SceneManagement;

public class StartOnClick : MonoBehaviour
{
    public void StartGame(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}


