using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCtrl : MonoBehaviour
{
    public GameObject ClearText;
    public GameObject GameOverText;

    public GameObject RetryButton;

    void Start()
    {
        
    }


    void Update()
    {
        int count   = GameObject.FindGameObjectsWithTag("Block").Length;
        int count1  = GameObject.FindGameObjectsWithTag("Player").Length;

        if (count == 0)
        {
            ClearText.SetActive(true);
            //クリアしたらBallを消滅
            GameObject obj = GameObject.Find("Ball");
            Destroy(obj);
        }

        //Ballがなくなりかつ、Blockが残っているときにゲームオーバー
        if (count1 == 0 && count != 0)
        {
            //ゲームオーバー、リトライボタン表示
            GameOverText.SetActive(true);
            RetryButton.SetActive(true);
        }
    }

    public void PushRetryButton()
    {
        //現在のScene名を取得する
        Scene loadScene = SceneManager.GetActiveScene();
        //Sceneの読み直し
        SceneManager.LoadScene(loadScene.name);
    }
}
