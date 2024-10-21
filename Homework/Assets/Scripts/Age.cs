using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Age : MonoBehaviour
{
    public int IncreaseAge(int currentAge)
    {
        currentAge += 1;
        Debug.Log("increased age by 1 year. new age:" + currentAge);
        return currentAge;
    }

    public int IncreaseAge(int currentAge, int yearsToIncrease)
    {
        currentAge += yearsToIncrease;
        Debug.Log("Increased age by " + yearsToIncrease + "years. New age:" + currentAge);
        return currentAge;
    }

    // Start is called before the first frame update
    void Start()
    {
        int currentAge = 20;

        //test increasing age by 1 year
        currentAge = IncreaseAge(currentAge);

        //test increasing age by specified number of years
        int yearsToAdd = 5;
        currentAge = IncreaseAge(currentAge, yearsToAdd);

        yearsToAdd = 10;
        currentAge = IncreaseAge(currentAge, yearsToAdd);
    }

}
