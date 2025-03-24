using UnityEngine;

public class platform : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string stringFromOutside = FindAnyObjectByType<Cube>().PrintingfromOutside(4);
        Debug.Log(stringFromOutside);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
