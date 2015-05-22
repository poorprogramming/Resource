using UnityEngine;
using System.Collections;

public class ChestController : MonoBehaviour
{
	private bool open = false;
	
	void OnMouseDown ()
	{
		OpenChest ();
	}
	
	
	void OpenChest () {
		if (!open && !GetComponent<Animation>().isPlaying) {
			GetComponent<Animation>() ["Default Take"].speed = 1.0f;
			GetComponent<Animation>().Play ();
			open = !open;
		} else if (!GetComponent<Animation>().isPlaying) {
			GetComponent<Animation>() ["Default Take"].time = GetComponent<Animation>() ["Default Take"].length;
			GetComponent<Animation>() ["Default Take"].speed = -1.0f;
			GetComponent<Animation>().Play ();
			open = !open;
		}
	}
}
