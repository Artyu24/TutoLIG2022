using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public Tuto2022Player player;

    public void ReloadScene()
    {
        SceneManager.LoadScene("Sc�ne");
    }

    public void AllowPlayerToMove()
    {
        player.canMove = true;
    }
}
