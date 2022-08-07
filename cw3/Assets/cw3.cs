using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw3 : MonoBehaviour
{
    string heroName = "spiderman";
    int heroPower = 100;
    string villainName = "joker";
    int villairPower = 50;
    float playerSpeed = 4.4f;
    // Start is called before the first frame update
    void Start()
    {
        if (heroPower > villairPower)
        {
            print("heroPower");
        }
        else if (heroPower == villairPower)
        {
            print("they are equally");
        }
        else 
        {
            print("villairPower");
        }
         setSpeed(2.5f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void setSpeed(float newSpeed)
    {
        print("old speed is" + playerSpeed);
        playerSpeed = newSpeed;
        print("new speed is" + playerSpeed);
    }

}
