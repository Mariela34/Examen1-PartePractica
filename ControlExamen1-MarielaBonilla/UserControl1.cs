using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ControlExamen1_MarielaBonilla
{
    public partial class UserControl1 : UserControl
    {
        private readonly String[] colores = new string[] { "A", "R", "B", "N", "V", "M" };
        private String[] combinacionOculta = new string[4];
        bool ganador = false;
        int intentosJugador = 0;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            int numeroAzar;
            comparar.Enabled = true;
            texto.Enabled = true;
            winner.Visible = false;
            loser.Visible = false;
            escondida.Text = "XXXX";
            restantes.Text = "8";
            intentos.Text = "0";
            parciales.Text = "0";
            totales.Text = "0";
            texto.Text = "";
            ganador = false;
            intentosJugador = 0;
            var rand = new Random();
        
            for (int i = 0; i < 4; i++)
            {
                numeroAzar = rand.Next(0, 5);
                combinacionOculta[i] = colores[numeroAzar];
            }
           
        }

        private void comparar_Click(object sender, EventArgs e)
        {
            aviso.Text = "";

            if (texto.Text != "")
            {
                intentosJugador++;
                texto.Text = texto.Text.ToUpper();

                if (Int16.Parse(intentos.Text) < 8)
                    intentos.Text = (Int16.Parse(intentos.Text) + 1).ToString();

                if (Int16.Parse(restantes.Text) > 0)
                    restantes.Text = (Int16.Parse(restantes.Text) - 1).ToString();

                parciales.Text = validarCombinacion()[0].ToString();
                totales.Text = validarCombinacion()[1].ToString();
                validarIntentos();
            }
            else
            {
                aviso.Text = "Favor ingrese texto en el espacio para comparar";
            }
        }


        private int[] validarCombinacion()
        {

            int[] array = new int[] { 0, 0 };
            ArrayList noAcertados = new ArrayList();
            String[] palabra = palabraDividida();
            //verifica aciertos totales
            for (int i = 0; i < 4; i++)
            {
                if (combinacionOculta[i].Equals(palabra[i]))
                {
                    array[1] = array[1] + 1;

                }
                else
                {
                    noAcertados.Add(i);
                }
            }
            //verifica si hay 4 aciertos totales para que gane
            if (array[1] == 4)
            {
                ganador = true;
            }
            else
            {
                //verifica los aciertos parciales
                foreach (int pos in noAcertados)
                {
                    foreach (int posLetra in noAcertados)
                    {
                        if (combinacionOculta[pos].Equals(palabra[posLetra]))
                        {
                            array[0] = array[0] + 1;
                        }
                    }
                }
            }
            return array;
     
        }


        private String[] palabraDividida()
        {
            int cont = 0;
            String text = texto.Text.ToUpper();
            String[] palabra = new String[4];
            foreach (char a in text)
            {
                palabra[cont] = a.ToString() ;
                cont++;
            }
            return palabra;
        }

        private void validarIntentos()
        {
            if (ganador == false && intentosJugador > 8)
            {
                loser.Visible = true;
                comparar.Enabled = false;
                texto.Enabled = false;
                escondida.Text = "";
                foreach (String letra in combinacionOculta)
                {
                    escondida.Text = escondida.Text + letra;
                }
            }
            else if (ganador == true)
            {
                winner.Visible = true;
                comparar.Enabled = false;
                texto.Enabled = false;
                escondida.Text = "";
                foreach (String letra in combinacionOculta)
                {
                    escondida.Text = escondida.Text + letra;
                }
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

 
    }
}
