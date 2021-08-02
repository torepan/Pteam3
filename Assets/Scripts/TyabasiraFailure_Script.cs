using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 子供のy座標を比較して、自分より下だったら終了を飛ばす
/// </summary>
public class TyabasiraFailure_Script : MonoBehaviour
{
    ClearCheck_Script ClearCheck_;
    [SerializeField] GameObject checkPoint;
    

    // Update is called once per frame
    void Update()
    {
        if (checkPoint.transform.position.y< transform.position.y)
        {
            Debug.Log("横になった！");
            ///
        }    
    }
}
