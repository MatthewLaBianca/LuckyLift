using UnityEngine;
using System.Collections;

public class MenuAnim : MonoBehaviour {

	public Animation slide1;
	public AnimationClip slideclip1;

	// Use this for initialization
	void Start () {
		slideclip1.legacy = true;
		slide1.AddClip(slideclip1,"slide1");
	}	
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlayFirstSlide()
	{
		slide1.Play("slide1");
	}
}
