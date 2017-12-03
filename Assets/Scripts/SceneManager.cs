using DSAM.Utility;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {

    public GameObject Erythrocyte;
    public GameObject Leukocyte;
    public GameObject Thrombocyte;

    public float erythrocyteRate;
    public float leukocyteRate;
    public float ThrombocyteRate;

    //public float erythrocyteRadius;
    //public float leukocyteRadius;
    //public float thrombocyteRadius;

    public bool isSpawningErythrocyte;
    public bool isSpawningLeukocyte;
    public bool isSpawningThrombocyte;

    public Utility_Path[] cellPaths;
    int numPaths;


    // Use this for initialization
    void Start () {
        erythrocyteRate = 1f;
        leukocyteRate = 1f;
        ThrombocyteRate = 1f;
        numPaths = cellPaths.Length;

        if(isSpawningErythrocyte)
            InvokeRepeating("SpawnErythrocyte", 1f, erythrocyteRate);

        if (isSpawningLeukocyte)
            InvokeRepeating("SpawnLeukocyte", 3f, leukocyteRate);

        if (isSpawningThrombocyte)
            InvokeRepeating("SpawnThrombocyte", 5f, ThrombocyteRate);

    }

    void SpawnErythrocyte()
    {

        Utility_Path cellPath = cellPaths[Random.Range(0, numPaths)];
        GameObject instance = Instantiate(Erythrocyte, cellPath.transform.position, Quaternion.identity);
        Utility_FollowSpline cellMovement = instance.GetComponent<Utility_FollowSpline>();
        cellMovement.pathName = cellPath.name;

    }

    void SpawnLeukocyte()
    {
        Utility_Path cellPath = cellPaths[Random.Range(0, numPaths)];
        GameObject instance = Instantiate(Leukocyte, cellPath.transform.position, Quaternion.identity);
        Utility_FollowSpline cellMovement = instance.GetComponent<Utility_FollowSpline>();
        cellMovement.pathName = cellPath.name;
    }

    void SpawnThrombocyte()
    {
        Utility_Path cellPath = cellPaths[Random.Range(0, numPaths)];
        GameObject instance = Instantiate(Thrombocyte, cellPath.transform.position, Quaternion.identity);
        Utility_FollowSpline cellMovement = instance.GetComponent<Utility_FollowSpline>();
        cellMovement.pathName = cellPath.name;
    }

}
