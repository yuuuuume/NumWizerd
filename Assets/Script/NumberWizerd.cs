using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class NumberWizerd : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    //we can assign them on inspecter
     int guess;

    // Use this for initialization
    void Start()
    {

        StartGame();
    }

    void StartGame()
    {
        
      
        MakeGuess();
      /*  Debug.Log("G'day mate, welcome to numba wiz-ud...");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    */
    }

    public void MakeGuess()
    {
        guess = Random.Range(min, max+1);
        guessText.text = guess.ToString();

    }
    // Update is called once per frame
    public void OnPressHigher()
    {
        min = guess + 1;
        MakeGuess();

    }

    public void OnPressLower()
    {
        max = guess -1;
        MakeGuess();
    }
    
}