using UnityEngine;

public class AttackersSpawners : MonoBehaviour
{
    public GameObject[] SpawnMinions;
    

    private void Update()
    {
        foreach (GameObject ThisAttacker in SpawnMinions)
            if (IsTimeToSpawn(ThisAttacker))
                Spawn(ThisAttacker);
    }

    void Spawn(GameObject AttackMinion)
    {
         GameObject NewClone= Instantiate(AttackMinion);
         NewClone.transform.parent = transform;
         NewClone.transform.position = transform.position;
    }

    bool IsTimeToSpawn(GameObject ThisAttacker)
    {
        float SpawnDelay = ThisAttacker.GetComponent<Attacker>().SeenEverySeconds;
        float Rate = 1 / SpawnDelay;

        if(Time.deltaTime>Rate)
        {
            Debug.LogWarning("Spawn rate capped by frame rate");
            return false;
        }

        float threshold = Rate * Time.deltaTime/5;
        if (Random.value < threshold)
            return true;
        else
            return false;

    }
}
