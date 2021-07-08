using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction_Script : MonoBehaviour
{
    [SerializeField] Tyabasira_Script Tyabasira_;
    [SerializeField] Fairyinformation_Script Finfo_;
    //[SerializeField] YOUSEI sousei;
    int nowPlace=0;
    public void OnClickDo(int n)
    {
        Debug.Log("OCD入力受付:"+n);
        Debug.Log("Finfoのplace:"+ Finfo_.place);

        if (!Finfo_.canPush)
        {
            Debug.Log("押せないので終了");
            return;//押せないなら終了
        }

        if (n != Finfo_.place)
        {
            Debug.Log("Placeを変更する！");
            moveChar(n);
            nowPlace = Finfo_.place;
            Debug.Log("nowPlace変更："+nowPlace);
        }
        if (n == Finfo_.place) moveTyaba(n);
    }

    void moveChar(int n)
    {
        Finfo_.MoveReceive(n);
    }

    public void moveTyaba(int n)
    {
        Tyabasira_.MoveForce(n);//PUN2の関係で最初から切り出す
    }

    public void moveTyaba()//移動なしで押された際にはこいつを呼ぶ
    {
        moveTyaba(nowPlace);
    }
}
