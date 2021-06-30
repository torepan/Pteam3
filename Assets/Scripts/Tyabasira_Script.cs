using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tyabasira_Script : MonoBehaviour
{
    public float angleX { private set; get; }
    public float angleZ { private set; get; }
    Rigidbody rb;
    [SerializeField] float dAngle;
    private float TargetAngleX;//こいつに向かって回転
    private float TargetAngleZ;
    Quaternion Target_q;
    float move_t;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        angleX = transform.eulerAngles.x;
        angleZ = transform.eulerAngles.z;
        TargetAngleX = angleX;
        TargetAngleZ = angleZ;
        Target_q = transform.rotation;
        move_t = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown) Test_move();
        transform.rotation = Quaternion.Slerp(transform.rotation,Target_q,move_t);
        //transform.rotation = Quaternion.Euler(TargetAngleX,0,TargetAngleZ);
        //transform.rotation = Quaternion.Slerp(this.transform.rotation,rot,1f);
        move_t += Time.deltaTime;
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
        Debug.Log("TargetX:"+TargetAngleX);
        Debug.Log("TargetZ:" + TargetAngleZ);
        
        Target_q = Quaternion.Euler(TargetAngleX, 0, TargetAngleZ);
    }
}
