using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menuCanvas; // Reference to the UI menu Canvas

    private bool isMenuOpen = false;

    private void Start()
    {
        // Ensure the menu starts as closed
        CloseMenu();
    }

    private void Update()
    {
        // Check for the "Escape" key press
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isMenuOpen)
            {
                // If the menu is open, close it
                CloseMenu();
            }
            else
            {
                // If the menu is closed, open it
                OpenMenu();
            }
        }
    }

    private void OpenMenu()
    {
        // Enable the menu Canvas and set the time scale to 0 (pausing the game)
        menuCanvas.SetActive(true);
        Time.timeScale = 0f;

        isMenuOpen = true;
    }

    private void CloseMenu()
    {
        // Disable the menu Canvas and resume time scale to 1 (resuming the game)
        menuCanvas.SetActive(false);
        Time.timeScale = 1f;

        isMenuOpen = false;
    }
}