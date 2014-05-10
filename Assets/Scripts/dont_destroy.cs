using UnityEngine;
using System.Collections;

public class dont_destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void Awake()
	{
		DontDestroyOnLoad(this);
	}
}
