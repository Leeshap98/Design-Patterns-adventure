using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int playerScore = 0;


    private void Awake()
    {
        Instance = this;
        playerScore = PlayerPrefs.GetInt("PlayerScore");
    }

    private void OnEnable()
    {
        Pickup.onCollectingPickup += HandlePickupCollected;
    }

    private void HandlePickupCollected()
    {
        playerScore++;
        PlayerPrefs.SetInt("PlayerScore", playerScore);
    }

    private void OnDestroy()
    {
        Pickup.onCollectingPickup -= HandlePickupCollected;
    }

    public int GetPlayerScore()
    {
        return playerScore;
    }


}
