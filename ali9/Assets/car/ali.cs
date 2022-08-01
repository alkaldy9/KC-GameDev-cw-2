using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ali : MonoBehaviour
{    int heroAge = 16;
     int heroHeight = 150;
     int heroSuperPower = 100;
    string name = "amk";
    bool ishero = true;

    int  villainAge = 15;
    int vililanHeight = 100;
    int villainSuperPower = 100;
    string villainName = "nmk";
    bool isvillain = true;

    
    // Start is called before the first frame update
    void Start()
    {
         int ageDifference = heroAge - villainAge;

         print("The hero's name is " + name + "and his age is " + heroAge);
         print("The hero's height is " + heroHeight);
         print("The prophecy says that is a " + ishero + "hero, with a superpower" + heroSuperPower);

         print("The villain's name is" + villainName + "and his age is " +villainAge);
         print("The vililan;s height is " + vililanHeight);
         print("The prophecy says is a " + isvillain + "villain, with a superpower" + villainSuperPower);

         print("ageDifference is " + ageDifference);

         heroHeight = +5;
         print(heroHeight);
        villainSuperPower = 0;
         print("villainSuperPower after " + villainSuperPower);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
