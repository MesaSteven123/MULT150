using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
   /// Start is called before the first frame update
    void Start()
    {
       /* // Count the seven days of the week
        for (int day = 1; day <= 7; day++)
        {
            Debug.Log(day);
        } */



      /*  // Get sum of all numbers 1-10
        int sum = 0;
        int count = 1;
        while (count <= 10)
        {
            Debug.Log("sum:" + sum + "count:" + count);
            sum = sum + count; // sum += count
            count++;
        }
        Debug.Log("finalsum: " + sum); */

        /* int i = 0;
        i++;
        Debug.Log(i);
        i--;
        Debog.Log(i); */

       /* int health;
        health = 100;

        int potion = 20;

        health = health - 30; // health - 30

        health += potion; 

        if (health == 0) // == equal, !- not equal
        {
            Debug.Log("player has been unalived!");
        }
        else if (health < 30)
        {
            Debug.Log("DANGER! Low health");
        }
        else if (health == 100)
        {
            Debug.Log("player is chilling");
        }
        else
        {
            Debug.Log("player is alive");
        } */
                

        /* int damage = 30; // "+" or "-" whole #
        float speed = 10.0f; // decima values, must be terminated with f
        double rocketSpeed = 1004.4234243; //similar to float, but holds larger value
        bool gameOver = false; // true or false
        char someCharacters = 'A'; // sigle character enclosed in single quotes
        string manyCharacters = "The night is dark and full of terrors"; // multiple characters enclosed in double quotes

        Debug.Log("damage value is " + damage);
        Debug.Log("speed: " + speed);
        Debug.Log("rocketSpeed: " + rocketSpeed);
        Debug.Log("is the game over? " + gameOver);
        Debug.Log("someCharacter: " + someCharacters);
        Debug.Log("manyCharacters: " + manyCharacters);

        Debug.Log("health is " + health);
       // Debug.Log("potion is " + potion);
     /*   print("Hello World!");
        Debug.Log("Bye!"); */
    }

    // Update is called once per frame
    void Update()
    {
      //  Debug.Log("spam! !@#$%^&*(");
    }
}
