using UnityEngine;
using System.Collections;

public class SoundTrigger : MonoBehaviour {
	public AudioSource source;
	public AudioClip clip;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey("up")) {
			source.Play();
		}
	}
}
