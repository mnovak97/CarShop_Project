package com.example.carshop_mobile.main.utils

import com.example.carshop_mobile.main.Model.Appointment
import com.example.carshop_mobile.main.Model.AppointmentTime
import java.text.ParseException
import java.text.SimpleDateFormat
import java.util.*
import kotlin.collections.ArrayList

class Constants {
    companion object{
        const val PREFERENCE_NAME = "my_preferences"
        const val USER = "user"
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


    }
}