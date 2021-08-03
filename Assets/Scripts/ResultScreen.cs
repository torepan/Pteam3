using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ResultScreen : MonoBehaviour
{
    float fadeSpeed = 0.005f;
    float red, green, blue, alfa;

    public bool isFadeOut = false;  //フェードアウト処理の開始か

    Image fadeImage;

    void Start()
    {
        fadeImage = GetComponent<Image>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
    }


    void Update()
    {
        /* if (isFadeOut)
          {
              StartFadeOut();
          }*/
        StartFadeOut();
        Invoke("ChangeScene", 2.0f);
    }

    void StartFadeOut()
    {
        fadeImage.enabled = true;
        alfa += fadeSpeed;
        SetAlpha();
        if (alfa >= 1)
        {
            isFadeOut = false;
        }
    }

    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("yamakawa");
    }
}