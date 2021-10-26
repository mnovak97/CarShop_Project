package com.example.carshop_mobile.main.Model

import com.google.gson.annotations.SerializedName
import java.util.*

class Appointment() {

    @SerializedName("idAppointment")
    var idAppointemnt:Int? = null
    @SerializedName("date")
    var date : String = ""
    @SerializedName("time")
    var time: String = ""
    @SerializedName("user")
    var user:UserMobile? = null
    @SerializedName("customerName")
    var customerName:String = ""
    @SerializedName("customerPhone")
    var customerPhone:String = ""
    @SerializedName("finished")
    var finished:Boolean = false


    constructor(date:String,time:String,currentUser:UserMobile,name:String,phone:String,finished:Boolean) : this()
    {
        this.date = date
        this.time = time
        this.user = currentUser
        this.customerName = name
        this.customerPhone = phone
        this.finished = finished
    }
}