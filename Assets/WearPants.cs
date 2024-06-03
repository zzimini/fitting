using UnityEngine;
using UnityEngine.UI;

public class WearPants : MonoBehaviour
{
    public GameObject pants; // ���� ���� ����
    public Button wearPantsButton; // ��ư�� ����

    void Start()
    {
        // ��ư Ŭ�� �̺�Ʈ�� OnWearPantsButtonClick �޼��带 ���
        wearPantsButton.onClick.AddListener(OnWearPantsButtonClick);
    }

    void OnWearPantsButtonClick()
    {
        // ���� �� Ȱ��ȭ
        pants.SetActive(true);
    }
}
