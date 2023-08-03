using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _sphereDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != null)
        {
            Debug.Log("1");
            if (other.CompareTag("Cube"))
            {
                Destroy(gameObject);
            }
        }
    }
}
