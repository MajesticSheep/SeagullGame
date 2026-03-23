using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private LayerMask interactableLayerMask;

    //Might not need this one because this code is for first person games
    [SerializeField]
    private Transform playerObjectTransform;

    [SerializeField]
    private GameObject pickUpUI;

    [SerializeField]
    [Min(1)]
    private float hitRange = 3;

    private RaycastHit hit;


    private void Update()
    {
        Debug.DrawRay(playerObjectTransform.position, playerObjectTransform.forward * hitRange, Color.red);
        if (hit.collider != null)
        {
            hit.collider.GetComponent<Highlight>()?.ToggleHighlight(false);
            pickUpUI.SetActive(false);
        }
        if (Physics.Raycast(playerObjectTransform.position, playerObjectTransform.forward, out hit, hitRange, interactableLayerMask))
        {
            //the question mark is there to make sure the component has to Highlight script
            hit.collider.GetComponent<Highlight>()?.ToggleHighlight(true);
            pickUpUI.SetActive(true);
        }
    }
}
