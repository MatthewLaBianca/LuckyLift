using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class randomizedNumbers : MonoBehaviour {
	public List<Text> numbers = new List<Text>();
	public List<Image> terminals = new List<Image>();
	public ListManager listMan = new ListManager();

	List<bool> flippingNumbers = new List<bool>();

	public bool gameReady;
	private int number;
	private int number2;
	private int number3;
	private int number4;
	private int number5;
	float time = 0;
	float incrimentTime = .4f;


	bool flip1,flip2,flip3,flip4,flip5;


	// Use this for initialization
	void Start () {
		gameReady = false;
		number = Random.Range(0,39);
		number2 = Random.Range(0,39);
		number3 = Random.Range(0,39);
		number4 = Random.Range(0,39);
		number5 = Random.Range(0,39);
		flippingNumbers.Add(flip1);
		flippingNumbers.Add(flip2);
		flippingNumbers.Add(flip3);
		flippingNumbers.Add(flip4);
		flippingNumbers.Add(flip5);
		flippingNumbers[0] = true;
		flippingNumbers[1] = true;
		flippingNumbers[2] = true;
		flippingNumbers[3] = true;
		flippingNumbers[4] = true;
	}

	// Update is called once per frame
	void Update () {
		Randomize(gameReady);
		if(gameReady)
		{
			
			StartCoroutine(waiter(1.0f));

		}
	}
	IEnumerator waiter(float seconds)
	{
		for(int i = 0;i<numbers.Capacity;i++)
		{
			flippingNumbers[i] = false;
			numbers[i].text = listMan.realWinningFloors[i].ToString();
			if(listMan.realSelectedFloors.Contains(listMan.realWinningFloors[i]))
			{
				terminals[i].color = new Vector4(0,255,0,.5f);
			}
			else
			{
				terminals[i].color = new Vector4(255,0,0,.5f);
			}

			yield return new WaitForSeconds(seconds);
		}
		yield return true;
	}
	void Randomize(bool ready)
	{
		
			time += Time.deltaTime;
			if(time>incrimentTime)
			{

			if(flippingNumbers[0])
					number++;
			if(flippingNumbers[1])
					number2++;
			if(flippingNumbers[2])
					number3++;
			if(flippingNumbers[3])
					number4++;
			if(flippingNumbers[4])
					number5++;
			}

			if(number >= 40)
			{
				number = Random.Range(1,39);
				number2 = Random.Range(1,39);
				number3 = Random.Range(1,39);
				number4 = Random.Range(1,39);
				number5 = Random.Range(1,39);
			}
		if(flippingNumbers[0])
			numbers[0].text = number.ToString();
		if(flippingNumbers[1])
			numbers[1].text = number2.ToString();
		if(flippingNumbers[2])
			numbers[2].text = number3.ToString();
		if(flippingNumbers[3])
			numbers[3].text = number4.ToString();
		if(flippingNumbers[4])
			numbers[4].text = number5.ToString();

		if(!ready)
		{
			foreach(Image terminal in terminals)
			{
				terminal.color = new Vector4(0,0,0,.5f);
			}

		}
	}

}
