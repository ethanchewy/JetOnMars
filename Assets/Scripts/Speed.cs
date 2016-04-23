using UnityEngine;
using System.Collections;

public class Speed : MonoBehaviour {
	//var vel = Rigidbody.velocity;
	public GUIText distext;
	// Use this for initialization
	void Start () {
		//Change velocity after adding equation
		distext.text = "Acceleration: " + .9;
	
	}
	
	// Update is called once per frame
	void Update () {
		//Change velocity after adding equation
		distext.text = "Acceleration: " + .9;
	
	}
}
