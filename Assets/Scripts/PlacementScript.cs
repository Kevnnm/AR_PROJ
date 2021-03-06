using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Experimental.XR;

public class PlacementScript : MonoBehaviour
{
    public GameObject placementIndicator;

    [SerializeField]
    public GameObject[] CandyArrObj;

    private List<GameObject> objectArr = new List<GameObject>();

    [SerializeField]
    private ARRaycastManager arOrigin;
    public static Pose placementPose;
    private bool placementPoseIsValid = false;

    // Start is called before the first frame update
    void Start()
    {
        arOrigin = FindObjectOfType<ARRaycastManager>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePlacement();
        UpdatePlacementIndicator();
    }

    private void UpdatePlacement()
    {
        var screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hit = new List<ARRaycastHit>();
        arOrigin.Raycast(screenCenter, hit, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

        placementPoseIsValid = hit.Count > 0;
        print(placementPoseIsValid);
        Debug.Log(placementPoseIsValid);
        if (placementPoseIsValid)
        {
            placementPose = hit[0].pose;

            var cameraForawrd = Camera.current.transform.forward;
            var cameraBearing = new Vector3(cameraForawrd.x, 0, cameraForawrd.z).normalized;

            placementPose.rotation = Quaternion.LookRotation(cameraBearing);
        }

    }

    private void UpdatePlacementIndicator()
    {
        if (placementPoseIsValid)
        {
            placementIndicator.SetActive(true);
            placementIndicator.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
        }
        else
        {
            placementIndicator.SetActive(false);
        }
    }
};
