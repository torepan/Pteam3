using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyButton_Script : MonoBehaviour
{
    [SerializeField]
    GameObject Tyabasira;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ready(){
        Debug.Log("準備完了");
        Tyabasira.SetActive (true);
    }
}
