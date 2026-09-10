using UnityEditor;
using UnityEngine;

public class UnitTest_Normalize : MonoBehaviour
{
    [SerializeField]
    private GameObject target;

    [SerializeField]
    private float length = 1.0f;

    private void OnDrawGizmos()
    {
        Vector2 value1 = transform.position; //자신의 위치
        Vector2 value2 = target.transform.position; //target의 위치

        GUIStyle style = GUIStyle.none;
        style.normal.textColor = Color.white;
        style.alignment = TextAnchor.MiddleCenter;

        Handles.Label(value1, value1.ToString(), style);

        Vector2 result = value2 - value1;
        result.Normalize(); //스스로 정규화
        Handles.Label(result, result.ToString(), style);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(value1, result * length);
    }
}
