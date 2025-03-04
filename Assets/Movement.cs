using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject coinPrefab; // Assign the Coin Prefab in Inspector
    private bool coinSpawned = false; // Prevent multiple coins from spawning
    //private Vector3 spawnOffset = new Vector3(-2, 0, 0); // Spawns 2 units to the left
    [SerializeField] float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        float z = speed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Translate(x * Vector3.right + z * Vector3.forward);

        if (Input.GetKeyDown(KeyCode.Space) && !coinSpawned)
        {
            Instantiate(coinPrefab, transform.position + Vector3.right * 2f, Quaternion.identity);
            coinSpawned = true; // Ensure only one coin spawns
        }
    }
    
}
