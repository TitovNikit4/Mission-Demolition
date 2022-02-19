using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLine : MonoBehaviour {
	static public ProjectileLine S;

	[Header("Set in Inspector")]
	public float minDist = 0.1f;

	private LineRenderer line;
	private GameObject _poi;
	private List<Vector3> points;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
