package com.example.carshop_mobile.main.network

import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

class RetrofitClientInstance {
   companion object{
        const val BASE_URL = "https://f528-93-141-57-1.ngrok.io/api/"
        lateinit var retrofit:Retrofit
        fun getRetrofitInstance(): Retrofit{
            if(retrofit == null){
                retrofit = retrofit2.Retrofit.Builder()
                        .baseUrl(BASE_URL)
                        .addConverterFactory(GsonConverterFactory.create())
                        .build()
            }
            return retrofit
        }
   }

}