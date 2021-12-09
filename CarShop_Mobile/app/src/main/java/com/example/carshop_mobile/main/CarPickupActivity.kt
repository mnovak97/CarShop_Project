package com.example.carshop_mobile.main

import android.content.pm.PackageManager
import android.location.Address
import android.location.Geocoder
import android.location.Location
import android.os.Bundle
import android.widget.Button
import android.widget.TextView
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import androidx.core.app.ActivityCompat
import com.example.carshop_mobile.R
import com.example.carshop_mobile.main.utils.Constants.Companion.REQUEST_CODE
import com.google.android.gms.common.api.Status
import com.google.android.gms.location.FusedLocationProviderClient
import com.google.android.gms.location.LocationServices
import com.google.android.gms.maps.CameraUpdateFactory
import com.google.android.gms.maps.GoogleMap
import com.google.android.gms.maps.OnMapReadyCallback
import com.google.android.gms.maps.SupportMapFragment
import com.google.android.gms.maps.model.LatLng
import com.google.android.gms.maps.model.MarkerOptions
import com.google.android.libraries.places.api.Places
import com.google.android.libraries.places.api.model.Place
import com.google.android.libraries.places.api.model.TypeFilter
import com.google.android.libraries.places.api.net.PlacesClient
import com.google.android.libraries.places.widget.AutocompleteSupportFragment
import com.google.android.libraries.places.widget.listener.PlaceSelectionListener
import java.util.*


class CarPickupActivity : AppCompatActivity(), OnMapReadyCallback {

    lateinit var mMap: GoogleMap
    var currentLocation : Location? = null
    var fusedLocationProviderClient: FusedLocationProviderClient? = null
    var placesClient:PlacesClient? = null
    lateinit var txtCarPickupAddress : TextView
    lateinit var btnRequestPickup : Button

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_car_pickup)
        Places.initialize(applicationContext, resources.getString(R.string.map_key))
        placesClient = Places.createClient(this)
        fusedLocationProviderClient = LocationServices.getFusedLocationProviderClient(this)
        fetchLocation()
        initializeAutocomplete()
        initializeComponents()
        buttonOnClick()
    }

    private fun initializeComponents() {
        txtCarPickupAddress = findViewById(R.id.txtPickupAddress)
        btnRequestPickup = findViewById(R.id.btnRequestPickup)
    }

    private fun buttonOnClick() {
        btnRequestPickup.setOnClickListener {
            
        }
    }

    private fun initializeAutocomplete() {
        var autocompleteFragment:AutocompleteSupportFragment = supportFragmentManager.findFragmentById(R.id.autocomplete_fragment) as AutocompleteSupportFragment
        autocompleteFragment.setTypeFilter(TypeFilter.ADDRESS)
        autocompleteFragment.setCountries("HR")
        autocompleteFragment.setPlaceFields(listOf(Place.Field.ID, Place.Field.NAME, Place.Field.LAT_LNG, Place.Field.ADDRESS))
        autocompleteFragment.setOnPlaceSelectedListener(object : PlaceSelectionListener {
            override fun onPlaceSelected(place: Place) {
                pinPointMap(place)
            }

            override fun onError(status: Status) {
                Toast.makeText(applicationContext, "Error!", Toast.LENGTH_SHORT).show()
            }
        })
    }

    private fun pinPointMap(place: Place) {
        val latLng = LatLng(place.latLng!!.latitude, place.latLng!!.longitude)
        val markerOptions = MarkerOptions().position(latLng).title(place.address)
        mMap.clear()
        mMap.animateCamera(CameraUpdateFactory.newLatLng(latLng))
        mMap.animateCamera(CameraUpdateFactory.newLatLngZoom(latLng, 15f))
        mMap.addMarker(markerOptions)
        txtCarPickupAddress.text = place.address
    }


    private fun fetchLocation() {
        if (ActivityCompat.checkSelfPermission(this, android.Manifest.permission.ACCESS_FINE_LOCATION)
                != PackageManager.PERMISSION_GRANTED && ActivityCompat.checkSelfPermission(this, android.Manifest.permission.ACCESS_COARSE_LOCATION)
                != PackageManager.PERMISSION_GRANTED) {
            ActivityCompat.requestPermissions(this, arrayOf(android.Manifest.permission.ACCESS_FINE_LOCATION), REQUEST_CODE)
            return
        }

        val task = fusedLocationProviderClient!!.lastLocation
        task.addOnSuccessListener { location ->
            if (location != null)
            {
                currentLocation = location
                val supportMapFragment = (supportFragmentManager.findFragmentById(R.id.map) as SupportMapFragment?)
                supportMapFragment!!.getMapAsync(this@CarPickupActivity)
            }
        }
    }

    override fun onMapReady(googleMap: GoogleMap?) {
        mMap = googleMap!!
        val latLng = LatLng(currentLocation!!.latitude, currentLocation!!.longitude)
        var address = getAddress()
        val markerOptions = MarkerOptions().position(latLng).title(address)
        mMap.animateCamera(CameraUpdateFactory.newLatLng(latLng))
        mMap.animateCamera(CameraUpdateFactory.newLatLngZoom(latLng, 15f))
        mMap.addMarker(markerOptions)
        txtCarPickupAddress.text = address
    }

    private fun getAddress(): String {
        val geocoder: Geocoder = Geocoder(this, Locale.getDefault())
        val addresses: List<Address> = geocoder.getFromLocation(currentLocation!!.latitude, currentLocation!!.longitude, 1)
        return addresses[0].getAddressLine(0)
    }

    override fun onRequestPermissionsResult(requestCode: Int, permissions: Array<out String>, grantResults: IntArray) {
        when(requestCode){
            REQUEST_CODE -> {
                if (grantResults.isNotEmpty() && grantResults[0] == PackageManager.PERMISSION_GRANTED) {
                    fetchLocation()
                }
            }
        }
        super.onRequestPermissionsResult(requestCode, permissions, grantResults)
    }
}