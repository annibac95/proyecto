﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProyectoNomina
{

    
    /// <summary>
    /// Lógica de interacción para w_Inicio.xaml
    /// </summary>
    public partial class w_Inicio : Window
    {


        NominaEntities datos;
        public w_Inicio()
        {
            InitializeComponent();
            datos = new NominaEntities();
        }
        
        private void Limpiar()
        {
            txtUsuario.Text = string.Empty;
            txtPass.Password = string.Empty;
        }
        private void btnIniciar_Click(object sender, RoutedEventArgs e)
        {
            var b = 0;
            var usuario = datos.Usuario.ToList();
            foreach (var c in usuario)
            {

                if (txtUsuario.Text.Equals(c.Usuario1) & txtPass.Password.Equals(c.Password))
                {

                    Usuario usu = new Usuario();
                    var empleadoID = c.Empleado_Id;
                    var usuarioID = c.Id_Usuario;
                    var usuNom = c.Usuario1;
                    usu.AsignarUsuario(usuarioID, empleadoID, usuNom);


                    w_Menu ventana = new w_Menu();

                    this.Close();
                    ventana.ShowDialog();
                   
                    b = 1;
                }


            }
            if (b == 0)
            {
                MessageBox.Show("Tus datos están incorrectos!");
                Limpiar();
            }
        }
    }
}
