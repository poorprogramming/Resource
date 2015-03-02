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
		if (!open && !animation.isPlaying) {
			animation ["Default Take"].speed = 1.0f;
			animation.Play ();
			open = !open;
		} else if (!animation.isPlaying) {
			animation ["Default Take"].time = animation ["Default Take"].length;
			animation ["Default Take"].speed = -1.0f;
			animation.Play ();
			open = !open;
		}
	}
}
