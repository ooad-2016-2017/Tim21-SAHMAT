using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NoviLevel : MonoBehaviour {

    public void UcitajSljedeciNivo()
    {
        Debug.Log("Nivo ucitan");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
