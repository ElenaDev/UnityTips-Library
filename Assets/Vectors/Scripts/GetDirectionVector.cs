using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GetDirectionVector : MonoBehaviour
{
    [SerializeField] private Transform A;
    [SerializeField] private Transform B;
    void Update()
    {
        Vector3 line = GetDirection(A.position, B.position);
        Debug.DrawLine(A.position, line, Color.red);
    }
/// <summary>
/// Método que devuelve la dirección de un vector
/// Normalizamos el vector, es decir, hacemos que su módulo valga 1 m
/// </summary>
/// <param name="origin"></param>
/// <param name="target"></param>
/// <returns></returns>
    private Vector3 GetDirection(Vector3 origin, Vector3 target)
    {
        Vector3 diff = target - origin;
        diff.Normalize();
        return diff;
    }
}
