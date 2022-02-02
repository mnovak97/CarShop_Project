package com.example.carshop_mobile.main.Model

import com.google.gson.annotations.SerializedName

class PickUp() {
    @SerializedName("idPickUp")
    var idPickUp:Int? = null
    @SerializedName("address")
    var address : String = ""
    @SerializedName("longitude")
    var longitude:Double? = null
    @SerializedName("latitude")
    var latitude:Double? = null
    @SerializedName("done")
    var done:Boolean = false
    @SerializedName("user")
    var user:UserMobile? = null

    constructor(address:String,longitude:Double,latitude:Double,done:Boolean,user:UserMobile) : this(){
        this.address = address
        this.longitude = longitude
        this.latitude = latitude
        this.done = done
        this.user = user
    }
}