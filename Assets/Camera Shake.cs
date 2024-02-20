using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float duration = 1.5f;
    public float magnitud = 1.5f;

    public IEnumerator Shake() { 
        Vector3 originalPosiion = transform.localPosition;
        float elapsed = 0f;
        while (elapsed < duration)
        {

            float x = Random.Range(-1f, 1f) * magnitud;
            float y = Random.Range(-1f, 1f) * magnitud;

            transform.localPosition=new Vector3(x, y, originalPosiion.z);
            elapsed += Time.deltaTime;

            yield return null;
        }
        transform.localPosition = originalPosiion;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
