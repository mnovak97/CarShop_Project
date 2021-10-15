package com.example.carshop_mobile.main

import android.app.AlertDialog
import android.app.DatePickerDialog
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.*
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.example.carshop_mobile.R
import com.example.carshop_mobile.main.Model.AppointmentTime
import com.example.carshop_mobile.main.adapters.AppointmentTimeAdapter
import java.util.*
import kotlin.collections.ArrayList

class AppointmentActivity : AppCompatActivity() {

    lateinit var btnExit : ImageButton
    lateinit var btnPickDate : Button
    lateinit var datePickerDialog : DatePickerDialog
    lateinit var btnAddAppointment : Button
    lateinit var txtName :EditText
    lateinit var txtPhone:EditText
    private lateinit var gridView:GridView
    private lateinit var adapter : AppointmentTimeAdapter
    private var exactMonth : Int = 0
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_appointment)
        initializeComponents()
        setOnClickEvents()
    }

    private fun initializeComponents() {
        btnExit = findViewById(R.id.btnExitAppointment)
        btnPickDate = findViewById(R.id.btnPickDate)
        btnAddAppointment = findViewById(R.id.btnAddAppointment)
        txtName = findViewById(R.id.txtName)
        txtPhone = findViewById(R.id.txtPhone)
        btnPickDate.text = getTodayDate()
        var dateSetListener = DatePickerDialog.OnDateSetListener { _, year, month, day ->
            exactMonth = month+1
            var date:String = makeDateString(day,exactMonth,year)
            btnPickDate.text = date
        }
        gridView = findViewById(R.id.gridTime)
        adapter = AppointmentTimeAdapter(applicationContext,getItems())
        gridView.adapter = adapter
        var cal: Calendar = Calendar.getInstance()
        var year:Int = cal.get(Calendar.YEAR)
        var month:Int = cal.get(Calendar.MONTH)
        var day:Int = cal.get(Calendar.DAY_OF_MONTH)
        var style:Int = AlertDialog.THEME_HOLO_DARK
        datePickerDialog = DatePickerDialog(this,style,dateSetListener,year,month,day)

    }

    private fun getItems(): ArrayList<AppointmentTime> {
        var item = AppointmentTime("09.00 - 10.00",true)
        var item1 = AppointmentTime("10.00 - 11.00",true)
        var item2 = AppointmentTime("11.00 - 12.00",true)
        var item3 = AppointmentTime("13.00 - 14.00",true)
        var item4 = AppointmentTime("14.00 - 15.00",false)
        var item5 = AppointmentTime("15.00 - 16.00",true)
        var item6 = AppointmentTime("16.00 - 17.00",false)

        return arrayListOf(item,item1,item2,item3,item4,item5,item6)
    }

    private fun getTodayDate(): String {
        var cal: Calendar = Calendar.getInstance()
        var year:Int = cal.get(Calendar.YEAR)
        var month:Int = cal.get(Calendar.MONTH)
        month = month+1
        var day:Int = cal.get(Calendar.DAY_OF_MONTH)

        return makeDateString(day,month,year)
    }

    private fun makeDateString(day: Int, month: Int, year: Int): String {
        return getMonthFormat(month) + " " + day + " " + year
    }

    private fun getMonthFormat(month: Int): String {
        var montString:String = ""

        if (month == 1)
            montString = "JAN"
        if (month == 2)
            montString = "FEB"
        if (month == 3)
            montString = "MAR"
        if (month == 4)
            montString = "APR"
        if (month == 5)
            montString = "MAY"
        if (month == 6)
            montString = "JUN"
        if (month == 7)
            montString = "JUL"
        if (month == 8)
            montString = "AUG"
        if (month == 9)
            montString = "SEP"
        if (month == 10)
            montString = "OCT"
        if (month == 11)
            montString = "NOV"
        if (month == 12)
            montString = "DEC"

        return montString
    }

    private fun setOnClickEvents() {
        btnExit.setOnClickListener {
            finish()
        }
        btnPickDate.setOnClickListener {
            datePickerDialog.show()
        }
    }
}