using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public Canvas quitMenu;
    public Canvas instrMenu;
    public Button playText;
    public Button exitText;
    public Button instrText;

    // Start is called before the first frame update
    void Start()
    {
        quitMenu.enabled = false;
        instrMenu.enabled = false;

    }

    public void exitPress()
    {
        quitMenu.enabled = true;
        instrMenu.enabled = false;
        playText.enabled = false;
        exitText.enabled = false;
        instrText.enabled = false;

    }
    public void instrPress()
    {
        instrMenu.enabled = true;
        quitMenu.enabled = false;
        playText.enabled = false;
        exitText.enabled = false;
        instrText.enabled = false;

    }

    public void noPress()
    {
        quitMenu.enabled = false;
        instrMenu.enabled = false;
        playText.enabled = true;
        exitText.enabled = true;
        instrText.enabled = true;
    }

    public void startLevel()
    {
        SceneManager.LoadScene(5);

    }
    public void exitGame()
    {
        Application.Quit();
        Debug.Log("bye bye");
    }
}
