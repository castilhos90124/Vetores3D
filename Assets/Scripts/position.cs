using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour {

	public GameObject logicX;
	public GameObject logicY;
	public GameObject logicZ;

	public float x;
	public float y;
	public float z;

	const float multiplier = 0.37f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Slider scriptX = logicX.GetComponent<Slider> ();
		x = scriptX.valor;

		Slider scriptY = logicY.GetComponent<Slider> ();
		y = scriptY.valor;

		Slider scriptZ = logicZ.GetComponent<Slider> ();
		z = scriptZ.valor;

		x = CoordinateAjuster (x);
		y = CoordinateAjuster (y);
		z = CoordinateAjuster (z);

		transform.position = new Vector3(y, z, -x);	

	}

	float CoordinateAjuster(float coordinate){
		coordinate = coordinate * multiplier;
		return coordinate;
	}

}
