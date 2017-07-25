using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject Projectile, ProjectileParent;

    private void Fire()
    {
        GameObject ProjectileClone = Instantiate(Projectile);
        ProjectileClone.transform.parent = ProjectileParent.transform;
        Projectile.transform.SetPositionAndRotation(transform.Find("Gun").transform.position, Quaternion.identity);
    }
}
