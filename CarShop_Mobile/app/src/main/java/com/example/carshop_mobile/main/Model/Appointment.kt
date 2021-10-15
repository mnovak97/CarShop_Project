package com.example.carshop_mobile.main.Model

import com.google.gson.annotations.SerializedName
import java.util.*

class Appointment() {

    @SerializedName("IDAppointment")
    var idAppointemnt:Int? = null
    @SerializedName("Date")
    var date : Date? = null
    @SerializedName("Time")
    var time: String = ""
    @SerializedName("User")
    var user:UserMobile? = null
    @SerializedName("CustomerName")
    var customerName:String = ""
    @SerializedName("CustomerPhone")
    var customerPhone:String = ""

    constructor(date:Date,time:String,currentUser:UserMobile,name:String,phone:String) : this()
    {
        this.date = date
        this.time = time
        this.user = currentUser
        this.customerName = name
        this.customerPhone = phone
    }
}