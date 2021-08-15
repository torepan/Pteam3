using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //全員の準備が完了した時に呼び出すやつ
    public void StartG()
    {
        //ボタンやUI全消しはSetActiveとかで？

        //カウントダウン関数の呼び出し
        CDTest();
        //Invokeで茶柱出現関数の呼び出し
        Invoke("TyaTest",3);
    }

    //カウントダウンのテスト
    void CDTest()
    {
        Debug.Log("カウントダウン開始");
    }

    //茶柱出現の呼び出し
    void TyaTest()
    {
        Debug.Log("茶柱が出現");
    }
}
