package com.example.carshop_mobile.main

import android.content.Intent
import android.os.Bundle
import android.webkit.WebResourceResponse
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.example.carshop_mobile.R
import com.example.carshop_mobile.main.Model.LoginModel
import com.example.carshop_mobile.main.Model.UserMobile
import com.example.carshop_mobile.main.network.JsonPlaceHolderApi
import com.example.carshop_mobile.main.network.RetrofitClientInstance
import com.example.carshop_mobile.main.utils.PreferenceUtils
import okhttp3.ResponseBody
import org.json.JSONObject
import org.json.JSONTokener
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response
import java.net.HttpURLConnection

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
            val intent = Intent(it.context,SignUpActivity::class.java)
            startActivity(intent)
        }
        btnLogin.setOnClickListener {
            var loginModel = LoginModel(txtUsername.text.toString(),txtPassword.text.toString())
            val service = RetrofitClientInstance.getRetrofitInstance().create(JsonPlaceHolderApi::class.java)
            val call = service.userLogin(loginModel)
            call.enqueue(object : Callback<UserMobile>{
                override fun onResponse(call: Call<UserMobile>, response: Response<UserMobile>) {
                    var user = response.body()
                    if (user != null){
                        PreferenceUtils.saveUser(user,applicationContext)
                        val intent = Intent(applicationContext,MainActivity::class.java)
                        startActivity(intent)
                    }
                }
                override fun onFailure(call: Call<UserMobile>, t: Throwable) {
                    call.cancel()
                }


            })
        }
    }

}