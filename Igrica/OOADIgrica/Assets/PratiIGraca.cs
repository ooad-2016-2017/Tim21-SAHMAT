using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PratiIGraca : MonoBehaviour {

    public Transform igrac;
    public Vector3 offsetZaKameru;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = igrac.position + offsetZaKameru;
	}
}
