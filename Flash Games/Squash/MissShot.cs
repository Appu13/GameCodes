using UnityEngine;

public class MissShot : MonoBehaviour 
{
    /// <summary>
    /// This is to handle the miss shots by the player
    /// </summary>
    public GameManagerSquash gm;
    public Ball ball;
    public PlayerCharecterstics pc;


    void Start()
    {
        // Error handling
        if(gm==null)
        {
            Debug.LogError("Manager missing");
        }

        if(ball==null)
        {
            Debug.LogError("Ball missing");
        }    

        if(pc ==null)
        {
            Debug.LogError("Player missing");
        }
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        // Reset if the player life is not 0
        if (pc.GetPlayerLives() > 0)
        {
            pc.ReduceLives();
            Debug.Log("Missed Shot " + pc.GetPlayerLives());
            gm.UpdateScore();
            ball.Reset();
        }
        else
        {
            gm.EndGame();
        }
    }
}
