using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D collider) {
		Destroy (collider.gameObject);
	}
}
