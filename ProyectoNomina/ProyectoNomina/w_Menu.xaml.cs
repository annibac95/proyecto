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
    /// Lógica de interacción para w_Menu.xaml
    /// </summary>
    public partial class w_Menu : Window
    {
        public w_Menu()
        {
            InitializeComponent();
        }

        private void menuEmpleado_Click(object sender, RoutedEventArgs e)
        {
            w_Empleados  ventanaEmpleados = new w_Empleados();
            ventanaEmpleados.ShowDialog();
        }

        private void MenuTurno_Click(object sender, RoutedEventArgs e)
        {
            w_Turnos ventanaTurno = new w_Turnos();
           ventanaTurno.ShowDialog();

        }

        private void MenuConcepto_Click(object sender, RoutedEventArgs e)
        {
            w_Concepto ventanaConcepto = new w_Concepto();
            ventanaConcepto.ShowDialog();
        }

        private void menuVacaciones_Click(object sender, RoutedEventArgs e)
        {
            w_vacaciones ventanaVacaciones = new w_vacaciones();
            ventanaVacaciones.ShowDialog();

        }

        private void menuPermiso_Click(object sender, RoutedEventArgs e)
        {
            w_Permiso ventanaPermisos = new w_Permiso();
            ventanaPermisos.ShowDialog();
        }

        private void menuAnticipo_Click(object sender, RoutedEventArgs e)
        {
            w_AnticipoSalarial ventanaAnticipo = new w_AnticipoSalarial();
            ventanaAnticipo.ShowDialog();
        }
    }
}