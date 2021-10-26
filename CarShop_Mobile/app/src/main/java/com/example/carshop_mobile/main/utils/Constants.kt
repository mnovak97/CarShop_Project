package com.example.carshop_mobile.main.utils

import com.example.carshop_mobile.main.Model.AppointmentTime
import java.text.ParseException
import java.text.SimpleDateFormat
import java.util.*
import kotlin.collections.ArrayList

class Constants {
    companion object{
        const val PREFERENCE_NAME = "my_preferences"
        const val USER = "user"
        const val USER_ID = "user_id"
        const val USER_USERNAME = "user_username"
        const val USER_EMAIL = "user_email"
        const val MONDAY = "Monday"
        const val TUESDAY = "Tuesday"
        const val WEDNESDAY = "Wednesday"
        const val THURSDAY = "Thursday"
        const val FRIDAY = "Friday"
        const val SATURDAY = "Saturday"
        const val SUNDAY = "Sunday"
        const val WEEK_DAY = "Week day"

        fun getMonthFormat(month: Int): String {
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
        fun getMonthFormatFull(month: Int) : String{
            var montStringFull:String = ""

            if (month == 1)
                montStringFull = "January"
            if (month == 2)
                montStringFull = "February"
            if (month == 3)
                montStringFull = "March"
            if (month == 4)
                montStringFull = "April"
            if (month == 5)
                montStringFull = "May"
            if (month == 6)
                montStringFull = "June"
            if (month == 7)
                montStringFull = "July"
            if (month == 8)
                montStringFull = "August"
            if (month == 9)
                montStringFull = "September"
            if (month == 10)
                montStringFull = "October"
            if (month == 11)
                montStringFull = "November"
            if (month == 12)
                montStringFull = "December"

            return montStringFull
        }
        fun getDayString(year: Int, month: Int, day: Int): String {
            val inFormat = SimpleDateFormat("dd-MM-yyyy")
            var dayString : String = ""
            try {
                val myDate: Date = inFormat.parse("$day-$month-$year")
                val simpleDateFormat = SimpleDateFormat("EEEE")
                dayString = simpleDateFormat.format(myDate)
            }
            catch (e: ParseException)
            {
                e.printStackTrace()
            }
            return dayString
        }
        fun daySpots(day:String) : ArrayList<AppointmentTime>{
            var spots = arrayListOf<AppointmentTime>()
            var first = AppointmentTime("09.00 - 10.00",true)
            var second = AppointmentTime("10.00 - 11.00",true)
            var third = AppointmentTime("11.00 - 12.00",true)
            var fourth = AppointmentTime("13.00 - 14.00",true)
            var fifth = AppointmentTime("14.00 - 15.00",true)
            var sixth = AppointmentTime("15.00 - 16.00",true)
            var seventh = AppointmentTime("16.00 - 17.00",true)

            if (day == WEEK_DAY)
                spots = arrayListOf(first,second,third,fourth,fifth,sixth,seventh)
            else if(day == SATURDAY)
                spots = arrayListOf(first,second,third)
            return spots
        }

        fun getItems(day:String): ArrayList<AppointmentTime> {
            var spots = arrayListOf<AppointmentTime>()
            if (day == MONDAY)
                spots = daySpots(WEEK_DAY)
            if(day == TUESDAY)
                spots = daySpots(WEEK_DAY)
            if (day == WEDNESDAY)
                spots = daySpots(WEEK_DAY)
            if (day == TUESDAY)
                spots = daySpots(WEEK_DAY)
            if (day == FRIDAY)
                spots = daySpots(WEEK_DAY)
            if (day == SATURDAY)
                spots = daySpots(SATURDAY)
            if (day == SUNDAY)
                spots = arrayListOf()

            return spots
        }
    }
}