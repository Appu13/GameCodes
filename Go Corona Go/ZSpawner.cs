using UnityEngine;
using System.Collections;

public class ZSpawner : MonoBehaviour 
{
    /// <summary>
    /// This is used to spawn the zombies at a fixed rate
    /// </summary>
    #region variables
	private ResourcePooler Zpool;
    #endregion variables

    void Start()
    { 
		// Getting the reference for the zombie pool
		Zpool = ResourcePooler.instance;
		// Starting the spawn z coroutine
		StartCoroutine(SpawnZ(Random.Range(0f,4f)));
				
	}

	private IEnumerator SpawnZ(float randTime)
    {
		Spawn();
		yield return new WaitForSeconds(randTime);
		StartCoroutine(SpawnZ(Random.Range(0f, 6f)));
    }

	// Used to calculate the new spawn position and call the SpawnFromPool function
	private void Spawn()
    {
		Vector3 pos = new Vector3(Random.Range(-4.67f, 4.67f), Random.Range(-2.65f, 2.65f), 0);
		Zpool.SpawnFromPool(pos);
    }
}
