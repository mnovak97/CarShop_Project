package com.example.carshop_mobile.main

import android.app.AlertDialog
import android.app.DatePickerDialog
import android.graphics.Color
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.*
import androidx.core.content.ContextCompat
import androidx.core.view.get
import com.example.carshop_mobile.R
import com.example.carshop_mobile.main.Model.Appointment
import com.example.carshop_mobile.main.Model.AppointmentTime
import com.example.carshop_mobile.main.Model.State
import com.example.carshop_mobile.main.Model.UserMobile
import com.example.carshop_mobile.main.adapters.AppointmentTimeAdapter
import com.example.carshop_mobile.main.network.JsonPlaceHolderApi
import com.example.carshop_mobile.main.network.RetrofitClientInstance
import com.example.carshop_mobile.main.utils.Constants
import com.example.carshop_mobile.main.utils.PreferenceUtils
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response
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
    private var dateString:String = ""
    private var selectedTimeSpotPosition: Int? = null
    private lateinit var currentUser:UserMobile
    var dayOfTheMontString:String = ""
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
            dayOfTheMontString = Constants.getDayString(year,exactMonth,day)
            getDateAppointments(dateString)
        }
        val cal: Calendar = Calendar.getInstance()
        val year:Int = cal.get(Calendar.YEAR)
        val month:Int = cal.get(Calendar.MONTH)
        val day:Int = cal.get(Calendar.DAY_OF_MONTH)
        val style:Int = AlertDialog.THEME_HOLO_DARK
        datePickerDialog = DatePickerDialog(this,style,dateSetListener,year,month,day)

    }

    private fun getDateAppointments(date:String){
        val service = RetrofitClientInstance.getRetrofitInstance().create(JsonPlaceHolderApi::class.java)
        val call = service.getDateAppointments(date)
        call.enqueue(object : Callback<ArrayList<Appointment>>{
            override fun onResponse(call: Call<ArrayList<Appointment>>, response: Response<ArrayList<Appointment>>) {
                var list: ArrayList<Appointment>
                if (response.body() != null){
                    list = response.body() as ArrayList<Appointment>
                    getItems(dayOfTheMontString, list)
                }
            }
            override fun onFailure(call: Call<ArrayList<Appointment>>, t: Throwable) {
                call.cancel()
            }
        })
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
    fun getItems(day: String, list: ArrayList<Appointment>) {
        var spots = arrayListOf<AppointmentTime>()
        if (day == Constants.MONDAY)
            spots = daySpots(Constants.WEEK_DAY,list)
        if(day == Constants.TUESDAY)
            spots = daySpots(Constants.WEEK_DAY,list)
        if (day == Constants.WEDNESDAY)
            spots = daySpots(Constants.WEEK_DAY,list)
        if (day == Constants.THURSDAY)
            spots = daySpots(Constants.WEEK_DAY,list)
        if (day == Constants.FRIDAY)
            spots = daySpots(Constants.WEEK_DAY,list)
        if (day == Constants.SATURDAY)
            spots = daySpots(Constants.SATURDAY,list)
        if (day == Constants.SUNDAY)
            spots = arrayListOf()

        adapter = AppointmentTimeAdapter(applicationContext, spots)
        gridView.adapter = adapter
        gridView.setOnItemClickListener { adapterView, view, position, l ->
            selectTimeSpot(view,position)
        }
    }
    fun daySpots(day:String,list:ArrayList<Appointment>) : ArrayList<AppointmentTime>{
        var spots: ArrayList<AppointmentTime>
        var spotsAvailable = arrayListOf<AppointmentTime>()
        var first = AppointmentTime("09.00 - 10.00",true)
        var second = AppointmentTime("10.00 - 11.00",true)
        var third = AppointmentTime("11.00 - 12.00",true)
        var fourth = AppointmentTime("13.00 - 14.00",true)
        var fifth = AppointmentTime("14.00 - 15.00",true)
        var sixth = AppointmentTime("15.00 - 16.00",true)
        var seventh = AppointmentTime("16.00 - 17.00",true)

        if (day == Constants.WEEK_DAY){
            spots = arrayListOf(first,second,third,fourth,fifth,sixth,seventh)
            spotsAvailable = getAvailable(spots,list)
        }
        else if(day == Constants.SATURDAY){
            spots = arrayListOf(first,second,third)
            spotsAvailable = getAvailable(spots,list)
        }
        return spotsAvailable
    }
    private fun getAvailable(spots: ArrayList<AppointmentTime>,dateAppointments:ArrayList<Appointment>):ArrayList<AppointmentTime> {
        var spotsAvailable = arrayListOf<AppointmentTime>()
        for (spot:AppointmentTime in spots){
            if (dateAppointments.size != 0){
                for(date:Appointment in dateAppointments){
                    if (spot.time == date.time){
                        spot.available = false
                    }
                }
                spotsAvailable.add(spot)
            }
            else{
                spotsAvailable.add(spot)
            }
        }
        return spotsAvailable
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
                var appointment = Appointment(dateString,time.text.toString(),currentUser,txtName.text.toString(),txtPhone.text.toString(),State.NotFinished)
                val service = RetrofitClientInstance.getRetrofitInstance().create(JsonPlaceHolderApi::class.java)
                val call = service.addAppointment(appointment)
                call.enqueue(object : Callback<Appointment>{
                    override fun onResponse(call: Call<Appointment>, response: Response<Appointment>) {
                        var appointment = response.body()
                        if (appointment != null){
                            Toast.makeText(applicationContext,"Appointment made successfully!",Toast.LENGTH_SHORT).show()
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