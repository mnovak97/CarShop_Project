package com.example.carshop_mobile.main.Model

import com.google.gson.annotations.SerializedName


class UserMobile{
    @SerializedName("idUserMobile")
    var iDUser :Int? = null
    @SerializedName("username")
    var username : String? = null
    @SerializedName("email")
    var email : String? = null
    @SerializedName("password")
    var password : String? = null
    @SerializedName("mobileTelephone")
    var mobileTelephone : String? = null
    @SerializedName("name")
    var name : String? = null
    @SerializedName("surname")
    var surname : String? = null

    constructor(username:String,password:String,email:String,mobilePhone:String,name:String,surname:String){
        this.username = username
        this.email = email
        this.password = password
        this.mobileTelephone = mobilePhone
        this.name = name
        this.surname = surname
    }

}