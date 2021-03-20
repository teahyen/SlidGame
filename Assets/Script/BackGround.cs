using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    [Header("배경화면")]
    public GameObject quadObject;

    private Renderer quadRanderer;
    [Header("움직이는 속도")]
    float scrollSpeed = 0.5f;

    public void Start()
    {
        quadRanderer = quadObject.GetComponent<Renderer>();
    }
    void Update()
    {
        Vector2 textureOffset = new Vector2(Time.time * scrollSpeed, 0);
        quadRanderer.material.mainTextureOffset = textureOffset;
    }
}
