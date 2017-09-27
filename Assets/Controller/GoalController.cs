using System.Collections;
using UnityEngine;

public class GoalController: MonoBehaviour 
{
	public UIController UIController;

	public RestartController RestartController;

	private void OnTriggerEnter (Collider hit)
	{
		if (hit.CompareTag ("Player"))
		{	
			
			hit.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeAll;

			UIController.ShowGameClearLabel();

			RestartController.ShowRestart();
		}
	}
}
