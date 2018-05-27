using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;				

public class MainMenu : MonoBehaviour {

	public void PlayGame()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);

	}

    public void PlayGame1()
    {
        SceneManager.LoadScene(2);

    }

    public void PlayGame2()
    {
        SceneManager.LoadScene(3);

    }
    public void PlayGame3()
    {
        SceneManager.LoadScene(4);

    }

    public void ExitGame()
	{
		Debug.Log ("Quit");
		Application.Quit ();
	}

}
