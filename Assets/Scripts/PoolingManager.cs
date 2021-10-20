using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingManager : MonoBehaviour
{
    private static PoolingManager _instance;
    public static PoolingManager Instance => _instance;

    public List<GameObject> pooledObjects; //Lista de objetos
    public GameObject objectToPool;  //Prefab  de los objetos
    public int amount;   //Cantidad de objetos a instanciar
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }
        
    }

    private void Start()
    { // Instancia todos los objetos y los mete en la lista de desactivados
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for(int i = 0; i < amount; i++)
        {
            tmp = Instantiate(objectToPool);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
    }

    public GameObject GetPooledObject()
    {  // Nusca un objeto ue est� desactivado y lo retorna
        for(int i = 0; i < amount; i++)
        {
            if(!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }

}
