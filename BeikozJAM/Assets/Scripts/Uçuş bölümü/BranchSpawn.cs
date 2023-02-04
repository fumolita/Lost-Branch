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
    private int randomSide;
    private float randomLength;


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

            GameObject spawnedBranch1 = Instantiate(branchReference[randomIndex]);
            randomSide = Random.Range(0, 2);
            randomLength = Random.Range(0.9f, 4f);
            if (randomSide == 0)
            {
                spawnedBranch1.transform.position = leftPos.position;
                spawnedBranch1.transform.localScale = new Vector3(randomLength, 1f, 1f);
            }
            else if (randomSide == 1)
            {
                spawnedBranch1.transform.position = rightPos.position;
                spawnedBranch1.transform.localScale = new Vector3(-randomLength, 1f, 1f);
            }

            GameObject spawnedBranch2 = Instantiate(branchReference[randomIndex]);
            randomSide = Random.Range(0, 2);
            randomLength = Random.Range(0.9f, 4f);
            if (randomSide == 0)
            {
                spawnedBranch2.transform.position = leftPos.position;
                spawnedBranch2.transform.localScale = new Vector3(randomLength, 1f, 1f);
            }
            else if (randomSide == 1)
            {
                spawnedBranch2.transform.position = rightPos.position;
                spawnedBranch2.transform.localScale = new Vector3(-randomLength, 1f, 1f);
            }
        }

    }
}
