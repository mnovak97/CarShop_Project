package com.example.carshop_mobile.main

import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.example.carshop_mobile.R
import com.example.carshop_mobile.main.Model.UserMobile

class LoginActivity : AppCompatActivity() {

    lateinit var txtUsername:EditText
    lateinit var txtPassword:EditText
    lateinit var btnSignUp:TextView
    lateinit var btnLogin:Button

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_login)
        initializeComponents()
        setOnClickEvents()
    }
    private fun initializeComponents() {
        txtUsername = findViewById(R.id.txtUsername)
        txtPassword = findViewById(R.id.txtPassword)
        btnLogin = findViewById(R.id.btnLogin)
        btnSignUp = findViewById(R.id.btnSignUp)
    }

    private fun setOnClickEvents() {
        btnSignUp.setOnClickListener {
            val user = UserMobile("Milica","milica@gmail.com","milica123")
            Toast.makeText(applicationContext,user.Username.toString(),Toast.LENGTH_SHORT).show()
        }
    }


}