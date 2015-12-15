using UnityEngine;
using System.Collections;

public class MenuAnim : MonoBehaviour {

	public GameObject menu;
	public GameObject target;
	public GameObject target1back;
	public GameObject target2;
	public GameObject targetFinalBack;

	// Use this for initialization
	void Start () {

	}	
	
	// Update is called once per frame
	void Update () {
		
	}
		
	public void SlideToSecond()
	{
		StartCoroutine(lerp1(1.3f));
	}

	public void SlideToFirst()
	{
		StartCoroutine(lerp2(1.3f));
	}

	public void SlideToLast()
	{
		StartCoroutine(lerp3(1.3f));
	}
	public void SlideTo2()
	{
		StartCoroutine(lerp4(1.3f));
	}

	IEnumerator slideToTheLeft(float overTime)
	{
		float startTime = Time.time;
		while(Time.time <= startTime + overTime)
		{
			menu.transform.position += new Vector3(-15,0,0);
			yield return null;
		}

	}

	IEnumerator lerp1(float overTime)
	{
		float startTime = Time.time;
		while(Time.time <= startTime + overTime)
		{
			menu.transform.position = Vector2.Lerp(this.transform.position,target.transform.position,Time.deltaTime);
			yield return null;
		}

	}
	IEnumerator lerp2(float overTime)
	{
		float startTime = Time.time;
		while(Time.time <= startTime + overTime)
		{
			menu.transform.position = Vector2.Lerp(this.transform.position,target1back.transform.position,Time.deltaTime);
			yield return null;
		}

	}
	IEnumerator lerp3(float overTime)
	{
		float startTime = Time.time;
		while(Time.time <= startTime + overTime)
		{
			menu.transform.position = Vector2.Lerp(this.transform.position,target2.transform.position,Time.deltaTime);
			yield return null;
		}

	}

	IEnumerator lerp4(float overTime)
	{
		float startTime = Time.time;
		while(Time.time <= startTime + overTime)
		{
			menu.transform.position = Vector2.Lerp(this.transform.position,targetFinalBack.transform.position,Time.deltaTime);
			yield return null;
		}

	}

	IEnumerator slideToTheRight(float overTime)
	{
		float startTime = Time.time;
		while(Time.time <= startTime + overTime)
		{
			menu.transform.position += new Vector3(15,0,0);
			yield return null;
		}

	}
}
