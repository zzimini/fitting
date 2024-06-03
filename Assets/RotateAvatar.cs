using UnityEngine;

public class RotateAvatar : MonoBehaviour
{
    public float rotationSpeed = 100f; // ȸ�� �ӵ� ����

    void Update()
    {
        // ���콺 ��Ŭ�� �巡�� �� ȸ��
        if (Input.GetMouseButton(1)) // ��Ŭ��: ���콺 ��ư 1
        {
            float rotX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            float rotY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

            // ����� �α� �߰�
            Debug.Log("Mouse X: " + rotX + " Mouse Y: " + rotY);

            // �ƹ�Ÿ�� ȸ����ŵ�ϴ�.
            transform.Rotate(Vector3.up, -rotX, Space.World);
            transform.Rotate(Vector3.right, rotY, Space.Self);
        }
    }
}
