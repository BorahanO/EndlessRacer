using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;

public class Menu : MonoBehaviour {

	// Use this for initialization
	public void PlayGame (int level)
    {
        Application.LoadLevel(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void ReturnMenu()
    {
        Application.LoadLevel(0);
    }
}

