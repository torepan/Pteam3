using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result_Move : MonoBehaviour
{

    //text
    public GameObject FinishText;
    public GameObject ResultDammy;
    //object
    public GameObject Tyabashira;
    public GameObject cam;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ゲーム終了時に呼び出す関数
    public void Result()
    {
        
        //茶柱の角度を求める

        FinishText.SetActive(true);
        
        //カメラ移動


        FairyRun();

        //呼び出す演出の選択

        Directing();

    }

    //妖精が退散する関数
    private void FairyRun()
    {

    }

    //演出を呼び出す関数
    private void Directing()
    {
        ResultDammy.SetActive(true);
    }

 //--------デバッグ用-----------

    public void Restart()
    {
        SceneManager.LoadScene("NakazawaScene");
    }

}
