using System.Collections;
using UnityEngine;

public class TriggerObjectsSequence : MonoBehaviour
{
    [SerializeField] private GameObject[] objectsToActivate; 
    [SerializeField] private float interval = 1.5f;

    private bool isRunning = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isRunning) 
        {
            StartCoroutine(ActivateSequence());
        }
    }

    private IEnumerator ActivateSequence()
    {
        isRunning = true;

        foreach (var obj in objectsToActivate)
        {
            if (obj != null)
            {
                obj.SetActive(true);
                yield return new WaitForSeconds(interval);
                obj.SetActive(false);
            }
        }

        // п≥сл€ проходженн€ вс≥х трьох Ч вимикаЇмо вс≥ на вс€к випадок
        foreach (var obj in objectsToActivate)
        {
            if (obj != null)
                obj.SetActive(false);
        }

        isRunning = false;
    }
}
