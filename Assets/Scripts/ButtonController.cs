using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button StartButton, ExitButton;
    private bool isStart = false, isExit = false; //переменные для одного нажатия на кнопку

    void Update()
    {
        StartButton.onClick.AddListener(StartGame); //Добавляем дойствия для кнопок
        ExitButton.onClick.AddListener(ExitGame);
    }

    private void StartGame()
    {
        if (!isStart)
        {
            SceneManager.LoadScene(1);//Загружаем сцену с дорогой
            isStart = true;     
        }
        
    }

    private void ExitGame()
    {
        if (!isExit)
        {
            Application.Quit();     //Выходим
            isExit = true;
        }
    }
}