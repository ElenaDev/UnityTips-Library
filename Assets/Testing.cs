using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public class ShaderParameters
    {
        public static int color = Shader.PropertyToID("_Color");
        public static int alpha = Shader.PropertyToID("_Alpha");
    }

    Transform parent;
    GameObject prefab;
    Vector3 pos;
    Quaternion rot;

    void TransformOneNotTwice()
    {
        //Establecer posición y rotación a la vez:
        transform.SetPositionAndRotation(pos, rot);
        //si necesitas instanciar, optimiza estableciando
        //padre y posicion/rotación al instanciarlo
        GameObject.Instantiate(prefab, pos, rot, parent);
    }
}
