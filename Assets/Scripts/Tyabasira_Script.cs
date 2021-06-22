using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tyabasira_Script : MonoBehaviour
{
    private float angleX { get; }
    private float angleY { get; }
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveForce(int n)//場所１～４
    {
        Debug.Log("MoveForce呼び出され："+n);
    }
}
