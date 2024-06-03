using UnityEngine;

public class RotateAvatar : MonoBehaviour
{
    public float rotationSpeed = 100f; // 회전 속도 조절

    void Update()
    {
        // 마우스 우클릭 드래그 시 회전
        if (Input.GetMouseButton(1)) // 우클릭: 마우스 버튼 1
        {
            float rotX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            float rotY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

            // 디버그 로그 추가
            Debug.Log("Mouse X: " + rotX + " Mouse Y: " + rotY);

            // 아바타를 회전시킵니다.
            transform.Rotate(Vector3.up, -rotX, Space.World);
            transform.Rotate(Vector3.right, rotY, Space.Self);
        }
    }
}
