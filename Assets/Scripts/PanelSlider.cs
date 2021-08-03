﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSlider : MonoBehaviour
{
    public AnimationCurve animCurve = AnimationCurve.Linear(0, 0, 1, 1);
    public Vector3 inPosition;        // スライドイン後の位置
    public Vector3 outPosition;      // スライドアウト後の位置
    public float duration;    // スライド時間（秒）

    public void Start()
    {
        StartCoroutine("SlideOut");
    }

    // スライドイン（Pauseボタンが押されたときに、これを呼ぶ）
    public void SlideIn()
     {
        //yield return new WaitForSeconds(1.0f);
         StartCoroutine(StartSlidePanel(true));
     }

     // スライドアウト
     public IEnumerator SlideOut()
     {
        yield return new WaitForSeconds(1.0f);
         StartCoroutine(StartSlidePanel(false));
     }
   
    private IEnumerator StartSlidePanel(bool isSlideIn)
    {
        float startTime = Time.time;    // 開始時間
        Vector3 startPos = transform.localPosition;  // 開始位置
        Vector3 moveDistance;            // 移動距離および方向

        if (isSlideIn)
            moveDistance = (inPosition - startPos);
        else
        {
            moveDistance = (outPosition - startPos);

            while ((Time.time - startTime) < duration)
            {
                transform.localPosition = startPos + moveDistance * animCurve.Evaluate((Time.time - startTime) / duration);
                yield return 0;        // 1フレーム後、再開
            }
            transform.localPosition = startPos + moveDistance;
        }
    }
}
