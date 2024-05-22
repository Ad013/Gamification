using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    int x = 4;
    public void loadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
	public void PlayBank()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }
    public void PlayStocks()
    {
        SceneManager.LoadScene("Stocks01");
        Time.timeScale = 1f;
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
