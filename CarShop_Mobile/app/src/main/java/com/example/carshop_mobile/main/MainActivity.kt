package com.example.carshop_mobile.main

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.LinearLayout
import android.widget.Toast
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.example.carshop_mobile.R
import com.example.carshop_mobile.main.Model.Appointment
import com.example.carshop_mobile.main.adapters.AppointmentsAdapter
import com.example.carshop_mobile.main.network.JsonPlaceHolderApi
import com.example.carshop_mobile.main.network.RetrofitClientInstance
import com.example.carshop_mobile.main.utils.PreferenceUtils
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response

class MainActivity : AppCompatActivity() {
    lateinit var btnAppointment: LinearLayout
    lateinit var btnCarPickup: LinearLayout
    lateinit var userAppointments: ArrayList<Appointment>

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        initializeComponents()
        buttonClick()
    }

    private fun initializeComponents() {
        btnAppointment = findViewById(R.id.btnAppointment)
        btnCarPickup = findViewById(R.id.btnCarPickUp)
        getUserAppointments()
    }

    private fun getUserAppointments() {
        var user = PreferenceUtils.getUser(applicationContext)
        val service = RetrofitClientInstance.getRetrofitInstance().create(JsonPlaceHolderApi::class.java)
        val call = service.getUserAppointments(user.iDUser!!)
        call.enqueue(object : Callback<ArrayList<Appointment>>{
            override fun onResponse(call: Call<ArrayList<Appointment>>, response: Response<ArrayList<Appointment>>) {
                userAppointments = response.body() as ArrayList<Appointment>
                generateRecyclerViewData()
            }

            override fun onFailure(call: Call<ArrayList<Appointment>>, t: Throwable) {
                call.cancel()
            }
        })
    }

    private fun generateRecyclerViewData() {
        val recyclerView = findViewById<RecyclerView>(R.id.recyclerViewMain)
        val layout  = LinearLayoutManager(this)
        val adapter = AppointmentsAdapter(userAppointments)
        recyclerView.layoutManager = layout
        recyclerView.adapter = adapter
    }

    private fun buttonClick() {
        btnAppointment.setOnClickListener{
            val intent = Intent(it.context,AppointmentActivity::class.java)
            startActivity(intent)
        }
        btnCarPickup.setOnClickListener{
            val intent = Intent(it.context,CarPickupActivity::class.java)
            startActivity(intent)
        }
    }
}