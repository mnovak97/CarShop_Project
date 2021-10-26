package com.example.carshop_mobile.main

import android.annotation.SuppressLint
import android.app.AlertDialog
import android.app.DatePickerDialog
import android.content.res.ColorStateList
import android.graphics.Color
import android.graphics.drawable.Drawable
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.*
import androidx.core.content.ContextCompat
import androidx.core.view.get
import com.example.carshop_mobile.R
import com.example.carshop_mobile.main.Model.Appointment
import com.example.carshop_mobile.main.Model.UserMobile
import com.example.carshop_mobile.main.adapters.AppointmentTimeAdapter
import com.example.carshop_mobile.main.network.JsonPlaceHolderApi
import com.example.carshop_mobile.main.network.RetrofitClientInstance
import com.example.carshop_mobile.main.utils.Constants
import com.example.carshop_mobile.main.utils.PreferenceUtils
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response
import java.text.FieldPosition
import java.text.ParseException
import java.text.SimpleDateFormat
import java.util.*

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
    private var dateString:String = ""
    private var selectedTimeSpotPosition: Int? = null
    private lateinit var currentUser:UserMobile

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_appointment)
        initializeComponents()
        setOnClickEvents()
    }

    private fun initializeComponents() {
        gridView = findViewById(R.id.gridTime)
        btnExit = findViewById(R.id.btnExitAppointment)
        btnPickDate = findViewById(R.id.btnPickDate)
        btnAddAppointment = findViewById(R.id.btnAddAppointment)
        txtName = findViewById(R.id.txtName)
        txtPhone = findViewById(R.id.txtPhone)
        btnPickDate.text = getTodayDate()
        currentUser = PreferenceUtils.getUser(applicationContext)
        val dateSetListener = DatePickerDialog.OnDateSetListener { _, year, month, day ->
            exactMonth = month+1
            dateString = dateString(day,exactMonth,year)
            val date:String = makeDateString(day,exactMonth,year)
            btnPickDate.text = date
            val dayOfTheMontString = Constants.getDayString(year,exactMonth,day)
            adapter = AppointmentTimeAdapter(applicationContext, Constants.getItems(dayOfTheMontString))
            gridView.adapter = adapter
            gridView.setOnItemClickListener { adapterView, view, position, l ->
                selectTimeSpot(view,position)
            }
        }
        val cal: Calendar = Calendar.getInstance()
        val year:Int = cal.get(Calendar.YEAR)
        val month:Int = cal.get(Calendar.MONTH)
        val day:Int = cal.get(Calendar.DAY_OF_MONTH)
        val style:Int = AlertDialog.THEME_HOLO_DARK
        datePickerDialog = DatePickerDialog(this,style,dateSetListener,year,month,day)

    }

    private fun selectTimeSpot(view: View?,position: Int) {
        unSelectTimeSpot();
        selectedTimeSpotPosition = position
        var ll:LinearLayout = view!!.findViewById(R.id.btnAppointment)
        ll.background = ContextCompat.getDrawable(applicationContext,R.drawable.layout_round)
        var time:TextView = view.findViewById(R.id.txtTime)
        time.setTextColor(Color.WHITE)

    }
    private fun unSelectTimeSpot() {
        if(selectedTimeSpotPosition != null){
            var view:View = gridView.get(selectedTimeSpotPosition!!)
            var ll:LinearLayout = view.findViewById(R.id.btnAppointment)
            ll.background = ContextCompat.getDrawable(applicationContext,R.drawable.layout_round_white)
            var time:TextView = view.findViewById(R.id.txtTime)
            time.setTextColor(Color.BLACK)
        }
    }
    private fun getTodayDate(): String {
        val cal: Calendar = Calendar.getInstance()
        val year:Int = cal.get(Calendar.YEAR)
        var month:Int = cal.get(Calendar.MONTH)
        month = month+1
        val day:Int = cal.get(Calendar.DAY_OF_MONTH)

        return makeDateString(day,month,year)
    }
    private fun dateString(day: Int, month: Int, year: Int): String {
        return "$day/$month/$year"
    }

    private fun makeDateString(day: Int, month: Int, year: Int): String {
        return Constants.getMonthFormat(month) + " " + day + " " + year
    }

    private fun setOnClickEvents() {
        btnExit.setOnClickListener {
            finish()
        }
        btnPickDate.setOnClickListener {
            datePickerDialog.show()
        }
        btnAddAppointment.setOnClickListener {
            var view:View = gridView[selectedTimeSpotPosition!!]
            if (view != null){
                var time:TextView = view.findViewById(R.id.txtTime)
                var appointment = Appointment(dateString,time.text.toString(),currentUser,txtName.text.toString(),txtPhone.text.toString(),false)
                val service = RetrofitClientInstance.getRetrofitInstance().create(JsonPlaceHolderApi::class.java)
                val call = service.addAppointment(appointment)
                call.enqueue(object : Callback<Appointment>{
                    override fun onResponse(call: Call<Appointment>, response: Response<Appointment>) {
                        var appointment = response.body()
                        if (appointment != null){
                            Toast.makeText(applicationContext,appointment.customerName,Toast.LENGTH_SHORT).show()
                        }
                    }

                    override fun onFailure(call: Call<Appointment>, t: Throwable) {
                        call.cancel()
                    }

                })
            }
        }
    }
}