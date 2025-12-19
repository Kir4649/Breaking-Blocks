using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameClear : MonoBehaviour
{
    Transform myTransform;
    public Text gameClearMessage;
    void Start()
    {
        // Transformコンポーネントを保持しておく
        myTransform = transform;
    }

    void Update()
    {
        // 子供がいなくなったらゲームを停止する
        if (myTransform.childCount == 0)
        {
            gameClearMessage.text = "Game Clear";
            SceneManager.LoadScene("StartGame");
            Time.timeScale = 0f;
        }
    }
}
