using UnityEngine;
using System.Collections;

public class StatePatterEnemy : MonoBehaviour 
{
	public float searchingTurnSpeed = 120f;
	public float searchingDuration = 4f;
	public float sightRange = 20f;
	public Transform [] wayPoints;
	public Transform eyes;
	public Vector3 offset = new Vector3 (0, .5f, 0);



		/ Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
