using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wall : MonoBehaviour
{ 
    // Update is called once per frame
    void Update()
    {
        transform.Translate(GameManager.Instance.speed *0.2f*Time.deltaTime, 0, 0);
        GameManager.Instance.speed -= Time.deltaTime;
        if (transform.position.x < -10)
        {
            GameManager.Instance.Score++;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
