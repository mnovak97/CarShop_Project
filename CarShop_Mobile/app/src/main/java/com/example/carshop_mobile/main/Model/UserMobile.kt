package com.example.carshop_mobile.main.Model

class UserMobile() {
    var IDUser :Int? = null
    var Username :String = ""
    var Email : String = ""
    var Password : String = ""

    constructor(username:String,email:String,password:String) : this() {
                this.Username = username
                this.Email = email
                this.Password = password
                }
}