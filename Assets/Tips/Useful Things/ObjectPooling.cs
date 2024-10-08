using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    [SerializeField] private List<GameObject> ListBalls;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            //Activo el Gameobject que me devuelve el método GetObject
            GetObject().SetActive(true);
    }

    private GameObject GetObject()
    {
        //Buscamos entre la lista un objeto que esté desactivado
        GameObject ball = ListBalls.Find(item => item.activeInHierarchy == false);

        //devolvemos el objeto
        return ball;
    }
}
