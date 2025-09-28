using UnityEngine;

public class ToggleThreeObjects : MonoBehaviour
{
    [SerializeField] private GameObject object1;
    [SerializeField] private GameObject object2;
    [SerializeField] private GameObject object3;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetActiveOnly(object1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetActiveOnly(object2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetActiveOnly(object3);
        }
    }

    private void SetActiveOnly(GameObject target)
    {
        if (object1 != null) object1.SetActive(object1 == target);
        if (object2 != null) object2.SetActive(object2 == target);
        if (object3 != null) object3.SetActive(object3 == target);
    }
}
