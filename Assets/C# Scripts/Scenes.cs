using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void ChangeScenes(int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);
    }
    
    public void NextLevel()
    {
        Time.timeScale = 1f;
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void Menu(int numberMenu)
    {
        SceneManager.LoadScene(numberMenu);
        Time.timeScale = 1f;
    }
    
    public void Exit()
    {
        Application.Quit();
    }
}
