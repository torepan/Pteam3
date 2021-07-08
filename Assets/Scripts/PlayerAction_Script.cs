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
        if (Finfo_.canPush) return;//押せないなら終了

        if (n != Finfo_.place)
        {
            moveChar(n);
            nowPlace = Finfo_.place;
        }
        if (n == Finfo_.place) moveTyaba(n);
    }

    void moveChar(int n)
    {
        Finfo_.MoveReceive(n);
    }

    void moveTyaba(int n)
    {
        Tyabasira_.MoveForce(n);//PUN2の関係で最初から切り出す
    }

    void moveTyaba()//移動なしで押された際にはこいつを呼ぶ
    {
        moveTyaba(nowPlace);
    }
}
