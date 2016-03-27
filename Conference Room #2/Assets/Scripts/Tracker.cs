using UnityEngine;
using System.Collections;

public class Tracker : MonoBehaviour {

	public GameObject target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.forward = target.transform.position - transform.position;
	}
}
