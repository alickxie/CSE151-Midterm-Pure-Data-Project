using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameConditions : MonoBehaviour
{
    public Animator VictoryMenuAnim;
    public Animator GameOverMenuAnim;


    public void GameOver()
    {
        StartCoroutine(GameOverAnim());
    }

    public void Victory()
    {
        VictoryMenuAnim.SetBool("Enter", true);
    }

    IEnumerator GameOverAnim()
    {
        Debug.Log("GameOver");
        GameOverMenuAnim.SetBool("Enter", true);
        yield return new WaitForSeconds(3f);
        GameOverMenuAnim.SetBool("Enter", false);
    }
}
