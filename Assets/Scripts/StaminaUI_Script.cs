using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
/// <summary>
/// 設計
/// スタミナの値を常時とってきて、ゲージを変える
/// 関数として、一定時間で満タンになるものは作っておく
/// </summary>
public class StaminaUI_Script : MonoBehaviour
{
    [SerializeField] Image image_;
    [SerializeField] FairyStamina_Script FairyStamina_;
    //[Header("スタンから回復する時間")][SerializeField] 
    float stanTime_f;//こいついらないかも、どっちで呼ぶかは決めないと…設計…
    float staminaMax;
    // Start is called before the first frame update
    void Start()
    {
        stanTime_f = FairyStamina_.waitTime;
        staminaMax = FairyStamina_.Max_f;
    }

    // Update is called once per frame
    void Update()
    {
        if (FairyStamina_.haveEnergy)
        {
            Debug.Log("現在の割合は："+FairyStamina_.NowStamina / staminaMax);
            image_.DOFillAmount(FairyStamina_.NowStamina/staminaMax,0.1f);
        }
        else
        {

        }
    }

    /// <summary>
    /// 0になったときに呼び出す。一定時間(s)かけて回復する
    /// </summary>
    public void stan(float s)
    {
        image_.DOFillAmount(1f,s);

    }
}
