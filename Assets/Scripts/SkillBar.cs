using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SkillBar : MonoBehaviour {
	public Image image;

	// Update is called once per frame
	void Update () {
	
	}

	public void SkillAdd(){
		image.fillAmount += 0.2f;
	}
}
