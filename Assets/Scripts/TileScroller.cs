using UnityEngine;
using System.Collections;

public class TileScroller : MonoBehaviour
{
	public float scrollSpeed = 0.5F;
	public GameObject waterTile;

	void Update() 
	{
		float offset = Time.time * scrollSpeed;
		waterTile.renderer.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
	}
}
