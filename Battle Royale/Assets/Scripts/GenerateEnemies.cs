using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject theEnemy;
    public int numberOfEnemies;
    int enemiesCreated;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateEnemies());
    }

    IEnumerator CreateEnemies()
    {
        float yPosition = .4F;
        float xPosition = 0;
        float zPosition = 0;
        while (enemiesCreated < numberOfEnemies)
        {
            xPosition = Random.Range(-8,8);
            zPosition = Random.Range(-8,8);
            Instantiate(theEnemy, new Vector3(xPosition, yPosition, zPosition),Quaternion.identity);
            enemiesCreated++;
            Debug.Log(enemiesCreated);
            yield return new WaitForSeconds(3f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
