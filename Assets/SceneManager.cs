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

    public float erythrocyteRadius;
    public float leukocyteRadius;
    public float thrombocyteRadius;

    public bool isSpawningErythrocyte;
    public bool isSpawningLeukocyte;
    public bool isSpawningThrombocyte;

    public Utility_Path[] cellPaths;
    


    // Use this for initialization
    void Start () {
        erythrocyteRate = 1f;
        leukocyteRate = 1f;
        ThrombocyteRate = 1f;


        if(isSpawningErythrocyte)
            InvokeRepeating("SpawnErythrocyte", 1f, erythrocyteRate);

        if (isSpawningLeukocyte)
            InvokeRepeating("SpawnLeukocyte", 1f, leukocyteRate);

        if (isSpawningThrombocyte)
            InvokeRepeating("SpawnThrombocyte", 1f, ThrombocyteRate);

    }

    void SpawnErythrocyte()
    {
        Vector3 pathPos = cellPaths[Random.Range(-cellPaths.Length, cellPaths.Length)].transform.position;
        GameObject instance = Instantiate(Erythrocyte, pathPos, Quaternion.identity);
        //Utility_FollowSpline cellMovement = instance.AddComponent<Utility_FollowSpline>();


    }

    void SpawnLeukocyte()
    {
        Vector3 pathPos = cellPaths[Random.Range(-cellPaths.Length, cellPaths.Length)].transform.position;
        GameObject instance = Instantiate(Leukocyte, pathPos, Quaternion.identity);
        //Utility_FollowSpline cellMovement = instance.AddComponent<Utility_FollowSpline>();
    }

    void SpawnThrombocyte()
    {
        Vector3 pathPos = cellPaths[Random.Range(-cellPaths.Length, cellPaths.Length)].transform.position;
        GameObject instance = Instantiate(Thrombocyte, pathPos, Quaternion.identity);
        //Utility_FollowSpline cellMovement = instance.AddComponent<Utility_FollowSpline>();
    }

}
