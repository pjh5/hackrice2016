using UnityEngine;
using System.Collections;

public class PaintBrushScript : MonoBehaviour {

	public int distance;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 myPos = transform.position;
		myPos.x = myPos.x % 50;
		myPos.y = myPos.y % 50;
		myPos.z %= 50;
		transform.position = myPos;

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		Vector3 pos = ray.GetPoint (distance);
//		this.transform.position = pos;
//		print ("Position is " + pos.x + ", " + pos.y + ", " + pos.z);
	}


	public void setPainting(bool b)
	{
		print ("setPainting on paintbrush");
	}
}
