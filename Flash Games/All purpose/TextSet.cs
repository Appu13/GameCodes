using UnityEngine.UI;
using UnityEngine;

public class TextSet : MonoBehaviour {

    /// <summary>
    /// Used to set the added text
    /// </summary>
    public Text text;

	public void SetText(int value)
    {
        text.text = value.ToString();
    }
}
