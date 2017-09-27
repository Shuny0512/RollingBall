using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartController : MonoBehaviour 
{
	public Button RestartLabel;

	private void Start ()
	{
		RestartLabel.gameObject.SetActive (false);

		RestartLabel.onClick.AddListener (Restart);
	}

	void Restart ()
	{
		SceneManager.LoadScene (0);
	   
	}
	public void ShowRestart()
	{
		RestartLabel.gameObject.SetActive (true);
	}
}
