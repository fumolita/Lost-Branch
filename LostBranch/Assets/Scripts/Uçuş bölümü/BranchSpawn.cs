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
    private float randomPosLeft;
    private float randomPosRight;

    void Start()
    {
        StartCoroutine(SpawnBranches());
    }

    IEnumerator SpawnBranches()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 3));
            randomPosLeft = Random.Range(-1f, 0);
            randomPosRight = Random.Range(0, 1f);

            randomIndex = Random.Range(0, branchReference.Length);

            randomLength1 = Random.Range(3f, 4f);
            randomLength2 = 5.5f - randomLength1;

            GameObject spawnedBranch1 = Instantiate(branchReference[randomIndex]);
            spawnedBranch1.transform.position = new Vector3(leftPos.position.x - (randomPosLeft),leftPos.position.y);
            spawnedBranch1.transform.localScale = new Vector3(-randomLength1 * randomPosLeft, 1f, 1f);

            GameObject spawnedBranch2 = Instantiate(branchReference[randomIndex]);
            spawnedBranch2.transform.position = new Vector3(rightPos.position.x - (randomPosRight), rightPos.position.y);
            spawnedBranch2.transform.localScale = new Vector3(-randomLength2 * randomPosRight, 1f, 1f);
        }
    }
}
