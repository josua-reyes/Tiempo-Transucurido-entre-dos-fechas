using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularDias_Click(object sender, EventArgs e)
        {
            DateTime dtFecha1;
            DateTime dtFecha2;
            TimeSpan tsTiempoTranscurrido;
            DateTime dtiempoTranscurrido;
            string strAnios;
            string strMeses;
            string strDias;
            string strHoras;
            string strMinutos;
            string strSegundos;
            string StrResultado;

            dtFecha1 = dtpFecha1.Value;
            dtFecha2 = dtpFecha2.Value;
            tsTiempoTranscurrido = dtFecha2 - dtFecha1;
            dtiempoTranscurrido = new DateTime(tsTiempoTranscurrido.Ticks);
            strAnios = (dtiempoTranscurrido.Year - 1).ToString();
            strMeses = (dtiempoTranscurrido.Month - 1).ToString();
            strDias = (dtiempoTranscurrido.Day - 1).ToString();
            strHoras = dtiempoTranscurrido.Hour.ToString();
            strMinutos = dtiempoTranscurrido.Minute.ToString();
            strSegundos = dtiempoTranscurrido.Second.ToString();

            StrResultado = String.Format("{0} Años, {1} Meses, {2} Días, {3} Horas, {4} Minutos, {5} Segundos",
               strAnios, strMeses, strDias, strHoras, strMinutos, strSegundos);

            txtResultado.Text = StrResultado;
        }
    }
}
