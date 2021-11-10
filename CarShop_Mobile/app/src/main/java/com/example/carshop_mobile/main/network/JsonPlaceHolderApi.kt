package com.example.carshop_mobile.main.network

import android.webkit.WebResourceResponse
import com.example.carshop_mobile.main.Model.Appointment
import com.example.carshop_mobile.main.Model.LoginModel
import com.example.carshop_mobile.main.Model.UserMobile
import okhttp3.ResponseBody
import retrofit2.Call
import retrofit2.http.Body
import retrofit2.http.GET
import retrofit2.http.POST
import retrofit2.http.Path

interface JsonPlaceHolderApi {

    @POST("usermobile/addUserMobile") fun newUserMobile(@Body user:UserMobile) : Call<UserMobile>
    @POST("usermobile/LoginMobile") fun userLogin(@Body userLogin:LoginModel) : Call<UserMobile>
    @POST("appointment/addAppointment") fun addAppointment(@Body appointment: Appointment) :Call<Appointment>
    @GET("appointment/getUserAppointments/{idUser}") fun getUserAppointments(@Path("idUser") idUser:Int) : Call<ArrayList<Appointment>>
    @GET("appointment/getDateAppointments/{date}") fun getDateAppointments(@Path("date") date:String) : Call<ArrayList<Appointment>>
}