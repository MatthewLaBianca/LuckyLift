using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class randomizedNumbers : MonoBehaviour {
	public List<Text> numbers = new List<Text>();
	public ListManager listMan = new ListManager();
	public bool gameReady;
	private int number;
	private int number2;
	private int number3;
	private int number4;
	private int number5;
	float time = 0;
	float incrimentTime = .4f;
	// Use this for initialization
	void Start () {
		gameReady = false;
		number = Random.Range(0,39);
		number2 = Random.Range(0,39);
		number3 = Random.Range(0,39);
		number4 = Random.Range(0,39);
		number5 = Random.Range(0,39);
	
	}

	// Update is called once per frame
	void Update () {
		Randomize(gameReady);
		if(gameReady)
		{
			for(int i = 0;i<numbers.Capacity;i++)
			{
				numbers[i].text = listMan.realWinningFloors[i].ToString();
			}

		}
	}

	void Randomize(bool ready)
	{
		if(!ready)
		{
			time += Time.deltaTime;
			if(time>incrimentTime)
			{
				number++;
				number2++;
				number3++;
				number4++;
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
			numbers[0].text = number.ToString();
			numbers[1].text = number2.ToString();
			numbers[2].text = number3.ToString();
			numbers[3].text = number4.ToString();
			numbers[4].text = number5.ToString();
		}
	}

}
