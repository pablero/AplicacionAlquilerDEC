using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlquileresDEC.Interfaces
{
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUtilidad_Click(object sender, EventArgs e)
        {
            rtbMensaje.Text = "¿Para qué sirve?\r\rLa aplicación utiliza la técnica TOPSIS para determinar el orden de preferencia en el que se recomienda alquilar una propiedad.";
        }

        private void btnFuncion_Click(object sender, EventArgs e)
        {
            rtbMensaje.Text = "¿Cómo funciona?\r\rEl programa emplea una base de datos que cuenta con alrededor de 30 departamentos extraídos de diversas inmobiliarias. Es posible filtrar los departamentos en función de los siguientes criterios: precio, barrio, estado, requisitos, servicios, antigüedad y número de habitaciones.\rEn cada uno de estos criterios se puede determinar su objetivo indicando si se desea maximizar o minimizar. Además el usuario puede establecer el peso de cada uno.";
        }

        private void btnCriterios_Click(object sender, EventArgs e)
        {
            rtbMensaje.Text = "Criterios Analizados: \r\r- Precio: Indica el costo monetario para alquilar una propiedad (Casa o Departamento).\r\r- Barrio: Representa la ubicación de la propiedad (Alberdi, Alta Córdoba, Barrio Jardín, Centro, Cerro de las Rosas, Cofico, General Paz, Nueva Córdoba).\r\r- Estado: Indica las condiciones en las que se encuentra la propiedad (Malo, Regular, Bueno, Muy Bueno, Excelente).\r\r- Requisitos: Indica las condiciones necesarias para alquilar una propiedad (garantía propietaria de familiar, recibo de sueldo, documentación, etc.). En función de la cantidad de requisitos solicitados se los clasifica como: Ninguno, Pocos, Algunos, Bastantes, Muchos.\r\r- Servicios: Representa las comodidades que ofrece la propiedad (estacionamiento, muebles, asador, pileta, tv con cable, internet, etc.). En función de la cantidad de servicios solicitados se los clasifica como: Ninguno, Pocos, Algunos, Bastantes, Muchos.\r\r- Antigüedad: Representa el tiempo transcurrido desde su inauguración.\r\r- Número de habitaciones: Indica de cuantas habitaciones dispone la propiedad (1,2, ..., 6).";
        }
        
        private void btnABM_Click(object sender, EventArgs e)
        {
            rtbMensaje.Text = "Registro de Propiedad:\r\rPermite dar de alta una propiedad completando los campos obligatorios indicados con *.";
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            rtbMensaje.Text = "Selección de Alternativas:\r\rPermite realizar la búsqueda filtrando por tipo de propiedad, localidad, barrio, precio y número de habitaciones para mostrar las alternativas candidatas. De esas alternativas candidatas se pueden agregar una en particular o todas las alternativas elegidas. Además se deben seleccionar los criterios indicando su objetivo y el peso de cada criterio.";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            rtbMensaje.Text = "Consultar Propiedad:\r\rPermite realizar la búsqueda de propiedades filtrando por tipo de propiedad, localidad, barrio, precio y número de habitaciones.";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            rtbMensaje.Text = "Modificar Propiedad:\r\rPermite modificar los datos de registro de una propiedad.";       
        }
    }
}
