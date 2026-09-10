using NUnit.Framework.Constraints;
using UnityEngine;

public class UnitTest_Direction : MonoBehaviour
{
    [SerializeField]
    private float length = 1.0f;

    private void OnDrawGizmos()
    {
        Vector2 value1 = new Vector2(0, 1); //A위치
        Vector2 value2 = new Vector2(0, 0); //B위치
        Vector2 result = value1 - value2;

        print($"result의 크기 : {result.magnitude}");//magnitude : 벡터의 크기를 알려줌

        Gizmos.color = Color.green;
        Gizmos.DrawLine(new Vector2(0, 0), result);

        Vector2 position = transform.position;
        Vector2 result2 = position + result;
        Gizmos.color = Color.red;
        Gizmos.DrawLine(position, result2);

        Vector2 result3 = (value1 - value2).normalized * length;//정규화된 값을 리턴

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(new Vector2(0, 0), result3);
    }
}
