using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KabeOut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("Master").GetComponent<GameMaster>().GameOver(40-GameObject.Find("Master").GetComponent<GameMaster>().boxNum+"個壊しました。また挑戦しよう");
    }
}
