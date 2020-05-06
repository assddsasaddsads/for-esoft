﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            //задаем новую форму из класса Клиент и открываем ее
            Form formclient = new FormClient();
            formclient.Show();
        }

        private void buttonRealEstates_Click(object sender, EventArgs e)
        {
            //Задаем новую форму из классов Объекты недвижимости и открываем ее
            Form formRealEstate = new FormRealEstate();
            formRealEstate.Show();
        }

        private void buttonOpenAgents_Click(object sender, EventArgs e)
        {
            //задаем новую форму из класса риелторы
            Form formRealtors = new FormAgents();
            formRealtors.Show();
        }

        private void buttonOpenAgents_Click_1(object sender, EventArgs e)
        {
            Form formRealtors = new FormAgents();
            formRealtors.Show();
        }

        private void buttonOpenSupplySet_Click(object sender, EventArgs e)
        {
            //
        }

        private void buttonOpenSupplySet_Click_1(object sender, EventArgs e)
        {
            Form formsupply = new FormSupply();
            formsupply.Show();
        }

        private void buttonOpenSupplies_Click(object sender, EventArgs e)
        {
            Form formdemand = new FormDemand();
            formdemand.Show();
        }

        private void buttonOpenDeals_Click(object sender, EventArgs e)
        {
            Form formdeal = new FormDeal();
            formdeal.Show();
        }
    }
}
