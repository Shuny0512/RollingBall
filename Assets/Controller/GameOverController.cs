using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour 
{
	public Text GameOverLabel;

	private void Start ()
	{
		GameOverLabel.gameObject.SetActive (false);
		
	}

	public void ShowGameOverLabel()
	{
		GameOverLabel.gameObject.SetActive (true);
	}
}
