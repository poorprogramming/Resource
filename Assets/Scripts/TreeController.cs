using UnityEngine;
using System.Collections;

public class TreeController : MonoBehaviour
{
	
	public float treeCount;
	
	private int treeGains;
	private bool gaining;
	
	
	void Start () 
	{
		treeCount = 0.0f;
		treeGains = 0;
		gaining = false;
	}
	
	void Update () 
	{
		if (gaining == true) 
		{
			treeCount += Time.deltaTime * treeGains;
		}
		
		
		if (Input.GetMouseButtonDown (1)) 
		{
			gaining = true;
			treeGains++;
		}
		Debug.Log("Trees: " + treeCount.ToString ("0"));
	}
}