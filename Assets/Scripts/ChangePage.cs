using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangePage : MonoBehaviour
{
    [SerializeField] private string _secondScene;
    [SerializeField] private string _thirdScene;
    [SerializeField] private string _fourthScene;
    [SerializeField] private string _fifthScene;
    [SerializeField] private string _sixthScene;
    [SerializeField] private string _seventhScene;
<<<<<<< HEAD
    [SerializeField] private string _gameScene;
=======
>>>>>>> 0f50f418b90c6e5bf34564677571e09f37f12bf6

    public void Gotopage2()
    {
        SceneManager.LoadScene(_secondScene);
        // GameObject.FindGameObjectWithTag("music").GetComponent<DontDestroyMusicBg>().PlayMusic();
    }

    public void Gotopage3()
    {
        SceneManager.LoadScene(_thirdScene);
    }

    public void Gotopage4()
    {
        SceneManager.LoadScene(_fourthScene);
    }

    public void Gotopage5()
    {
        SceneManager.LoadScene(_fifthScene);
    }

    public void Gotopage6()
    {
        SceneManager.LoadScene(_sixthScene);
    }

    public void GotopageHowtoplay()
    {
        SceneManager.LoadScene(_seventhScene);
    }
<<<<<<< HEAD

    public void GoToGame()
    {
        SceneManager.LoadScene(_gameScene);
    }
=======
>>>>>>> 0f50f418b90c6e5bf34564677571e09f37f12bf6
}

