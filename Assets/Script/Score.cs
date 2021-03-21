using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // (시간*100)+(장애물 넘은 횟수*1000)
    public float Time_score;

    void Start()
    {
        //GameManager.Instance.text_score.text = "Score : 0";
    }

    // Update is called once per frame
    void Update()
    {
        Time_score += Time.deltaTime;
        GameManager.Instance.text_score.text = "Score : " + Mathf.Round(Time_score  * 100 + GameManager.Instance.Score * 1000);
    }
}
