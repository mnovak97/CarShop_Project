package com.example.carshop_mobile.main.network

import android.webkit.WebResourceResponse
import com.example.carshop_mobile.main.Model.Appointment
import com.example.carshop_mobile.main.Model.LoginModel
import com.example.carshop_mobile.main.Model.UserMobile
import okhttp3.ResponseBody
import retrofit2.Call
import retrofit2.http.Body
import retrofit2.http.POST

interface JsonPlaceHolderApi {

    @POST("usermobile/addUserMobile") fun newUserMobile(@Body user:UserMobile) : Call<UserMobile>
    @POST("usermobile/LoginMobile") fun userLogin(@Body userLogin:LoginModel) : Call<UserMobile>
    @POST("appointment/addAppointment") fun addAppointment(@Body appointment: Appointment) :Call<Appointment>
    @POST("appointment/getUserAppointments") fun getUserAppointments(@Body idUser:Int) : Call<ArrayList<Appointment>>
}