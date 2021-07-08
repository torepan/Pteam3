using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove_Script : MonoBehaviour
{
    [SerializeField] GameObject Place1;
    [SerializeField] GameObject Place2;
    [SerializeField] GameObject Place3;
    [SerializeField] GameObject Place4;
    [Header("動くやつ")][SerializeField] GameObject Cube;
    [SerializeField] Fairyinformation_Script Finfo_;

    private void Update()
    {
        if (Finfo_.place == 1)
        {
            Cube.transform.position = Place1.transform.position;
        }
        if (Finfo_.place == 2)
        {
            Cube.transform.position = Place2.transform.position;
        }
        if (Finfo_.place == 3)
        {
            Cube.transform.position = Place3.transform.position;
        }
        if (Finfo_.place == 4)
        {
            Cube.transform.position = Place4.transform.position;
        }
    }


}
