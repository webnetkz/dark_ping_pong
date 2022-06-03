using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockAnimation : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
      this.transform.localScale = new Vector2(0.1f, 8f);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
      this.transform.localScale = new Vector2(1f, 8f);
    }
}
