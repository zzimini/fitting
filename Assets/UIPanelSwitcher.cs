using UnityEngine;
using UnityEngine.UI;

public class UIPanelSwitcher : MonoBehaviour
{
    public GameObject initialPanel; // �ʱ� ��ư �г�
    public GameObject changedPanel; // ����� ��ư �г�
    public Button switchButton; // �г� ��ȯ ��ư (InitialPanel�� �ִ� wardrobe ��ư)
    public Button backButton; // �ڷ� ���� ��ư (ChangedPanel�� �ִ� ��ư)

    void Start()
    {
        // �ʱ� �г� Ȱ��ȭ �� ����� �г� ��Ȱ��ȭ
        initialPanel.SetActive(true);
        changedPanel.SetActive(false);

        // ��ư Ŭ�� �̺�Ʈ ���
        switchButton.onClick.AddListener(OnSwitchButtonClick);
        backButton.onClick.AddListener(OnBackButtonClick);
    }

    void OnSwitchButtonClick()
    {
        Debug.Log("Switch button clicked"); // ����� �α� �߰�
        // �ʱ� �г� ��Ȱ��ȭ �� ����� �г� Ȱ��ȭ
        initialPanel.SetActive(false);
        changedPanel.SetActive(true);
    }

    void OnBackButtonClick()
    {
        Debug.Log("Back button clicked"); // ����� �α� �߰�
        // �ʱ� �г� Ȱ��ȭ �� ����� �г� ��Ȱ��ȭ
        initialPanel.SetActive(true);
        changedPanel.SetActive(false);
    }
}
