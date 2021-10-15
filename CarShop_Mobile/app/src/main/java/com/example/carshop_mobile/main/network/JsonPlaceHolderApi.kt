package com.example.carshop_mobile.main.network

import com.example.carshop_mobile.main.Model.UserMobile
import retrofit2.Call
import retrofit2.http.Body
import retrofit2.http.POST

interface JsonPlaceHolderApi {

    @POST("usermobile/addUserMobile") fun newUserMobile(@Body user:UserMobile) : Call<UserMobile>
}