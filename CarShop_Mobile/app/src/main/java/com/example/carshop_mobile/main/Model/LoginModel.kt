package com.example.carshop_mobile.main.Model

import com.google.gson.annotations.SerializedName

class LoginModel() {
    @SerializedName("Username")
    var username:String = ""
    @SerializedName("Password")
    var password: String = ""

    constructor(username:String,password:String) : this(){
        this.username = username
        this.password = password
    }
}