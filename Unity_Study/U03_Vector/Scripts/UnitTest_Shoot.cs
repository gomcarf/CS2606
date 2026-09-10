using UnityEditor;
using UnityEngine;

public class UnitTest_Shoot : MonoBehaviour
{
    [SerializeField]
    private GameObject target;

    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private float length = 1.0f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = Instantiate<GameObject>(prefab);
            Rigidbody2D rigid = obj.GetComponent<Rigidbody2D>();

            Vector2 value1 = transform.position; //자신의 위치
            Vector2 value2 = target.transform.position; //target의 위치

            Vector2 direction = value2 - value1;//SHOOT -> 타겟으로 방향 설정
            direction.Normalize();

            rigid.AddForce(direction * length); //direction 방향으로 lenght 크기 만큼 힘을 주면 총알이 나가겠찌
            Destroy(obj, 3.0f);//발사된 obj들은 3초 뒤에 삭제
        }
    }

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
