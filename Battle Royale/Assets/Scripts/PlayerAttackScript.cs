using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{
    // Start is called before the first frame update
    bool isAttacking = false;
    public ParticleSystem bulletParticleSystem;
    ParticleSystem.EmissionModule em;

    float attackTimer = 0f;
    float firingRate = 5f;
    int bulletCounter = 0;
    void Start()
    {
        em = bulletParticleSystem.emission;
    }

    // Update is called once per frame
    void Update()
    {       
        isAttacking = Input.GetMouseButton(0);        
        attackTimer += Time.deltaTime;
        if (isAttacking && attackTimer >=1f/firingRate)
        {
            attackTimer = 0;
            //Attack();
        }        
        if (isAttacking)
            em.rateOverTime = firingRate;
        else
            em.rateOverTime = 0f;      
    }

    void Attack()
    {
        Ray ray = new Ray(bulletParticleSystem.transform.position, bulletParticleSystem.transform.forward);
        bulletCounter++;
        // CHeck for collision and reduce health.
    }
}
