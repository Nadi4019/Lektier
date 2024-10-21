using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Age : MonoBehaviour
{

    public int currentAge = 19;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Nadia er lige nu " + currentAge + " år gammel");
        Debug.Log("efter 1 år...");
        IncreaseAge();
        Debug.Log("Nadia er " + currentAge + " år gammel!");
        IncreaseAge(8);
        Debug.Log("Nadia er efter 8 år " + currentAge + " år gammel");
        IncreaseAge(3);
        Debug.Log("og efter 3 år mere er Nadia " + currentAge + " år gammel!");
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseAge()
    {
        currentAge += 1;
    }
   
   public void IncreaseAge(int ageIncrease)
   {
        currentAge += ageIncrease;
   }

}
