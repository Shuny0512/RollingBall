using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer  : MonoBehaviour 
{
	public Transform Player;

	private Vector3 offset; 

	private void Start ()
	{
		offset = GetComponent<Transform> ().position - Player.position;
	}

	private void Update ()
	{
		
		GetComponent<Transform> ().position = Player.position + offset;
	}
}
