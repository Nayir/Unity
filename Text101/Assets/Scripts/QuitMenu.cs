using UnityEngine;
using System.Collections;

public class QuitMenu : MonoBehaviour {

	public GameObject menu; // Assign in inspector
	private bool isShowing;

	void Start () {
		isShowing = false;
		menu.SetActive(isShowing);
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.M)) {
			isShowing = !isShowing;
			menu.SetActive(isShowing);
		}
		
	}
}
