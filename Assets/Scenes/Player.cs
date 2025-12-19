using UnityEngine;

public class Player : MonoBehaviour
{
    // �v���C���[�̈ړ��̑���
    public float speed = 10f;
    Rigidbody myRigidbody;

    void Start()
    {
        // Rigidbody�ɃA�N�Z�X���ĕϐ��ɕێ�
        myRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // ���E�ړ�
        myRigidbody.linearVelocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0f, 0f);
    }
}
