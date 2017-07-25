using UnityEngine;

public class Health : MonoBehaviour {

    public float health;

    public void DealDamage(float Damage)
    {
        health -= Damage;
        if(health<=0)
        {
            Destroy(gameObject);
        }
    }
}
