using UnityEngine;
using UnityEngine.Serialization;

public class GroundSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public GameObject blockPrefab;

    public float lastY;
    
    void Start()
    {
        lastY = 0f;
    }

    public void SpawnOne(float xPos, float yPos)
    {
       
        Vector3 spawnPos = new Vector3(xPos, yPos-1, 0);
        GameObject newBlock = Instantiate(blockPrefab, spawnPos, Quaternion.identity);
        lastY = newBlock.transform.position.y;
    }
}
