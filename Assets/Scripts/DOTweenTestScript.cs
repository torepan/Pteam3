using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;//←これ忘れずに
/// <summary>
/// テスト用というか、なんというか、
/// とりあえず使えそうなことを試してきます
/// 自由に書き換えてしまって大丈夫です
/// 
/// </summary>
public class DOTweenTestScript : MonoBehaviour
{
    [Header("動くやつ")]
    [SerializeField] GameObject cube;
    [Header("ゲージ")]
    [SerializeField] Image image;
    // Start is called before the first frame update
    void Start()
    {
        image.DOFillAmount(0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Dmove();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Dfill();
        }
    }

    void Dmove()
    {
        //物が、　　動く　　　原点に　　　3秒で
        cube.transform.DOMove(new Vector3(0,0,0),3f);
    }

    /// <summary>
    /// スプライトを指定したあと、ImageTypeをFilledに設定
    /// あとは出てきた項目を見て設定してくれればいけます
    /// </summary>
    void Dfill()
    {
        //UI画像が、ゲージを埋める、満タンに、2秒で
        image.DOFillAmount(1f,2f);
    }
}
