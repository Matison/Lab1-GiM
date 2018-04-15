using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour {

	public GameObject Gracz;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void LastUpdate () {
		transform.position = Gracz.transform.position + offset;
	}
}
