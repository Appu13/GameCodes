using System.Collections.Generic;
using UnityEngine;

public class ResourcePooler : MonoBehaviour 
{
    /// <summary>
    /// This is used to pool the zombies resources 
    /// </summary>
   
	#region Variables

    // This class and list is used to get the zombie prefab and number prefabs to be used
    [System.Serializable]
	public class Pool
    {
		public GameObject prefab;
    }
	public List<Pool> pools;
	public static ResourcePooler instance;
	// This is used to queue up all the game objects to be spawned 
	private Queue<GameObject> objPool;
    #endregion Variables

    // Use this for initialization
    void Start () 
	{
		instance = this;
		objPool = new Queue<GameObject>();
		foreach(Pool pool in pools)
        {
			// Instantiate all the game objects and store them in the queue
			GameObject obj = Instantiate(pool.prefab);
			obj.SetActive(false);
			objPool.Enqueue(obj);

        }

	}

    // This method is used to spawn an object from the pool based on a supplied location	
	public void SpawnFromPool(Vector3 position)
    {
		GameObject objectToSpawn = objPool.Dequeue();
		objectToSpawn.transform.position = position;
		objectToSpawn.gameObject.SetActive(true);

		//Adding the element back to the queue
		objPool.Enqueue(objectToSpawn);
    }
}
