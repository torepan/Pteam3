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
    [SerializeField] float Max_f;
    [SerializeField] float dif_f;//名前？
    [SerializeField] float heal_f;
    float NowStamina;
    [SerializeField]float waitTime;
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
    }
    // Update is called once per frame
    void Update()
    {
        if (haveEnergy)
        {
            NowStamina += heal_f;//0でなければ回復する
            NowStamina = (NowStamina < Max_f) ? NowStamina : Max_f;//最大値は超えない
        }
        else
        {
            healTime += Time.deltaTime;
            if (healTime > waitTime)//数秒待って、
            {
                //スタミナを回復して変更する
                haveEnergy = true;
                NowStamina = Max_f;
            }
        }
    }

    public void UseStamina()
    {
        if (haveEnergy)
        {
            NowStamina -= dif_f;
            if (NowStamina < 0)
            {
                haveEnergy = false;
            }
        }
        else
        {
            Debug.Log("スタミナがなくて動けない！");
        }
        
    }
}
