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

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBranches());
    }

    IEnumerator SpawnBranches()
    {
        while (true)
        {
        yield return new WaitForSeconds(Random.Range(1, 2));

            randomIndex = Random.Range(0, branchReference.Length);
            randomSide = Random.Range(0, 2);
            randomLength = Random.Range(0.5f, 4f);

            spawnedBranch = Instantiate(branchReference[randomIndex]);
            spawnedBranch = Instantiate(branchReference[randomIndex]);

            if (randomSide == 0)
        {
            spawnedBranch.transform.position = leftPos.position;
            spawnedBranch.transform.localScale = new Vector3(randomLength, 1f, 1f);

            }
        else if (randomSide == 1)
        {
            spawnedBranch.transform.position = rightPos.position;
            spawnedBranch.transform.localScale = new Vector3(-randomLength, 1f, 1f);
        }
    }
    }
}
