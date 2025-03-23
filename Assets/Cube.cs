using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("If you press the up arrow you'll JUMP!");
        Debug.Log("If you press the left or right arrow you'll MOVE!");

        Debug.LogWarning("This is a warning message");

        Debug.LogError("This is an error message");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
