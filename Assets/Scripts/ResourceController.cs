using UnityEngine;
using System.Collections;

public class ResourceController : MonoBehaviour
{
	public string resourceName;
	public float rate = 1.0f;
	//[HideInInspector]
	public float count = 0.0f;

	[HideInInspector]
	public bool gaining;
	private GameController gameController;
	
	
	void Start () 
	{
		gaining = false;
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");

		if (gameControllerObject != null) {
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null) {
			Debug.Log ("Cannot find 'GameController' script.");
		}
	}

	void Update () 
	{
		if (gaining == true) 
		{
			AddResource (rate * Time.deltaTime);
		}
	}

	void OnMouseDown ()
	{
		gaining = !gaining;
	}

	void AddResource (float newResourceValue)
	{
		count += newResourceValue;
	}
}