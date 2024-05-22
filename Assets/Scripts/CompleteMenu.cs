using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteMenu : MonoBehaviour {

	public void loadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        SceneManager.LoadScene("Level02");
    }
}
