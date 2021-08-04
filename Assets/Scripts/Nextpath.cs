using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nextpath : MonoBehaviour
{
    public GameState gamestate;

    private void OnMouseDown()
    {
        GameLogic.ChangeState(gamestate);
    }
}
