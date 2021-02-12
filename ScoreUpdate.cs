using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour 
{
    /// <summary>
    /// This is used to update the score 
    /// </summary>

    [SerializeField]
    private Text text;

    // Used to update the score on screen
    public void UpdateScore(int val)
    {
        text.text = val.ToString();
    }
}
