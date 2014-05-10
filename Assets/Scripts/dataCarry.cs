using UnityEngine;
using System.Collections;

public class dataCarry : MonoBehaviour {
	public int farms;
	public int greenhouses;
	public int icemines;
	public int mines;
	public int barracks;
	public int explorebases;
	public int mirrorsatellites;
	public int researchcenters;
	public  int population;
	public int food;
	public int water;

	public int weight;

	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}
}
