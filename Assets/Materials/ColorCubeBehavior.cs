using UnityEngine;
using System.Collections;

public class ColorCubeBehavior : MonoBehaviour {

	// Use this for initialization
	private RandomColor _randomColor;

	void Awake(){
		_randomColor = this.GetComponent<RandomColor> ();
	}

	void OnCollisionEnter(Collision coll){
		Renderer renderer = coll.gameObject.GetComponent<Renderer> ();
		renderer.material.color = _randomColor.GetBodyColor ();

		_randomColor.ChangeColor ();
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}



