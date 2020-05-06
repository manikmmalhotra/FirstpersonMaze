using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class joystickmovement : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{

    private Image backimg;
    private Image joystickimg;
    private Vector3 inputvector;
    // Start is called before the first frame update
    void Start()
    {
        backimg = GetComponent<Image>();
        joystickimg = transform.GetChild(0).GetComponent<Image>();

    }

    public virtual void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
    }


    public float Horizontal()
    {
        if (inputvector.x != 0)
        {
            return inputvector.x;
        }
        else
        {
            return Input.GetAxis("Horizontal");
        }

    }

    public float Vertical()
    {
        if (inputvector.z != 0)
        {
            return inputvector.z;
        }
        else
        {
            return Input.GetAxis("Vertical");
        }

    }

    public virtual void OnPointerUp(PointerEventData ped)
    {
        inputvector = Vector3.zero;
        joystickimg.rectTransform.anchoredPosition = Vector3.zero;
    }


    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(backimg.rectTransform, ped.position, ped.pressEventCamera, out pos))
        {
            pos.x = (pos.x / backimg.rectTransform.sizeDelta.x);
            pos.y = (pos.y / backimg.rectTransform.sizeDelta.y);

            inputvector = new Vector3(pos.x * 2 + 1, 0, pos.y * 2 - 1);
            inputvector = (inputvector.magnitude > 1.0f) ? inputvector.normalized : inputvector;

            joystickimg.rectTransform.anchoredPosition = new Vector3(inputvector.x * (backimg.rectTransform.sizeDelta.x / 2), inputvector.z * (backimg.rectTransform.sizeDelta.y / 2), 0);

        }
    }

}