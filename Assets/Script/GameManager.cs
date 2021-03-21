using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoSingleton<GameManager>
{
    public int Score;
    public float speed = -5;
    public Text text_score;

    public void Update()
    {
        text_score.text = text_score.text;
    }
}
