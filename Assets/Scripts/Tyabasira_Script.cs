﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tyabasira_Script : MonoBehaviour
{
    public float angleX { private set; get; }
    public float angleZ { private set; get; }
    Rigidbody rb;
    [SerializeField] float dAngle = 5;
    private float TargetAngleX;//こいつに向かって回転
    private float TargetAngleZ;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        angleX = transform.eulerAngles.x;
        angleZ = transform.eulerAngles.z;
        TargetAngleX = angleX;
        TargetAngleZ = angleZ;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.anyKeyDown) Test_move();

        transform.rotation = Quaternion.EulerAngles(TargetAngleX,0,TargetAngleZ);
    }
    private void Test_move()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) MoveForce(1);
        if (Input.GetKeyDown(KeyCode.Alpha2)) MoveForce(2);
        if (Input.GetKeyDown(KeyCode.Alpha3)) MoveForce(3);
        if (Input.GetKeyDown(KeyCode.Alpha4)) MoveForce(4);

    }
    public void MoveForce(int n)//場所１～４
    {
        if (n<1||n>4)
        {
            Debug.Log("範囲外の数字で呼ばれました。n:"+n);
            return ;
        }
        Debug.Log("MoveForce呼び出され："+n);

        switch (n)
        {
            case 1://x+
                TargetAngleX += dAngle;
                break;
            case 2://z++
                TargetAngleZ += dAngle;
                break;
            case 3://x-
                TargetAngleX -= dAngle;
                break;
            case 4://z++
                TargetAngleZ -= dAngle;
                break;

        }

    }
}
