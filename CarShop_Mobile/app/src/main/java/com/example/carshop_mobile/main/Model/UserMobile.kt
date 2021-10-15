package com.example.carshop_mobile.main.Model

import com.google.gson.annotations.SerializedName


class UserMobile() {
    @SerializedName("IDUser")
    var IDUser :Int? = null
    @SerializedName("Username")
    var Username :String = ""
    @SerializedName("Email")
    var Email : String = ""
    @SerializedName("Password")
    var Password : String = ""

    constructor(username:String,email:String,password:String) : this() {
                this.Username = username
                this.Email = email
                this.Password = password
                }
}