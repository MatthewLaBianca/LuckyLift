using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using System.Collections;
using System.Collections.Generic;

public class ListManager : MonoBehaviour {

    public List<int> floors = new List<int>();
    public List<int> selectedFloors = new List<int>();		//this can turn private once it is ready to publish


    public int correctFloors;
    public Text winOrLose;

	public Button submitBttn;

	private int amntSelected;

	void Start () {
		amntSelected = 0;
		submitBttn.interactable = false;
        correctFloors = 0;  //Initialize the game so that at the beginning there are no correct floors
        for (int i = 0; i < floors.Count; i++)              //Randomize the list of floors
        {
            int temp = floors[i];
            int randomIndex = Random.Range(i, floors.Count);
            floors[i] = floors[randomIndex];
            floors[randomIndex] = temp;
        }
    }

	void Update()
	{
		if(amntSelected <= 0)
		{
			submitBttn.interactable = false;
		}else
		{
			submitBttn.interactable = true;
		}

	}


    public void AddFloorToSelectedFloors(int chosenFloor)   //When a button is selected,
    {                                                       //make a new list of selected floors
		if(amntSelected < 5)
		{
			if(!GameObject.Find("on_border_" + (chosenFloor).ToString()).GetComponent<Image>().enabled)
			{
				amntSelected++;
	        	selectedFloors.Add(floors[chosenFloor - 1]);		//on button press, pass in the chosen floor so that we know how many winning floors have been chosen
				GameObject.Find("on_border_" + (chosenFloor).ToString()).GetComponent<Image>().enabled = true;
			}
			else
			{
				amntSelected--;
				selectedFloors.Remove(floors[chosenFloor - 1]);
				GameObject.Find("on_border_" + (chosenFloor).ToString()).GetComponent<Image>().enabled = false;
			}
		}
		else{
			
			if(GameObject.Find("on_border_" + (chosenFloor).ToString()).GetComponent<Image>().enabled)
			{
				amntSelected--;
				selectedFloors.Remove(floors[chosenFloor - 1]);
				GameObject.Find("on_border_" + (chosenFloor).ToString()).GetComponent<Image>().enabled = false;
			}
		}
    }

	
    public void SubmitTicket()
    {
        foreach(int floor in selectedFloors)		//check each "floor" in the list.
        {											//if the floor is a 1, it is a winning floor
            if (floor == 1)							//if the floor holds a 0, it is a losing floor
            {
                correctFloors++;
            }
        }
        //winOrLose.text = correctFloors.ToString() + " Correct Floors!";	//this was for testing
    }
}
