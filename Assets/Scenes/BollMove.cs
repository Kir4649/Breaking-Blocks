using UnityEngine;

public class BollMove : MonoBehaviour
{
    // �{�[���̈ړ��̑������w�肷��ϐ�
    public float speed = 5f;
    Rigidbody myRigidbody;

    void Start()
    {
        // Rigidbody�ɃA�N�Z�X���ĕϐ��ɕێ����Ă���
        myRigidbody = GetComponent<Rigidbody>();
        // �E�΂�45�x�ɐi��
        myRigidbody.linearVelocity = new Vector3(speed, speed, 0f);
    }
}
