using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] branchReference;

    private GameObject spawnedBranch;

    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomIndex;
    private float randomLength1;
    private float randomLength2;

    void Start()
    {
        StartCoroutine(SpawnBranches());
    }

    IEnumerator SpawnBranches()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 4));

            randomIndex = Random.Range(0, branchReference.Length);

            randomLength1 = Random.Range(0.9f, (3f - 0.9f) / 2f);
            randomLength2 = 3f - randomLength1;

            GameObject spawnedBranch1 = Instantiate(branchReference[randomIndex]);
            spawnedBranch1.transform.position = leftPos.position;
            spawnedBranch1.transform.localScale = new Vector3(randomLength1 * Random.Range(-1f, 1f), 1f, 1f);

            GameObject spawnedBranch2 = Instantiate(branchReference[randomIndex]);
            spawnedBranch2.transform.position = rightPos.position;
            spawnedBranch2.transform.localScale = new Vector3(-randomLength2 * Random.Range(-1f, 1f), 1f, 1f);
        }
    }
}
