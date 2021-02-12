using UnityEngine;
using UnityEngine.UI;

public class SetText : MonoBehaviour 
{
    /// <summary>
    /// Used to update the text once the scene is loaded
    /// </summary>

    public Text text;

    void Start()
    {
        text.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
}
