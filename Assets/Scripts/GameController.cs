using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
	public GUIText resourceText;
	public List<GameObject> resourcePrefabs;
	public List<GameObject[]> resourceObjects = new List<GameObject[]>();
	public List<List<ResourceController>> resourceControllers = new List<List<ResourceController>>();



	void Start ()
	{
		CreateResourceList ();
		UpdateResources ();
	}

	void Update ()
	{
		UpdateResources ();
	}



	public void UpdateResources ()
	{
		string txt = "";

		for (int i=0; i < resourcePrefabs.Count; i++)
		{
			float total = 0.0f;
			float speed = 0.0f;

			foreach (ResourceController rc in resourceControllers[i])
			{
				total += rc.count;
				if (rc.gaining) { speed += rc.rate; }
			}
			txt += resourceControllers[i][0].resourceName + ": " + Mathf.FloorToInt(total) + " (" + speed.ToString("0.000") + "/s)\n";
		}
		resourceText.text = txt;
	}
	
	void CreateResourceList ()
	{
		for (int i=0; i < resourcePrefabs.Count; i++)
		{
			resourceObjects.Add (GameObject.FindGameObjectsWithTag(resourcePrefabs[i].tag));

			for (int j=0; j < resourceObjects[i].Length; j++)
			{
				resourceControllers.Add(new List<ResourceController>());
				resourceControllers[i].Add(resourceObjects[i][j].GetComponent <ResourceController>());
			}
		}
	}
}