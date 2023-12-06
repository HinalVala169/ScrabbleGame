using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnLetters : MonoBehaviour
{
    private char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
    [SerializeField]
    private TMP_Text[] text; 
    // Start is called before the first frame update
    void Start()
    {
         GenerateLetter();
    }
    void GenerateLetter(){
          for (int i = 0; i < 7; i++)
           {
            int randomIndex = Random.Range(0, alphabet.Length);
            char randomLetter = alphabet[randomIndex];
            text[i].text = randomLetter.ToString();
          }
        }
}
