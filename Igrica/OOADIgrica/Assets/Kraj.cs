using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kraj : MonoBehaviour {

    public GameManager gm;

	void OnTriggerEnter()
    {
        gm.KrajNivoa();
    }
}
