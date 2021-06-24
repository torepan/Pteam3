using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fairyinformation_Script : MonoBehaviour
{
    public int place; //場所
    public bool canPush; //移動中や準備中なら押せない
    float montionTime; //移動にかかる時間を計る
    float interval=5;//移動時間
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveReceive(int n){
            place=n;
            canPush=false;
            canPushTime();
        }

        void canPushTime(){
            while(montionTime<interval){
                montionTime+= Time.deltaTime;
            }
            montionTime=0;
            canPush=true;
        }
}
