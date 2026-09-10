using NUnit.Framework.Constraints;
using UnityEditor;
using UnityEngine;

public class UnitTest_Minus : MonoBehaviour
{
    [SerializeField]
    Vector2 value1 = new Vector2(4, 3);

    [SerializeField]
    Vector2 value2 = new Vector2(2, 1);

    private void OnDrawGizmos()//게임 화면에는 보이지 않고 씬 화면에서만 보임
    {
        GUIStyle style = GUIStyle.none;
        style.normal.textColor = Color.white;
        style.alignment = TextAnchor.MiddleCenter;

        Handles.Label(value1, value1.ToString(), style);

        Vector2 result = value1 - value2;
        //Handles.Label(value2, value2.ToString(), style);
        Handles.Label(result, result.ToString(), style);

        Gizmos.color = Color.red;
        Gizmos.DrawLine(value1, result);
    }

}
