using UnityEngine;
using System.Collections;

public class PublicMove : MonoBehaviour {
	public float Speed = 0.01f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (0, 0, Speed);
	
	}
}
