using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathObjectController : MonoBehaviour 
{
	public GameOverController GameOverController;

	private void OnTriggerEnter (Collider hit)
	{
		if (hit.CompareTag ("Player")) 
		{
		
			hit.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

			GameOverController.ShowGameOverLabel ();


		}
	}
}
		


