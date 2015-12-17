using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

	//classes
	public randomizedNumbers numScript = new randomizedNumbers();
	private const float kSecondsInMinute = 60.0f;
	public const int kMinutesTillNewGame = 3;
	private int minutes;
	private float seconds;

	public Text timerText;
	public Text menuTimerText;

	// Use this for initialization
	void Start () {
		seconds = kSecondsInMinute;
		minutes = kMinutesTillNewGame - 1;
	}
	
	// Update is called once per frame
	void Update () {
		StartTimer();
	}

    public void ResetTimer()
    {
		minutes = kMinutesTillNewGame - 1;
		seconds = kSecondsInMinute;
    }

	void StartTimer()
	{
		seconds -= Time.deltaTime;
		int cleanSeconds = (int)(seconds);
		
		if(seconds < 0)
		{
			minutes--;
			seconds = kSecondsInMinute; 
		}
		
		if(cleanSeconds >= 10)
		{
			timerText.text = minutes.ToString() + ":" + cleanSeconds.ToString();
			menuTimerText.text = minutes.ToString() + ":" + cleanSeconds.ToString();

		}else{
			timerText.text = minutes.ToString() + ":0" + cleanSeconds.ToString();
			menuTimerText.text = minutes.ToString() + ":0" + cleanSeconds.ToString();
		}
		if(cleanSeconds <= 30 && minutes == 0)
		{
			timerText.color = Color.yellow;
			menuTimerText.color = Color.yellow;
			numScript.gameReady = false;
		}
		if(minutes < 0)
		{
			ResetTimer();
			timerText.color = Color.green;
			numScript.gameReady = true;
			//GenerateNums(40);
		}
	}

}
