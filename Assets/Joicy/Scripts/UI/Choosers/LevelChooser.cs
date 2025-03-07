using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelChooser : MonoBehaviour
{
    public Level Level { get; set; }

    [SerializeField] private TMP_Text levelName = null;
    [SerializeField] private Button button = null;

    public void ChooseLevel()
    {
        SceneManager.LoadScene($"{Level.LevelData.Scene}", LoadSceneMode.Single);
    }

    public void Initialize(bool active)
    {
        levelName.text = Level.LevelData.Name;

        if(!active)
        {
            button.interactable = false;
        }
    }
}