using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameLogic : MonoBehaviour
{
    static GameState myState;
    public static GameState State
    {
        get { return myState; }
        private set
        {
            myState = value;
            OnStateChange.Invoke();
        }
    }
    public static UnityEvent OnStateChange = new UnityEvent();
    // Start is called before the first frame update
    void Start()
    {
        State = GameState.Menu;  
    }

    public static void ChangeState(GameState toWhat)
    {
        State = toWhat;
    }

    public void goWorldmap()
    {
        State = GameState.Pathway1;
    }
}
 public enum GameState
{
    Menu,
    Pathway1,
    Pathway2,
    Pathway3,
    BattleO1,
    BattleO2,
    BattleO3
}