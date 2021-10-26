package com.example.carshop_mobile.main.adapters

import android.content.Context
import android.graphics.Color
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.BaseAdapter
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.example.carshop_mobile.R
import com.example.carshop_mobile.main.Model.AppointmentTime


class AppointmentTimeAdapter(var context: Context,var list: List<AppointmentTime>) : BaseAdapter() {

    override fun getCount(): Int {
        return list.count()
    }

    override fun getItem(position: Int): Any {
        return list[position]
    }

    override fun getItemId(position: Int): Long {
        return position.toLong()
    }

    override fun getView(position: Int, p1: View?, p2: ViewGroup?): View {
        var view: View = View.inflate(context,R.layout.appointment_time_item,null)
        var time :TextView = view.findViewById(R.id.txtTime)
        var available : TextView = view.findViewById(R.id.txtAvailable)

        var timeSlotItem : AppointmentTime = list[position]

        time.text = timeSlotItem.time
        if (timeSlotItem.available)
        {
            available.text = "Available"
            available.setTextColor(Color.GREEN)
        }
        else if(!timeSlotItem.available)
        {
            available.text = "Unavailable"
            available.setTextColor(Color.RED)
        }

        return view
    }


}