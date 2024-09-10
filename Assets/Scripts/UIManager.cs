using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;


    private void Start()
    {
        DisplayScore();
        Pickup.onCollectingPickup += DisplayScore;
    }

    private void DisplayScore()
    {
        int playerScore = GameManager.Instance.GetPlayerScore();
        scoreText.text = playerScore.ToString();
    }

    private void OnDestroy()
    {
        Pickup.onCollectingPickup -= DisplayScore;
    }
}
