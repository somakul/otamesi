using UnityEngine;
using System.Collections;

public class PrefabStart : MonoBehaviour {
	public GameObject Ball;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (Ball, new Vector3 (0, 0, 0), Quaternion.identity);
		}
	
	}
}
