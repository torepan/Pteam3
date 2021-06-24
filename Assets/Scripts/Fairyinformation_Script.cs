using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fairyinformation_Script : MonoBehaviour
{
    int place; //場所
    bool canPush=true; //移動中や準備中なら押せない
    float montionTime; //移動にかかる時間を計る
    [SerializeField]
    float interval=5;//移動時間
    int testPlace=1;//テスト用変数
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        montionTime+= Time.deltaTime;
        if(canPush==true){
        //テスト用のコード
        //スペースキーを押すとtestPlaceの値が増えてplaceの値が変わる
        if (Input.GetKeyDown(KeyCode.Space)) {
            testPlace++;
            MoveReceive(testPlace);
            Debug.Log(place);
        }
        }
    }

    public void MoveReceive(int n){
            place=n;
            canPush=false;
            Debug.Log(canPush);
            canPushTime();
        }

        void canPushTime(){
            while(montionTime<interval){
                montionTime+= Time.deltaTime;
                //Debug.Log(montionTime);
            }

            //if(montionTime>=interval){
            Debug.Log("動ける");
            montionTime=0;
            canPush=true;
            Debug.Log(canPush);
            //}
        }
}
