using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		Image image = GetComponent<Image> ();
		image.fillAmount = Mathf.Lerp(image.fillAmount,1.2f,Time.deltaTime * .5f);
	
	}
}
