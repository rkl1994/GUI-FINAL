using UnityEngine;
using System.Collections;

public class MainToLoadingManager : MonoBehaviour {

	// Use this for initialization
	public void StartGame(){
		Application.LoadLevel ("loading");
	}
}
