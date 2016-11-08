using System;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.OS;
using Android.Runtime;
using Android.Views;
using CrossDrawer.Core;
using MvvmCross.Droid.Support.V7.Fragging.Attributes;
using MvvmCross.Droid.Support.V7.Fragging.Fragments;

namespace CrossDrawer.Android
{
    [MvxFragmentAttribute(typeof(MainViewModel), Resource.Id.frameLayout)]
    [Register("crossdrawer.android.MySettingsFragment")]
    public class MySettingsFragment : MvxFragment<MySettingsViewModel>, IOnMapReadyCallback
    {
        MapView mapView;
        GoogleMap map;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var v = inflater.Inflate(Resource.Layout.MySettingsView, container, false);
            mapView = (MapView)v.FindViewById(Resource.Id.map);
            mapView.OnCreate(savedInstanceState);
            mapView.OnResume();
            mapView.GetMapAsync(this);
            map = mapView.Map;
            MapsInitializer.Initialize(this.Activity);

            CameraUpdate cameraUpdate = CameraUpdateFactory.NewLatLngZoom(new LatLng(57.0551, 9.88488), 10);
            map.AnimateCamera(cameraUpdate);
            return v;
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            this.map = googleMap;
        }
    }

}