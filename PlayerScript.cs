using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public int currentAge = 0;
    public int increaseAge(int increasedAge){

    currentAge += increasedAge;

    return currentAge;
        
    }
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(increaseAge(1));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
