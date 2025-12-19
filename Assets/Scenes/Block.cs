using UnityEngine;

public class Block : MonoBehaviour
{
    //壊されたときに出現させるボール
    [SerializeField] GameObject Boll;

    void OnCollisionEnter(Collision collision)
    {
        Instantiate(Boll);
    // ゲームオブジェクトを削除するメソッド
    Destroy(gameObject);
    }
}
