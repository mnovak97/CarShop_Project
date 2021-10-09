package com.example.carshop_mobile.main

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import com.example.carshop_mobile.R

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        buttonClick()
    }

    private fun buttonClick() {
        val btnAppointment = findViewById<Button>(R.id.btnAppointment)
        btnAppointment.setOnClickListener{view ->

        }
        val btnCarPickup = findViewById<Button>(R.id.btnCarPickUp)
        btnCarPickup.setOnClickListener{view ->

        }
    }
}