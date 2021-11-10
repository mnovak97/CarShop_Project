package com.example.carshop_mobile.main.network

import okhttp3.OkHttpClient
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

class RetrofitClientInstance {
   companion object{
        const val BASE_URL = "https://4213-93-141-104-130.ngrok.io/api/"
       fun getRetrofitInstance(): Retrofit {

           return Retrofit.Builder()
                   .baseUrl(BASE_URL)
                   .addConverterFactory(GsonConverterFactory.create())
                   .build()
       }
   }

}