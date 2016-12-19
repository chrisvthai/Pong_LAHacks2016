using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour {

	public void OnClicked()
    {
        Application.LoadLevel("Pong");
    }
}
