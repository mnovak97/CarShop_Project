package com.example.carshop_mobile.main.adapters

import android.graphics.Color
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.example.carshop_mobile.R
import com.example.carshop_mobile.main.Model.Appointment
import com.example.carshop_mobile.main.utils.Constants

class AppointmentsAdapter(var items:ArrayList<Appointment>) : RecyclerView.Adapter<AppointmentsAdapter.ViewHolder>() {

    class ViewHolder(view: View) : RecyclerView.ViewHolder(view)  {
        val nameAppointment: TextView = view.findViewById(R.id.txtNameAppointment)
        val phoneAppointment:TextView = view.findViewById(R.id.txtPhoneAppointment)
        val dateAppointment:TextView = view.findViewById(R.id.txtDateAppointment)
        val timeAppointment:TextView = view.findViewById(R.id.txtTimeAppointment)
        val finishedAppointment:TextView = view.findViewById(R.id.txtFinishedAppointment)
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        val viewHolder = LayoutInflater.from(parent.context).inflate(R.layout.appointment_item,parent,false)
        return ViewHolder(viewHolder)
    }

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        val item:Appointment = items[position]
        holder.nameAppointment.text = "Name: ${item.customerName}"
        holder.phoneAppointment.text = "Phone number: ${item.customerPhone}"
        holder.timeAppointment.text = "Time slot: ${item.time}"
        holder.dateAppointment.text = makeDateString(item.date)
        if (item.finished){
            holder.finishedAppointment.text = "Finished"
            holder.finishedAppointment.setTextColor(Color.GREEN)
        }
        else{
            holder.finishedAppointment.text = "Not finished"
            holder.finishedAppointment.setTextColor(Color.RED)
        }
    }

    override fun getItemCount(): Int {
        return items.size
    }
    private fun makeDateString(date: String): String {
        val delim = "/"
        val array = date.split(delim).toTypedArray()
        val day = array[0]
        val month = array[1]
        val year = array[2]
        val monthString = Constants.getMonthFormatFull(month.toInt())
        val dayString = Constants.getDayString(year.toInt(),month.toInt(),day.toInt())
        return "$dayString, $day $monthString $year"
    }
}