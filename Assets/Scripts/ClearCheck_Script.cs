using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 茶柱角度からクリアの判定
/// タイマー機能
/// </summary>
public class ClearCheck_Script: MonoBehaviour
{
    [SerializeField] Tyabasira_Script Tyabasira_;
    [SerializeField] int timeLimit=10;
    [SerializeField] int[] rankThreshold = new int[4];//SABC
    bool isFin = false;//終了しているかどうか
    float timeCount = 0f;//開始からの時間

    void TimeReset()
    {
        isFin = false;
        timeCount = 0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        TimeReset();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isFin)
        {
            if (timeCount <= timeLimit) timeCount += Time.deltaTime;
            else CalcRank();
        }
        
    }

    public int CalcRank()
    {
        float angleXZ = CalcAngle() ;
        int rank = 0;
        for (int i=0;i<rankThreshold.Length;i++)
        {
            if (angleXZ<=rankThreshold[i])
            {
                rank = i;
                break;
            }
        }
        return rank;
    }

    float CalcAngle()
    {
        float x = Tyabasira_.angleX;
        float z = Tyabasira_.angleZ;

        return (x > z) ? x : z;//大きいほうを返すのでよいのでは？
        //return -1;
    }
}
