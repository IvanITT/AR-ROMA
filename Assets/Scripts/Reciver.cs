using UnityEngine;
using System.Collections;

public class Reciver : MonoBehaviour {

	public string textScreen;
	public TextMesh pantalla;

	public void Update(){
		ClickMouse click = GetComponent<ClickMouse>();
		textScreen = click.texto;

		pantalla = (TextMesh)GameObject.Find ("New Text").GetComponent<TextMesh>();
		pantalla.text = "" + textScreen;
	}

}
