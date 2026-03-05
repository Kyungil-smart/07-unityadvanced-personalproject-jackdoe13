using UnityEngine;

public class PlayerDig : MonoBehaviour
{

    public GroundSpawner spawner;
    
    public ScoreUI scoreUI;

    public GameObject digParticle;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    
    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1f);
            if (hit.collider != null)
            {
                Vector3 pos = hit.collider.transform.position;
                pos.x += Random.Range(-0.2f, 0.2f);
                pos.y += Random.Range(-0.2f, 0.2f);
                
                Destroy(hit.collider.gameObject);
                Instantiate(digParticle, pos, Quaternion.identity);
                scoreUI.AddScore();
                spawner.SpawnOne(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y);
                transform.position = transform.position + Vector3.down;
            }
            
        }
        
    }
}
