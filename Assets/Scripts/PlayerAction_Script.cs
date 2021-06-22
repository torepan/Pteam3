using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction_Script : MonoBehaviour
{
    [SerializeField] Tyabasira_Script Tyabasira_;
    //[SerializeField] YOUSEI sousei;
    public void OnClickDo(int n)
    {
        if (!true/*yousei.CanPush*/) return;

        if (n != 1) moveChar(n);
        if (n == 1) moveTyaba(n);
    }

    void moveChar(int n)
    {

    }

    void moveTyaba(int n)
    {
        Tyabasira_.MoveForce(n);//PUN2の関係で最初から切り出す
    }
}
