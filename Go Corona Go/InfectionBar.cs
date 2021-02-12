using UnityEngine;
using UnityEngine.UI;
public class InfectionBar : MonoBehaviour 
{
    /// <summary>
    /// This script is used to control the health bar 
    /// once it becomes full then call the kill player function from game manager
    /// </summary>
    #region Variables
    [SerializeField]
    private Slider slider;
    public PlayerCharecterstics pc;
    public Heart hearts;
    #endregion


    #region Methods
    public void SetBar(float value)
    {
        slider.value = value;

        // If the bar becomes full then we can reset the bar
        if (slider.value.Equals(slider.maxValue))
        {
            Reset();
        }
    }

    // Function to call the set function from player charecterstics and remove the hearts
    private void Reset()
    {
        pc.Set(0, 0.01f);
        hearts.RemoveHeart();
    } 
    #endregion
}
