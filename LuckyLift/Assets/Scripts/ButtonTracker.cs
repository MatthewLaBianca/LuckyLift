using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ButtonTracker : MonoBehaviour {
	public List<Text> selectedButtons = new List<Text>();
	public ListManager listMan = new ListManager();
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		for(int i=0;i<selectedButtons.Capacity;i++)
		{

			if(listMan.realSelectedFloors[i] != null)
			{
				selectedButtons[i].text = listMan.realSelectedFloors[i].ToString();
			}else
			{
				selectedButtons[i].text = "n/a";
			}
		}
	}
}
