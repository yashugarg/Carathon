// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    
    public Text ScoreCard;

    void Update()
    {
        ScoreCard.text = player.position.z.ToString("0");
    }
}