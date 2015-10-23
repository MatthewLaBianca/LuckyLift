using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using System.Collections;
using System.Collections.Generic;

public class ListManager : MonoBehaviour {

    public List<int> floors = new List<int>();
    public List<int> selectedFloors = new List<int>();

    public int correctFloors;
    public Text winOrLose;
	// Use this for initialization
	void Start () {
        correctFloors = 0;  //Initialize the game so that at the beginning there are no correct floors
        for (int i = 0; i < floors.Count; i++)              //Randomize the list of floors
        {
            int temp = floors[i];
            int randomIndex = Random.Range(i, floors.Count);
            floors[i] = floors[randomIndex];
            floors[randomIndex] = temp;
        }
    }


    public void AddFloorToSelectedFloors(int chosenFloor)   //When a button is selected,
    {                                                       //make a new list of selected floors
        selectedFloors.Add(floors[chosenFloor - 1]);
    }


    //This is for testing
    public void SubmitTicket()
    {
        foreach(int floor in selectedFloors)
        {
            if (floor == 1)
            {
                correctFloors++;
            }
        }
        //winOrLose.text = correctFloors.ToString() + " Correct Floors!";
    }
}
