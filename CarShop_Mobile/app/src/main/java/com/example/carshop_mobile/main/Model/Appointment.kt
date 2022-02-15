package com.example.carshop_mobile.main.Model

import com.google.gson.annotations.SerializedName
import java.util.*

enum class State{
    @SerializedName("0")
    NotFinished,
    @SerializedName("1")
    Working,
    @SerializedName("2")
    Finished
}

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
    @SerializedName("state")
    var state:State = State.NotFinished


    constructor(date:String,time:String,currentUser:UserMobile,name:String,phone:String,state:State) : this()
    {
        this.date = date
        this.time = time
        this.user = currentUser
        this.customerName = name
        this.customerPhone = phone
        this.state = state
    }
}