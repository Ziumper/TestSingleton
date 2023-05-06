using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabBehaviour : MonoBehaviour
{
    public GameObject MyCube;

    // Start is called before the first frame update
    void Start()
    {
        Singleton mySingleton = Singleton.Instance;
        mySingleton.GameObjects.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
