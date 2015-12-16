using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class TicketManager : MonoBehaviour {
	private int ticketAmount;
	public List<Image>borders = new List<Image>();
	public Text amntTxt;
	// Use this for initialization
	void Start () {
		ticketAmount = 1;

	}
	
	// Update is called once per frame
	void Update () {
		amntTxt.text = "$" + ticketAmount.ToString() + "?";
		switch(ticketAmount)
		{
		case 0:
			foreach(Image img in borders)
			{
				img.enabled = false;
			}
			break;
		case 1:
			borders[0].enabled = true;
			borders[1].enabled = false;
			borders[2].enabled = false;
			borders[3].enabled = false;
			borders[4].enabled = false;
			break;
		case 2:
			borders[0].enabled = false;
			borders[1].enabled = true;
			borders[2].enabled = false;
			borders[3].enabled = false;
			borders[4].enabled = false;
			break;
		case 3:
			borders[0].enabled = false;
			borders[1].enabled = false;
			borders[2].enabled = true;
			borders[3].enabled = false;
			borders[4].enabled = false;
			break;
		case 5:
			borders[0].enabled = false;
			borders[1].enabled = false;
			borders[2].enabled = false;
			borders[3].enabled = true;
			borders[4].enabled = false;
			break;
		case 10:
			borders[0].enabled = false;
			borders[1].enabled = false;
			borders[2].enabled = false;
			borders[3].enabled = false;
			borders[4].enabled = true;
			break;
		}
	}
	public int GetTicket()
	{
		return ticketAmount;
	}
	public void SetTicket(int amnt)
	{
		ticketAmount = amnt;

	}
}
