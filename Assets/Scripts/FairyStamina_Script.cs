using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// スタミナを管理するスクリプト
/// スタミナは常に回復する
/// 0以下になった場合は一定時間動けなくなり、
/// モーションなどの時間
/// その後最大値まで回復して動けるように
/// </summary>
public class FairyStamina_Script : MonoBehaviour
{
    [SerializeField] public float Max_f { get; private set; }
    [SerializeField] public float dif_f { get; private set; }//名前？
    [SerializeField] public float heal_f { get; private set; }
    public float NowStamina { get; private set; }
    [SerializeField]public float waitTime { get; private set; }
    float healTime;
    public bool haveEnergy { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        SetStamina();
    }
    public void SetStamina()
    {
        NowStamina = Max_f;
        healTime = 0f;
        haveEnergy = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (haveEnergy)
        {
            NowStamina += heal_f*Time.deltaTime;//0でなければ回復する
            NowStamina = (NowStamina < Max_f) ? NowStamina : Max_f;//最大値は超えない
        }
        else
        {
            Debug.Log("回復中！");
            healTime += Time.deltaTime;
            if (healTime > waitTime)//数秒待って、
            {
                Debug.Log("スタミナを回復！");
                //スタミナを回復して変更する
                SetStamina();
            }
        }
    }

    public void UseStamina()
    {
        if (haveEnergy)
        {
            NowStamina -= dif_f;
            Debug.Log("消費後のスタミナは："+NowStamina);
            if (NowStamina <= 0)
            {
                Debug.Log("スタミナは0以下");
                haveEnergy = false;
            }
        }
        else
        {
            Debug.Log("スタミナがなくて動けない！");
        }
        
    }
}
