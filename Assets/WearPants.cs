using UnityEngine;
using UnityEngine.UI;

public class WearPants : MonoBehaviour
{
    public GameObject pants; // 바지 모델을 참조
    public Button wearPantsButton; // 버튼을 참조

    void Start()
    {
        // 버튼 클릭 이벤트에 OnWearPantsButtonClick 메서드를 등록
        wearPantsButton.onClick.AddListener(OnWearPantsButtonClick);
    }

    void OnWearPantsButtonClick()
    {
        // 바지 모델 활성화
        pants.SetActive(true);
    }
}
