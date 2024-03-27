using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSol.model
{
    public class habitaciones
    {
        private int numeroHab;
        private int capacidad;
        private bool estaOcupada;
        private float precioNoche;
        private tipoHabitacion tipo;

        public habitaciones()
        {

        }

        public habitaciones(int numero, float precio, tipoHabitacion tipo)
        {
            this.numeroHab = numero;
            this.precioNoche = precio;
            this.tipo = tipo;
            this.estaOcupada = false;
        }

        public int getNumeroHab()
        {
            return numeroHab;
        }
        public int getCapacidad()
        {
            return capacidad;
        }

        public bool isEstaOcupada()
        {
            return estaOcupada;
        }

        public float getPrecioNoche()
        {
            return precioNoche;
        }
        public tipoHabitacion getTipo()
        {
            return tipo;
        }
        public void setNumHabitacion(int numero) { 
            this.numeroHab = numero;
        }
        public void setPrecioNoche(float precio)
        {
            this.precioNoche = precio;
        }
        public void setTipoHabiatacion(tipoHabitacion tipo)
        {
            this.tipo = tipo;
        }
        public void setEstaOcupada(bool estaOcupada)
        {
            this.estaOcupada= estaOcupada;
        }
        public void setCapacidad(int capacidad)
        {
            this.capacidad = capacidad;
        }
       
    }
}
