using UnityEngine;
using UnityEngine.UI;

public class UIPanelSwitcher : MonoBehaviour
{
    public GameObject initialPanel; // 초기 버튼 패널
    public GameObject changedPanel; // 변경될 버튼 패널
    public Button switchButton; // 패널 전환 버튼 (InitialPanel에 있는 wardrobe 버튼)
    public Button backButton; // 뒤로 가기 버튼 (ChangedPanel에 있는 버튼)

    void Start()
    {
        // 초기 패널 활성화 및 변경될 패널 비활성화
        initialPanel.SetActive(true);
        changedPanel.SetActive(false);

        // 버튼 클릭 이벤트 등록
        switchButton.onClick.AddListener(OnSwitchButtonClick);
        backButton.onClick.AddListener(OnBackButtonClick);
    }

    void OnSwitchButtonClick()
    {
        Debug.Log("Switch button clicked"); // 디버그 로그 추가
        // 초기 패널 비활성화 및 변경될 패널 활성화
        initialPanel.SetActive(false);
        changedPanel.SetActive(true);
    }

    void OnBackButtonClick()
    {
        Debug.Log("Back button clicked"); // 디버그 로그 추가
        // 초기 패널 활성화 및 변경될 패널 비활성화
        initialPanel.SetActive(true);
        changedPanel.SetActive(false);
    }
}
