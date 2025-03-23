using UnityEngine;

public class Cube : MonoBehaviour
{
    int numberOfTimes = 5;
    string nameOfTheKey = "ENTER";
    float speedOfBraking = 6.94f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("If you press the up arrow you'll JUMP!");
        Debug.Log("If you press the left or right arrow" + " " + numberOfTimes + " " + "you'll MOVE!");

        Debug.LogWarning("if you press the" + " " +  nameOfTheKey + " " + "nothing happens");

        Debug.LogError("your speed is" + " " + speedOfBraking);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
