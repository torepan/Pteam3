using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result_Move : MonoBehaviour
{

    //text
    public GameObject FinishText;
    //object
    public GameObject cam;
    //value
   





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //CamMove();
    }

    //ゲーム終了時に呼び出す関数
    public void CamMove()
    {
        //終了テロップの表示
        FinishText.SetActive(true);
        //一定位置までカメラの移動
        Vector3 camPos = cam.transform.position;
        if (camPos.y <= 15)
        {
            camPos.y += 0.02f;
            camPos.z -= 0.02f;
            cam.transform.position = camPos;
        }
        else
        {
            //一定以上下がると停止、演出を流す
            Debug.Log("CutIn");
        }

      



    }

   
   

 //--------デバッグ用-----------

    public void Restart()
    {
        SceneManager.LoadScene("NakazawaScene");
    }

}
