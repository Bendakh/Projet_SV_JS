using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EndGamePanelScript : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI endGameTitle;
    [SerializeField]
    private TextMeshProUGUI endGameParagraph;
    [SerializeField]
    private TextMeshProUGUI someInformation;

    [SerializeField]
    [TextArea(15, 20)]
    private string[] randomTextArray;

    public void SetWonPanel()
    {
        endGameTitle.text = "You Won!";
        endGameParagraph.text = "You won the game by defeating the enemy tribe and preserving the island's ressources!";
        someInformation.text = randomTextArray[Random.Range(0, randomTextArray.Length)];
    }

    public void SetLostPanel()
    {
        endGameTitle.text = "You Lose!";
        endGameParagraph.text = "The enemy tribe defeated you!";
        someInformation.text = randomTextArray[Random.Range(0, randomTextArray.Length)];
    }

    public void SetLostPanelByRessource()
    {
        endGameTitle.text = "You Lose!";
        endGameParagraph.text = "You couldn't preserve the island's ressources!";
        someInformation.text = randomTextArray[Random.Range(0, randomTextArray.Length)];
    }

    
}
