using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearCha : MonoBehaviour
{
    private GameObject nearObj;
    private Vector3 PlayerPosition = Vector3.zero;  //プレイヤーの位置

    void Start()
    {
        //最も近いオブジェクトを取得
        nearObj = Search(gameObject, "Tip");
    }

    // Update is called once per frame
    void Update()
    {
        //左クリックされたら最も近いオブジェクトを取得
        if (Input.GetMouseButtonDown(0))
        {
            nearObj = Search(gameObject, "Tip");
            transform.LookAt(nearObj.transform);
            PlayerPosition = transform.position;
            OnClick();
        }
    }

    GameObject Search(GameObject obj, string tagName)
    {
        float Dis = 0;      //距離
        float nearDis = 0;  //一番近いオブジェクトの距離

        GameObject targetObj = null;   //目標のオブジェクト
  

        foreach (GameObject obs in GameObject.FindGameObjectsWithTag(tagName))
        {
            //自身と取得したオブジェクトの距離を取得
            Dis = Vector3.Distance(obs.transform.position, obj.transform.position);

            if (nearDis == 0 || nearDis > Dis)
            {
                nearDis = Dis;
                //nearObjName = obs.name;
                targetObj = obs;
            }
        }
        return targetObj;
    }

    void OnClick()
    {
        //近い端の位置
        Vector3 ChaPos = nearObj.transform.position;
        //ロープの長さ
        Vector3 RopePos = (ChaPos - PlayerPosition) / 2.0f;
        //kyori 
        float dis = Vector3.Distance(ChaPos, PlayerPosition);

        transform.position = RopePos;
        transform.localScale = new Vector3(0.3f, 0.3f, dis);
        //transform.LookAt(ChaPos);
    }

}
