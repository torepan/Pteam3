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
        image_.DOColor(new Color(1.0f*94/255, 1.0f * 200 / 255, 1.0f * 72 / 255), 0f);
        //image_.DOColor(new Color(0, 0, 0), 0f);
        stanTime_f = FairyStamina_.waitTime;
        staminaMax = FairyStamina_.Max_f;
    }

    // Update is called once per frame
    void Update()
    {
        if (FairyStamina_.haveEnergy)
        {
            //Debug.Log("現在の割合は："+FairyStamina_.NowStamina / staminaMax);
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
        image_.DOFillAmount(0f, 0);//念のため0に

        image_.color = Color.red;
        /*
        
        image_.DOFillAmount(1f,s).SetDelay(0.1f);
        image_.DOColor(new Color(94,200,72), 0f).SetDelay(s);//s秒後(処理後)に色を戻す
        */
        //image_.DOFade(0.2f,1f).SetLoops(3,LoopType.Yoyo);
        //fillと同時には使えない(こっちが優先される)ので、別で対処する
        //image_.DOFade(1, 0).SetDelay(s);
        var sequence = DOTween.Sequence();
        //つなげられるらしい
        sequence
            .Append(image_.DOFillAmount(1f, s))
            //.Append(image_.DOFade(1, 0))
            ;//.Append(image_.DOColor(new Color(94, 200, 72), 0f))
        sequence.Join(image_.DOFade(0.2f, 1f).SetLoops(3, LoopType.Yoyo));
        sequence.Append(image_.DOColor(new Color(1.0f * 94 / 255, 1.0f * 200 / 255, 1.0f * 72 / 255), 0f));//なんと0～1!
        sequence.Play();
        //image_.DOFillAmount(1f, s);
    }
}
