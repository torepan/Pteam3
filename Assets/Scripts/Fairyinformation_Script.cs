using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fairyinformation_Script : MonoBehaviour
{
    public int place; //場所
    public bool canPush = true; //移動中や準備中なら押せない
    float montionTime; //移動にかかる時間を計る
    [SerializeField]
    float interval = 0.1f;//移動時間
    int testPlace = 1;//テスト用変数
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //次の移動までの時間を計測
        
        //canPushがtrueなら
        if (canPush == true)
        {
            //テスト用のコード
            //スペースキーを押すとtestPlaceの値が増えてplaceの値が変わる
            if (Input.GetKeyDown(KeyCode.Space))
            {
                testPlace++;
                MoveReceive(testPlace);
                Debug.Log(place);
            }
        }
        else
        {
            montionTime += Time.deltaTime;
            //ここでintervalよりmontionTimeの数値が大きいと
            if (montionTime >= interval)
            {
                Debug.Log("準備");
                canPushTime();
            }
        }
    }

    //受け取った引数をplaceに入れて、canPushをfalseに
    public void MoveReceive(int n)
    {
        place = n;
        canPush = false;
        montionTime = 0;
        Debug.Log(canPush);
    }

    //canPushTimeはcanPushをtrueにするだけ
    void canPushTime()
    {
        Debug.Log("動ける");
        montionTime = 0;
        canPush = true;
        Debug.Log(canPush);
    }
}
