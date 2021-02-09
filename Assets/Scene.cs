using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void ToTitleScene()
    {
        SceneManager.LoadScene("Title");
    }
    public void ToMainScene()
    {
        SceneManager.LoadScene("Main");
    }
    public void ToClearScene()
    {
        SceneManager.LoadScene("Clear");
    }
}