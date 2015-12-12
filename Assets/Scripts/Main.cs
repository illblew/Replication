using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	// Use this for initialization
	//Declare the sprite
	public Sprite sprite;
	int number;
	//Level & modifiers
	int level = 0;
	int power = 1;
	int rain = 0;
	int hardmode = 0;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//Go time
		MakeItSand (level,power,hardmode);
	}

	//Make it be sand
	void MakeItSand(int level,int power, int hardmode) {
		if (hardmode == 1) {
			//later
		} else {
			//Do this for starters
			if (Input.GetKey("up")) {
				MakeSprite(1);
			}

		}
	}

	//sprite maker
	void MakeSprite(int number) {
		GameObject go = new GameObject ("sandsprite" + number);
		SpriteRenderer renderer = go.AddComponent<SpriteRenderer> ();
		renderer.transform.localScale = new Vector3 (0.29f, 0.29f, 1f);
		renderer.transform.position = Camera.main.ScreenToWorldPoint( new Vector3(Screen.width/2,150, 1f));
		Rigidbody2D goRB = go.AddComponent<Rigidbody2D> ();
		BoxCollider2D goBC = go.AddComponent<BoxCollider2D> ();
		goRB.mass = 1;
		renderer.sortingLayerName = "Default";
		renderer.sprite = sprite;
	}
}
