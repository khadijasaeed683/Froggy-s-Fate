using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
   
    // Method to load a scene by name
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void LoadLevel1()
    {
        SceneManager.LoadSceneAsync("Level1");
    }
    public void CloseGame()
    {
        Application.Quit();
    }
   
}
