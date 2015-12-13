using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	public float endTime;
	public Text timer;
	
	void Start()
	{
		endTime = Time.time + 60;
		timer.text = "60";
	}

	void Update() {
		float timeLeft = Mathf.Round(endTime - Time.time) * (10) /10;;
		timer.text = timeLeft.ToString();
	}

}