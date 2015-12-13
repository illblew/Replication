using UnityEngine;
using System.Collections;

public class cBar : MonoBehaviour {
	float speed = 3f;
	public Rigidbody rigid;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("right")) {
			Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
			transform.position += move * speed * Time.deltaTime;

			rigid = GetComponent<Rigidbody>();
			rigid.mass = 500;
		}

	}
}
