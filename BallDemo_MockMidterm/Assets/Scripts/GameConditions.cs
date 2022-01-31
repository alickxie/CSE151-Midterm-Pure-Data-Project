using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//************** use UnityOSC namespace...
using UnityOSC;
//*************

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
        OSCHandler.Instance.SendMessageToClient("pd", "/unity/volum", 0);
        OSCHandler.Instance.SendMessageToClient("pd", "/unity/victory", 1);
    }

    IEnumerator GameOverAnim()
    {
        Debug.Log("GameOver");
        OSCHandler.Instance.SendMessageToClient("pd", "/unity/failure", 0);
        OSCHandler.Instance.SendMessageToClient("pd", "/unity/failure", 1);
        GameOverMenuAnim.SetBool("Enter", true);
        yield return new WaitForSeconds(3f);
        GameOverMenuAnim.SetBool("Enter", false);
    }
}
