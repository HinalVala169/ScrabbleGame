using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerTurn : MonoBehaviour
{
    public Button startBtn;
    public TMP_Text text; 

    [SerializeField]
    private List<Player> players = new();
    private int currentPlayer = 0;

    void Start()
    {
         StartTurn();
    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           NextTurn();
        }
    }

    void StartTurn()
    {
        players[currentPlayer].gameObject.SetActive(true);
        text.enabled  = true;
    }

  
    void NextTurn()
    {
        currentPlayer++;
        if (currentPlayer >= players.Count)
        {
           text.enabled  = false;
           startBtn.gameObject.SetActive(true);
           currentPlayer = 0;
        }

        StartTurn();
    }

    public void StartGame()
    {
       gameObject.SetActive(false); 
    }
}
