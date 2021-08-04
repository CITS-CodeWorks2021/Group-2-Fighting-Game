using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destination : MonoBehaviour
{
    public GameState myTarget;
    public Transform safeLocation;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameLogic.ChangeState(myTarget);
        collision.gameObject.transform.position = safeLocation.position;
    }
}
