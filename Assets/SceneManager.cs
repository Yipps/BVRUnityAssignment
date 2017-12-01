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
    


    // Use this for initialization
    void Start () {

        if(isSpawningErythrocyte)
            InvokeRepeating("SpawnErythrocyte", 1f, erythrocyteRate);

        if (isSpawningLeukocyte)
            InvokeRepeating("SpawnLeukocyte", 1f, leukocyteRate);

        if (isSpawningThrombocyte)
            InvokeRepeating("SpawnThrombocyte", 1f, ThrombocyteRate);



    }
	
	// Update is called once per frame
	void Update () {
        
        
	}

    void SpawnErythrocyte()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-erythrocyteRadius, erythrocyteRadius), Random.Range(-erythrocyteRadius, erythrocyteRadius), 0);
        Instantiate(Erythrocyte, spawnPosition, Quaternion.identity);
    }

    void SpawnLeukocyte()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-leukocyteRadius, leukocyteRadius), Random.Range(-leukocyteRadius, leukocyteRadius), 0);
        Instantiate(Leukocyte, spawnPosition, Quaternion.identity);
    }
    void SpawnThrombocyte()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-thrombocyteRadius, thrombocyteRadius), Random.Range(-thrombocyteRadius, thrombocyteRadius), 0);
        Instantiate(Thrombocyte, spawnPosition, Quaternion.identity);
    }

}
