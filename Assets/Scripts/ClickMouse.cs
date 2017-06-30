using UnityEngine;
using System.Collections;

public class ClickMouse : MonoBehaviour {

	public string texto = "";

	public void Update(){

		OnMouseDown();

	}

	public void OnMouseDown(){

		if (Input.GetMouseButton (0)) {
			texto = "Cargando...";
		} else {
			texto = "";
		}


	}
}
