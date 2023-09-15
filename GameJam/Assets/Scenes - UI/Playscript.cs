using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Playscript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Image DCred;
    public Sprite RollOv;
    private Sprite DefIco;

    // Start is called before the first frame update
    void Start()
    {
        DefIco = DCred.sprite;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        DCred.sprite = RollOv;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        DCred.sprite = DefIco;
    }
    void Update()
    {

    }
}
