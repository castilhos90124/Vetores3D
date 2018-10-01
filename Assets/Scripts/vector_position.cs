using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vector_position : MonoBehaviour {

	public Transform target;

	private float x;
	private float y;
	private float z;

	private float FixedScale = 0.04951196f;

	private float multiplierMod = 0.67f;
	private float multiplierTeta = -57.29579143313326f;
	private float multiplierGama = -57.29579143313326f;

	private float teta;
	private float mod;
	private float gama;


	void Update()
	{
		// Rotate the camera every frame so it keeps looking at the target
		//transform.LookAt(target);
		getCoordinates ();
		mod = Modulo ();
		teta = Teta ();
		gama = Gama ();


		Debug.Log (gama);
		transform.localScale = new Vector3 (FixedScale,mod,FixedScale);
		transform.rotation = Quaternion.Euler (new Vector3 (gama, teta, 0));

	}

	float Modulo(){
		return (Mathf.Sqrt ((x * x) + (y * y) + (z * z))) * multiplierMod;
	}

	void getCoordinates(){
		x = (target.position.z) * (-1);
		y = target.position.x;
		z = target.position.y;
	}

	float Teta(){
		
		return (Mathf.Atan2 (y,x)) * multiplierTeta;

	}

	float Gama(){
		return (Mathf.Atan2 (Mathf.Sqrt ((x * x) + (y * y)), z)) * multiplierTeta;
	}
}
