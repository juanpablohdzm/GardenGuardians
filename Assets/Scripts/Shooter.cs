using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject Projectile;
    private static GameObject ProjectileParent;
    
    private void Start()
    {
        ProjectileParent = GameObject.Find("Projectiles");
        if(ProjectileParent==null)
        ProjectileParent = new GameObject("Projectiles");
    }

    private void Fire()
    {
        GameObject ProjectileClone = Instantiate(Projectile);
        ProjectileClone.transform.parent = ProjectileParent.transform;
        Projectile.transform.SetPositionAndRotation(transform.Find("Gun").transform.position, Quaternion.identity);
    }
}
