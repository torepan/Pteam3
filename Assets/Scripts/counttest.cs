using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;  //DOTweenを使うときはこのusingを入れる

public class counttest : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timerText;
   
    public float totalTime;
    int seconds;

    // Use this for initialization
    void Start()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(this.timerText.DOFade(endValue: 0f, duration: 1f).SetLoops((int)totalTime, LoopType.Restart));
        sequence.Join(this.timerText.transform.DOScale(0.3f,1f).SetLoops((int)totalTime, LoopType.Restart));
    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        seconds = (int)totalTime;
        timerText.text = seconds.ToString();

    }
}
