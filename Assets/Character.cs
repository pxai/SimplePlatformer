using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Debug.Log ("Space was pressed");
			this.GetComponent<Rigidbody2D>().velocity = Vector2.up * 5;
		}

		if (Input.GetKeyDown ("a")) {
			this.GetComponent<Rigidbody2D>().velocity = Vector2.left * 2;
		}

		if (Input.GetKeyDown ("d")) {
			this.GetComponent<Rigidbody2D>().velocity = Vector2.right * 2;
		}
		this.transform.rotation = Quaternion.identity;
	}
}
