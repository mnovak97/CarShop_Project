package com.example.carshop_mobile.main.network

import okhttp3.OkHttpClient
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

class RetrofitClientInstance {
   companion object{
       const val BASE_URL = "https://8678-93-141-10-202.ngrok.io/api/"
       fun getRetrofitInstance(): Retrofit {
           return Retrofit.Builder()
                   .baseUrl(BASE_URL)
                   .addConverterFactory(GsonConverterFactory.create())
                   .build()
       }
   }
}