package com.example.carshop_mobile.main

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.ImageButton
import android.widget.Toast
import com.example.carshop_mobile.R
import com.example.carshop_mobile.main.Model.UserMobile
import com.example.carshop_mobile.main.network.JsonPlaceHolderApi
import com.example.carshop_mobile.main.network.RetrofitClientInstance
import retrofit2.*
import retrofit2.converter.gson.GsonConverterFactory
import java.net.HttpURLConnection

class SignUpActivity : AppCompatActivity() {
    lateinit var txtUsername:EditText
    lateinit var txtEmail:EditText
    lateinit var txtPassword:EditText
    lateinit var btnClose:ImageButton
    lateinit var btnRegister:Button

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_signup)
        initializeComponents()
        setOnClickEvents()
    }

    private fun initializeComponents() {
        txtUsername = findViewById(R.id.txtUsernameSignUp)
        txtEmail = findViewById(R.id.txtEmail)
        txtPassword = findViewById(R.id.txtPasswordSignUp)
        btnClose = findViewById(R.id.btnExit)
        btnRegister = findViewById(R.id.btnRegister)
    }
    private fun setOnClickEvents() {
        btnClose.setOnClickListener {
            finish()
        }
        btnRegister.setOnClickListener {
            var user = UserMobile(txtUsername.text.toString(),txtEmail.text.toString(),txtPassword.text.toString())
            val service = RetrofitClientInstance.getRetrofitInstance().create(JsonPlaceHolderApi::class.java)
            val call = service.newUserMobile(user)
            call.enqueue(object : Callback<UserMobile>{
                @Override
                override fun onResponse(call: Call<UserMobile>, response: Response<UserMobile>) {
                    if (response.code() == HttpURLConnection.HTTP_OK){
                        if (response.body() == null){
                            Toast.makeText(applicationContext, "There is already an account with that E-mail address", Toast.LENGTH_SHORT).show();
                        }
                        else{
                            Toast.makeText(applicationContext, "Sign Up successful", Toast.LENGTH_SHORT).show();
                        }
                    }
                }
                @Override
                override fun onFailure(call: Call<UserMobile>, t: Throwable) {
                    call.cancel()
                }
            })
        }
    }


}