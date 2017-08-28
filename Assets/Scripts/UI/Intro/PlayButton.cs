using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class PlayButton : MonoBehaviour {

	public Text PlayerCount;
	public Slider PlayerSlider;
    public GameObject gameManagerPrefab;

    private GameObject gameManager;
    private Button currentButton;

    void Awake()
    {
        
    }

    void Start(){
        currentButton = this.GetComponent<Button>();
        currentButton.onClick.AddListener(() => { OnClick(); });
    }

	public void OnClick()
    {
        gameManager = Instantiate(gameManagerPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        Debug.Log("Intantiation GameManager");
        gameManager.GetComponent<GameManager>().CountOfPlayer = PlayerSlider.value;
        
        Application.LoadLevel ("Main");
	}


}
