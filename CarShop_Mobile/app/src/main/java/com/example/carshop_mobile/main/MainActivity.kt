package com.example.carshop_mobile.main

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.LinearLayout
import com.example.carshop_mobile.R

class MainActivity : AppCompatActivity() {
    lateinit var btnAppointment: LinearLayout
    lateinit var btnCarPickup: LinearLayout

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        initializeComponents()
        buttonClick()
    }

    private fun initializeComponents() {
        btnAppointment = findViewById(R.id.btnAppointment)
        btnCarPickup = findViewById(R.id.btnCarPickUp)
    }

    private fun buttonClick() {
        btnAppointment.setOnClickListener{
            val intent = Intent(it.context,AppointmentActivity::class.java)
            startActivity(intent)
        }
        btnCarPickup.setOnClickListener{
        }
    }
}