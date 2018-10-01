using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider: MonoBehaviour {

	public Text texto;
	public float valor;
	public GameObject esfera;

	public void OnValueChanged(float value){
		texto.text = value.ToString();
		valor = value;

		//Vector3 position = esfera.position;
		//position [2] = value; // the Z value
		//esfera.position = position;

	}
}
