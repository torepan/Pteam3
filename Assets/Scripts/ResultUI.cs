using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//文字をフェードインさせるスクリプト
public class ResultUI : MonoBehaviour
{
    public float speed = 0.01f;  //透明化の速さ
    float alfa;    //A値を操作するための変数
    float red, green, blue;    //RGBを操作するための変数

    void Start()
    {
        //Panelの色を取得
        red = GetComponent<Text>().color.r;
        green = GetComponent<Text>().color.g;
        blue = GetComponent<Text>().color.b;
    }

    void Update()
    {
        Invoke("WardResult", 3f);
        GetComponent<Text>().color = new Color(red, green, blue, alfa);
    }

    void WardResult()
    {
        alfa += speed;
    }
}