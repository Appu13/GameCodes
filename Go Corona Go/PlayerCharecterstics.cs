using UnityEngine;


public class PlayerCharecterstics : MonoBehaviour
{
    /// <summary>
    /// Used to control the various properties of the player
    /// </summary>

    #region Variables
    private float infection = 0f;
    public float rateOfIncrease = 0.01f;
    public InfectionBar ib;
    public static PlayerCharecterstics instance;
    public GameObject blood;
    private GameManager gm;
    #endregion


    #region Methods
    void Start()
    {
        gm = GameManager.gm;
        if(gm==null)
        {
            Debug.LogError("Missing");
        }

    }
    private void Update()
    {

        infection += rateOfIncrease;
        ib.SetBar(infection);

    }



    // Getter method for infection
    public float GetInfection()
    {
        return infection;
    }

    // Used to reset the values of infection and rate of increase
    public void Set(float _infection, float _rateOfIncrease)
    {
        infection = _infection;
        rateOfIncrease = _rateOfIncrease;
    }

    // Used to update the rate of infection 
    public void UpdateRate(float rate)
    {
        rateOfIncrease += rate;
    }

    // Method to perform action once the player looses all his lives
    public void KillPlayer()
    {
        // Instantiate the blood and remove the player from the scene
        Instantiate(blood, gameObject.transform.position, Quaternion.identity);
        gameObject.SetActive(false);

        // Call the dead player method from game manager
        gm.DeadPlayer();
    }

    #endregion

}
