using UnityEngine;

public class UnitTest_Collider : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)//µü ºÎµúÈù ¼ø°£
    {
        print($"Collision Enter : {collision.gameObject.name}");
    }

    private void OnCollisionStay2D(Collision2D collision)//ºÎµúÇô¼­ ºÙ¾îÀÖÀ» ¶§
    {
        print($"Collision Stay : {collision.gameObject.name}");
    }
    private void OnCollisionExit2D(Collision2D collision)//¶³¾îÁ³À» ¶§
    {
        print($"Collision Exit : {collision.gameObject.name}");
    }

    private void OnTriggerEnter2D(Collider2D collision)//µü ºÎµúÈù ¼ø°£
    {
        print($"Trigger Enter : {collision.gameObject.name}");
    }

    private void OnTriggerStay2D(Collider2D collision)//ºÎµúÇô¼­ ºÙ¾îÀÖÀ» ¶§
    {
        print($"Trigger Stay : {collision.gameObject.name}");
    }
    private void OnTriggerExit2D(Collider2D collision)//¶³¾îÁ³À» ¶§
    {
        print($"Trigger Exit : {collision.gameObject.name}");
    }
}
