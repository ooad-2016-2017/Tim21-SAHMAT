using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool krajIgre = false;

    public GameObject completeLevelPanel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void KrajIgre()
    {
        if (!krajIgre)
        {
            krajIgre = true;
            Invoke("Restart", 1f);
        }
    }
    public void KrajNivoa()
    {
        completeLevelPanel.SetActive(true);
    }
    void Restart()
    {
        krajIgre = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
