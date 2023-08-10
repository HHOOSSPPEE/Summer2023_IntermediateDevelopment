using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BigBottleScript : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    public Vector2 origin = new Vector2();
    private RectTransform bigBottle;
    private CanvasGroup canvasGroup;
    public float scale = 10;
    public bool isColor = false;

    private Sprite orangeSpr;
    private Sprite greenSpr;
    private Sprite purpleSpr;
    private Sprite emptySpr;
    private Sprite currentSpr;

    public Vector2 snapLocation = new Vector2();
    public bool dragging = false;
    public GameObject Fire;
    public GameObject Slime;
    public GameObject Poison;

    private void Awake()
    {
        origin = gameObject.transform.position;
        snapLocation = gameObject.transform.position;
        bigBottle = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        orangeSpr = gameObject.transform.GetChild(0).GetComponent<Image>().sprite;
        greenSpr = gameObject.transform.GetChild(1).GetComponent<Image>().sprite;
        purpleSpr = gameObject.transform.GetChild(2).GetComponent<Image>().sprite;
        emptySpr = gameObject.transform.GetChild(3).GetComponent<Image>().sprite;

    }
    //START
    public void OnBeginDrag(PointerEventData eventData)
    {
        currentSpr = gameObject.transform.GetComponent<Image>().sprite;
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
        dragging = true;
    }

    //UPDATE
    public void OnDrag(PointerEventData eventData)
    {
       if (currentSpr != emptySpr)
        {
            bigBottle.anchoredPosition += eventData.delta * scale;
        }
    }

    //END
    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1;
        canvasGroup.blocksRaycasts = true;
        dragging = false;
        gameObject.transform.position = origin;
        currentSpr = gameObject.transform.GetComponent<Image>().sprite;

        if (snapLocation != origin)
        {
            if (orangeSpr == currentSpr)
            {
                Instantiate(Fire, snapLocation, Quaternion.identity);
            }
            else if (greenSpr == currentSpr)
            {
                Instantiate(Slime, snapLocation, Quaternion.identity);
            }
            else if (purpleSpr == currentSpr)
            {
                Instantiate(Poison, snapLocation, Quaternion.identity);
            }
            gameObject.GetComponent<Image>().sprite = emptySpr;
            currentSpr = emptySpr;
        }

       
    }

}
