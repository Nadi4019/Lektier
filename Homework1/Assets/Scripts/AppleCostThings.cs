using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleCostThings : MonoBehaviour
{
    private int cost;

    //kims shit
    public int appleCost = 6;
    public int kimsApples = 100;

    //nadias shit
    public int myMoney = 320;


    // Start is called before the first frame update
    void Start()
    {
        // Intro
        Debug.Log("Nadia wants to buy apples!");
        Debug.Log("Nadia has " + myMoney + " amount of money, and she will now buy 12 apples");
        
        // find the cost of 12 apples (6 * 12)
        cost = appleCost * 12;
        Debug.Log("it cost " + cost + " amount of money!");

        // find how much money nadia has now (320 - cost)
        myMoney = myMoney - cost; // myMoney is now updated to the new value
        Debug.Log("Nadia now only has " + myMoney + "!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    


}
