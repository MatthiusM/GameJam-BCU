using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Creditsscript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{

    public Image DPlay;
    public Sprite RollO;
    private Sprite defaultIcon;
    public GameObject CreditsCanvas;
    public GameObject MMcanvas;

    // Start is called before the first frame update
    void Start()
    {
        defaultIcon = DPlay.sprite;
        CreditsCanvas.SetActive(false);
        MMcanvas.SetActive(true);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        DPlay.sprite = RollO;
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        CreditsCanvas.SetActive(!CreditsCanvas.activeSelf);
     
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        DPlay.sprite = defaultIcon;
    }
    void Update()
    {

    }

}
