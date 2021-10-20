using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject[] meteor;
  

    public Transform[] positions;

    void Start()
    {
        StartCoroutine(GenerateMeteor());
    }
 
    IEnumerator GenerateMeteor()
    {
        var position = Random.Range(0, 5);
        var meteorElection = Random.Range(0, 2);

        if (meteorElection == 0) { Instantiate(meteor[0], positions[position].position, Quaternion.identity); }
        else { Instantiate(meteor[1], positions[position].position, Quaternion.identity); }
        yield return new WaitForSeconds(1.0f);
        StartCoroutine(GenerateMeteor());
    }
}
