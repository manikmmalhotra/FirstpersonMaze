using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;

public class adsmanager : MonoBehaviour
{
    private string storeid = "3583879";
    private static string videoAd = "video";

    private void Start()
    {
        Monetization.Initialize(storeid, true);
    }

    public static void VideoAd()
    {
        if (Monetization.IsReady(videoAd))
        {

            ShowAdPlacementContent ad = null;
            ad = Monetization.GetPlacementContent(videoAd) as ShowAdPlacementContent;
            if (ad != null)
            {

                ad.Show();
            }
        }
    }

}
