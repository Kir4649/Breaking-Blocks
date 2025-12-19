using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    // publicÇ…ÇµÇƒInspectorÇ©ÇÁê›íËÇ≈Ç´ÇÈÇÊÇ§Ç…Ç∑ÇÈ
    public Text gameOverMessage;
    [SerializeField]
    private GameObject BlackWall;//à√ì]Ç∑ÇÈâÊñ 

    void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(END());
        // Game OverÇ∆ï\é¶Ç∑ÇÈ
        Destroy(collision.gameObject);
    }
    private IEnumerator END()
    {
        gameOverMessage.text = "Game Over";
        while (true)
        {
            if (BlackWall.GetComponent<Image>().color.a != 1)
            {
                BlackWall.GetComponent<Image>().color += new Color(0, 0, 0, Time.deltaTime / 2);
                if (BlackWall.GetComponent<Image>().color.a >= 1)
                {
                    Time.timeScale = 0;

                    SceneManager.LoadScene("StartGame");
                }
            }
            yield return null;
        }
    }
}
