using System.Linq;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{ 

    Vector3 mouse;
    Vector3 mouse3d;

    // 補間の強さ（0f～1f） 。0なら追従しない。1なら遅れなしに追従する。
    [SerializeField, Range(0f, 1f)] private float followStrength;


    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        mouse = Input.mousePosition;
        mouse.z = 10f;
        mouse3d = Camera.main.ScreenToWorldPoint(mouse);
        //Debug.Log(mouse);
        //Debug.Log(mouse3d);
        transform.position = Vector3.Lerp(transform.position, mouse3d, followStrength);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("なんかでる");
        }

    }



}