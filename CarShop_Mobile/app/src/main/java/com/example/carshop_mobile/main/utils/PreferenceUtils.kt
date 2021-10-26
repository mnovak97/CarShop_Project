package com.example.carshop_mobile.main.utils

import android.content.Context
import com.example.carshop_mobile.main.Model.UserMobile
import com.google.gson.Gson

class PreferenceUtils {
    companion object{
        fun saveUser(user:UserMobile,context:Context){
            var preferences = context.getSharedPreferences(Constants.PREFERENCE_NAME,Context.MODE_PRIVATE)
            var editor = preferences.edit()
            val jsonString = Gson().toJson(user)
            editor.putString(Constants.USER,jsonString)
            editor.commit()
        }

        fun getUser(context: Context) : UserMobile{
            var preferences = context.getSharedPreferences(Constants.PREFERENCE_NAME,Context.MODE_PRIVATE)
            var userString = preferences.getString(Constants.USER,"default")
            var gson = Gson()
            return gson.fromJson(userString,UserMobile::class.java)
        }
    }
}