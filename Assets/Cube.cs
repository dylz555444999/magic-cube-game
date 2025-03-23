using UnityEngine;

public class Cube : MonoBehaviour
{
    public Rigidbody2D myRigidBody2d;

    int numberOfTimes = 5;
    string nameOfTheKey = "ENTER";
    float speedOfBraking = 6.94f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("If you press the up arrow you'll JUMP!");
       // Debug.Log("If you press the left or right arrow" + " " + numberOfTimes + " " + "you'll MOVE!");

       // Debug.LogWarning("if you press the" + " " +  nameOfTheKey + " " + "nothing happens");

       // Debug.LogError("your speed is" + " " + speedOfBraking);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            myRigidBody2d.linearVelocity = new Vector2(0f, 10f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidBody2d.linearVelocity = new Vector2(10f, 0f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            myRigidBody2d.linearVelocity = new Vector2(0f, -10f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidBody2d.linearVelocity = new Vector2(-10f, 0f);
        }

        if (transform.position.x > 9.5f)
        {
            Debug.LogWarning("the cube is out of bounds to the right side!!");
        }

        else if (transform.position.x < -9.5f)
        {
            Debug.LogWarning("the cube is out of bounds to the left side!!");
        }
        else if (transform.position.y > 5.5f)
        {
            Debug.LogWarning("the cube is out of bounds to the top side!!");

        }
    }
}
