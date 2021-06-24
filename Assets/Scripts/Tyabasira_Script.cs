using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tyabasira_Script : MonoBehaviour
{
    public float angleX { private set; get; }
    public float angleZ { private set; get; }
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        angleX = transform.eulerAngles.x;
        angleZ = transform.eulerAngles.z;
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
