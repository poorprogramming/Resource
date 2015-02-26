using UnityEngine;
using System.Collections;

public class WaterController : MonoBehaviour
{
	public float scrollSpeed = 0.5F;
	public GameObject gameObject;

	void Update() 
	{
		float offset = Time.time * scrollSpeed;
		gameObject.renderer.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
	}
}
