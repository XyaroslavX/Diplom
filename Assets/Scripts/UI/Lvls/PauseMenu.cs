using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject uiElement;
    private bool isPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        ApplyPause();
    }

    public void Resume()
    {
        isPaused = false;
        ApplyPause();
    }

    private void ApplyPause()
    {
        if (uiElement != null)
            uiElement.SetActive(isPaused);

        Time.timeScale = isPaused ? 0f : 1f;
    }
}
