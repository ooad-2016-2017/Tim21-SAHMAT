using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pocetak : MonoBehaviour {

	public void pocni()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
	public void zavrsi()
    {
        Application.Quit();
    }
}
