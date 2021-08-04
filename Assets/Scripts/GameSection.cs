using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSection : MonoBehaviour
{
    public GameState state;
    // Start is called before the first frame update
    void Start()
    {
        GameLogic.OnStateChange.AddListener(HandleStateChange);
        if (!(state == GameState.Menu)) gameObject.SetActive(false);   
    }

    private void HandleStateChange()
    {
        if (GameLogic.State == state) gameObject.SetActive(true);
        else gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
