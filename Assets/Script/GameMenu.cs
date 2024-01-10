using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenu;
    private bool PauseMenuActive;
    public void ResumeGame() 
    {
        if (Input.GetKeyDown(KeyCode.Escape) && PauseMenuActive == false) 
        {
            PauseMenu.SetActive(true);
            PauseMenuActive = true;
            
        }

        if (Input.GetKeyDown(KeyCode.Escape) && PauseMenuActive == true)
        {
            PauseMenu.SetActive(false);
            PauseMenuActive = false;

        }
    }


    public void RestartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
