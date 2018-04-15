using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

	public float speed;
	public Rigidbody rb;
	public Text countText;
	public Text winText;

	private int count;
	// Update is called once per frame
	void Start () {
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void Update () {
		float poziom = Input.GetAxis ("Horizontal");
		float pion = Input.GetAxis ("Vertical");
		Vector3 ruch = new Vector3 (poziom, 0.0f, pion);
		//Rigidbody.AddForce (ruch * speed * Time.deltaTime);
		GetComponent<Rigidbody>().AddForce(ruch*speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();

		}
		if (other.gameObject.CompareTag ("Pick Up2"))
		{
			other.gameObject.SetActive (false);
			count = count + 4;
			SetCountText ();

		}
	}

	void SetCountText ()
	{
		countText.text = "Punkty: " + count.ToString ();
		if (count >= 9)
		{
			winText.text = "Wygrałeś!";
		}
	}
}
