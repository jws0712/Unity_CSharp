using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter3_Code : MonoBehaviour
{
    private void Update()
    {
        FindCloesestGameObject();
    }

    private void FindCloesestGameObject()
    {
                float cloestDistance = Mathf.Infinity;
        GameObject closestGameObject = null;
        GameObject[] allObject = FindObjectsOfType<GameObject>();
        foreach (GameObject obj in allObject)
        {
            if(obj.name != this.name) 
            {
                float distance = (obj.transform.position - this.transform.position).sqrMagnitude;
                if(distance < cloestDistance)
                {
                    cloestDistance = distance;
                    closestGameObject = obj;
                }
            }
        }
        Debug.DrawLine(this.transform.position, closestGameObject.transform.position);

        Debug.Log(closestGameObject.name);

    }
}
