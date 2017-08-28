using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class PlayButton : MonoBehaviour {

	public Text PlayerCount;
	public Slider PlayerSlider;
	
	public void onClick(){
		
		Application.LoadLevel ("Main");
	}
}
