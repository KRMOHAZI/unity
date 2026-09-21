using UnityEngine;

public class UIToggle : MonoBehaviour
{
    [Tooltip("열고 닫을 대상 UI 패널 또는 오브젝트")]
    [SerializeField] private GameObject targetUI;

    /// <summary>
    /// 버튼 OnClick 이벤트에 연결할 함수
    /// </summary>
    public void ToggleUI()
    {
        if (targetUI != null)
        {
            // 현재 활성화 상태를 가져와서 반대값으로 설정 (켜져있으면 끄고, 꺼져있으면 킴)
            bool isActive = targetUI.activeSelf;
            targetUI.SetActive(!isActive);
        }
        else
        {
            Debug.LogWarning("Target UI가 지정되지 않았습니다!");
        }
    }
}