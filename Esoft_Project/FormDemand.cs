using System;
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
    public partial class FormDemand : Form
    {
        public FormDemand()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            comboBoxRealEstate.SelectedIndex = 0;
            ShowDemandSet();
        }
        void ShowAgents()
        {
            //очищаем comboBox 
            comboBoxAgents.Items.Clear();
            foreach (AgentsSet realtorsSet in Program.wftdb.AgentsSet)
            {
                //Добавляем информацию, которую хотим видеть в строке comboBox-a
                //Можно настроить по своему усмотрению, добавить/удалить некоторые элементы и сокращения
                //главное, не убирать ID, так как он нужен для дальнейшей работы
                string[] item = { realtorsSet.Id.ToString() + ".", realtorsSet.FirstName, realtorsSet.MiddleName, realtorsSet.LastName };
                comboBoxAgents.Items.Add(string.Join(" ", item));
            }

        }
        void ShowClients()
        {
            //очищаем comdoBox
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wftdb.ClientsSet)
            {
                //Добавляем информацию, которую хотим видеть в строке comboBox-a
                //Можно настроить по своему усмотрению, добавить/удалить некоторые элементы и сокращения
                //главное, не убирать ID, так как он нужен для дальнейшей работы
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.FirtsName, clientsSet.MiddleName, clientsSet.LastName };
                comboBoxClients.Items.Add(string.Join("", item));
            }
            listViewApartments.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewHouse.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewLand.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void comboBoxRealEstate_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Изменение формы, если выбрана строчка "Квартира" (ее индекс 0)
            if (comboBoxRealEstate.SelectedIndex == 0)
            {
                //Делаем видимыми нужные элементы
                listViewApartments.Visible = true;
                comboBoxClients.Visible = true;
                labelClients.Visible = true;
                comboBoxAgents.Visible = true;
                labelAgents.Visible = true;
                labelMinPrice.Visible = true;
                textBoxMinPrice.Visible = true;
                labelMaxPrice.Visible = true;
                textBoxMaxPrice.Visible = true;
                labelMinKolKom.Visible = true;
                textBoxMinKolKom.Visible = true;
                labelMaxKolKom.Visible = true;
                textBoxMaxKolKom.Visible = true;
                textBoxMinFloor.Visible = true;
                textBoxMaxFloor.Visible = true;
                labelMinFloor.Visible = true;
                labelMaxFloor.Visible = true;
                textBoxMinArea.Visible = true;
                textBoxMaxArea.Visible = true;
                labelMaxArea.Visible = true;
                labelMinArea.Visible = true;

                //Скрываем ненужные элементы
                listViewHouse.Visible = false;
                listViewLand.Visible = false;
                labelMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                textBoxMaxFloors.Visible = false;

                //Очищаем все видимые элементы
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
                textBoxMinKolKom.Text = "";
                textBoxMaxKolKom.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";

            }
            else if (comboBoxRealEstate.SelectedIndex == 1)
            {//дом
                //Делаем видимыми нужные элементы
                listViewHouse.Visible = true;
                comboBoxAgents.Visible = true;
                labelAgents.Visible = true;
                comboBoxClients.Visible = true;
                labelClients.Visible = true;
                labelMinPrice.Visible = true;
                labelMaxPrice.Visible = true;
                textBoxMinPrice.Visible = true;
                textBoxMaxPrice.Visible = true;
                textBoxMinFloors.Visible = true;
                textBoxMaxFloors.Visible = true;
                labelMinFloors.Visible = true;
                labelMaxFloors.Visible = true;
                textBoxMinArea.Visible = true;
                textBoxMaxArea.Visible = true;
                labelMinArea.Visible = true;
                labelMaxArea.Visible = true;



                //Скрываем ненужные элементы
                listViewApartments.Visible = false;
                listViewLand.Visible = false;
                labelMinKolKom.Visible = false;
                textBoxMinKolKom.Visible = false;
                labelMaxKolKom.Visible = false;
                textBoxMaxKolKom.Visible = false;
                textBoxMinKolKom.Visible = false;
                textBoxMaxKolKom.Visible = false;
                labelMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                textBoxMaxFloor.Visible = false;

                //Очищаем все видимые элементы
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
                textBoxMinKolKom.Text = "";
                textBoxMaxKolKom.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
            }
            else if (comboBoxRealEstate.SelectedIndex == 2)
            {// земля
                //Делаем видимыми нужные элементы
                listViewLand.Visible = true;
                comboBoxAgents.Visible = true;
                comboBoxClients.Visible = true;
                labelMinPrice.Visible = true;
                labelMaxPrice.Visible = true;
                labelAgents.Visible = true;
                labelMinArea.Visible = true;
                labelMaxArea.Visible = true;
                textBoxMinPrice.Visible = true;
                textBoxMaxPrice.Visible = true;
                textBoxMinArea.Visible = true;
                textBoxMaxArea.Visible = true;


                //Скрываем ненужные элементы
                listViewApartments.Visible = false;
                listViewHouse.Visible = false;
                labelMaxFloor.Visible = false;
                labelMinFloor.Visible = false;
                labelMinKolKom.Visible = false;
                labelMaxKolKom.Visible = false;
                textBoxMaxFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                textBoxMinKolKom.Visible = false;
                textBoxMaxKolKom.Visible = false;
                labelMinKolKom.Visible = false;
                labelMaxKolKom.Visible = false;
                textBoxMinFloors.Visible = false;
                textBoxMaxFloors.Visible = false;
                labelMaxFloors.Visible = false;
                labelMinFloors.Visible = false;


                //Очищаем все видимые элементы
                textBoxMinPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMaxPrice.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            DemandSet demandSet = new DemandSet();
            demandSet.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
            demandSet.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
            demandSet.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
            demandSet.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
            demandSet.MinArea = Convert.ToInt32(textBoxMinArea.Text);
            demandSet.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
            demandSet.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
            demandSet.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);

            //Дополнительные поля для типа "Квартира"
            if (comboBoxRealEstate.SelectedIndex == 0)
            {
                demandSet.Type = 0;
                demandSet.MinRooms = Convert.ToInt32(textBoxMinKolKom.Text);
                demandSet.MaxRooms = Convert.ToInt32(textBoxMaxKolKom.Text);
                demandSet.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                demandSet.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
            }
            //Дополнительные поля для типа "Дом"
            else if (comboBoxRealEstate.SelectedIndex == 1)
            {
                demandSet.Type = 1;
                demandSet.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                demandSet.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
            }
            //Дополнительные поля для типа "Земля"
            else
            {
                demandSet.Type = 2;
            }

            Program.wftdb.DemandSet.Add(demandSet);
            Program.wftdb.SaveChanges();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //выбран тип Квартира
            if(comboBoxRealEstate.SelectedIndex ==0)
            {
                //если в listView выбран элемент
                if (listViewApartments.SelectedItems.Count ==1)
                {
                    DemandSet demandSet = listViewApartments.SelectedItems[0].Tag as DemandSet;
                    demandSet.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                    demandSet.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    demandSet.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                    demandSet.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    demandSet.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                    demandSet.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                    demandSet.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                    demandSet.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                    demandSet.MinRooms = Convert.ToInt32(textBoxMinKolKom.Text);
                    demandSet.MaxRooms = Convert.ToInt32(textBoxMaxKolKom.Text);
                    Program.wftdb.SaveChanges();
                    ShowDemandSet();
                }
            }
            //выбран тип Дом
            else if (comboBoxRealEstate.SelectedIndex ==1)
            {
                if(listViewHouse.SelectedItems.Count ==1)
                {
                    DemandSet demandSet = listViewHouse.SelectedItems[0].Tag as DemandSet;
                    demandSet.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                    demandSet.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    demandSet.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                    demandSet.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                    demandSet.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                    demandSet.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    demandSet.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                    demandSet.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                    Program.wftdb.SaveChanges();
                    ShowDemandSet();
                }
            }
            else
            {
                if(listViewLand.SelectedItems.Count ==1)
                {
                    DemandSet demandSet = listViewLand.SelectedItems[0].Tag as DemandSet;
                    demandSet.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                    demandSet.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    demandSet.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                    demandSet.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                    demandSet.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                    demandSet.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    Program.wftdb.SaveChanges();
                    ShowDemandSet();
                }
            }
        }
        void ShowDemandSet()
        {
            //Предварительно очищаем все ListView
            listViewApartments.Items.Clear();
            listViewHouse.Items.Clear();
            listViewLand.Items.Clear();
            //Проходим по коллекции клиентов, которые находятся в базе
            foreach (DemandSet demandSet in Program.wftdb.DemandSet)
            {
                //отображение квартир в listViewRealEstateSet_Apartment
                if (demandSet.Type == 0)
                {
                    //создадим новый элемент в listViewRealEstateSet_Apartment с помощью массива строк
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        //указываем необходимые поля
                        demandSet.ClientsSet.LastName+" "+demandSet.ClientsSet.FirtsName+" "+demandSet.ClientsSet.MiddleName,
                        demandSet.AgentsSet.LastName+" "+demandSet.AgentsSet.FirstName+" "+demandSet.AgentsSet.MiddleName,
                        demandSet.MinArea.ToString(),
                        demandSet.MaxArea.ToString(),
                        demandSet.MinRooms.ToString(),
                        demandSet.MaxRooms.ToString(),
                        demandSet.MinFloor.ToString(),
                        demandSet.MaxFloor.ToString(),
                        demandSet.MinPrice.ToString(),
                        demandSet.MaxPrice.ToString()
                    });
                    //указываем по какому тегу выбраны
                    item.Tag = demandSet;
                    //добавляем элементы в listViewRealEstateSet_Apartment для отображения
                    listViewApartments.Items.Add(item);

                }
                //отображение домов в listViewRealEstateSet_House
                else if (demandSet.Type == 1)
                {
                    //создадим новый элемент в listViewRealEstateSet_House с помощью массива строк
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        //указываем необходимые поля
                        demandSet.ClientsSet.LastName+" "+demandSet.ClientsSet.FirtsName+" "+demandSet.ClientsSet.MiddleName,
                        demandSet.AgentsSet.LastName+" "+demandSet.AgentsSet.FirstName+" "+demandSet.AgentsSet.MiddleName,
                        demandSet.MinArea.ToString(),
                        demandSet.MaxArea.ToString(),
                        demandSet.MinFloors.ToString(),
                        demandSet.MaxFloors.ToString(),
                        demandSet.MinPrice.ToString(),
                        demandSet.MaxPrice.ToString()
                    });
                    //указываем пок акому тегу выбраны элементы
                    item.Tag = demandSet;
                    //добавляем элементы в listViewRealEstateSet_House для отображения
                    listViewHouse.Items.Add(item);
                }
                else
                {
                    //создадим новый элемент в listViewRealEstateSet_Land с помощью массива строк
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        //указываем необходимые поля
                        demandSet.ClientsSet.LastName+" "+demandSet.ClientsSet.FirtsName+" "+demandSet.ClientsSet.MiddleName,
                        demandSet.AgentsSet.LastName+" "+demandSet.AgentsSet.FirstName+" "+demandSet.AgentsSet.MiddleName,
                        demandSet.MinArea.ToString(),
                        demandSet.MaxArea.ToString(),
                        demandSet.MinPrice.ToString(),
                        demandSet.MaxPrice.ToString()
                    });
                    //указываем по какому тегу выбраны элементы
                    item.Tag = demandSet;
                    //добавляем элементы в listViewRealEstateSet_Land для отображения
                    listViewLand.Items.Add(item);
                }
            }
            //выравниваем столбцы во всех listView
            listViewApartments.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewHouse.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewLand.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewApartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewApartments.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                DemandSet demandSet = listViewApartments.SelectedItems[0].Tag as DemandSet;
                //указываем, что может быть изменено
                comboBoxClients.Text = demandSet.ClientsSet.LastName + " " + demandSet.ClientsSet.FirtsName + " " + demandSet.ClientsSet.MiddleName.ToString();
                comboBoxAgents.Text = demandSet.AgentsSet.LastName + " " + demandSet.AgentsSet.FirstName + " " + demandSet.AgentsSet.MiddleName.ToString();
                textBoxMinArea.Text = demandSet.MinArea.ToString();
                textBoxMaxArea.Text = demandSet.MaxArea.ToString();
                textBoxMinKolKom.Text = demandSet.MinRooms.ToString();
                textBoxMaxKolKom.Text = demandSet.MaxRooms.ToString();
                textBoxMinFloor.Text = demandSet.MinFloor.ToString();
                textBoxMaxFloor.Text = demandSet.MaxFloor.ToString();
                textBoxMinPrice.Text = demandSet.MinPrice.ToString();
                textBoxMaxPrice.Text = demandSet.MaxPrice.ToString();
            }
            else
            {
                //если  не выбран ни один элемент, задаем пустые поля
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinKolKom.Text = "";
                textBoxMaxKolKom.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
            }
        }

        private void listViewHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHouse.SelectedItems.Count == 1)
            {
                DemandSet demandSet = listViewHouse.SelectedItems[0].Tag as DemandSet;
                comboBoxClients.Text = demandSet.ClientsSet.LastName + " " + demandSet.ClientsSet.FirtsName + " " + demandSet.ClientsSet.MiddleName.ToString();
                comboBoxAgents.Text = demandSet.AgentsSet.LastName + " " + demandSet.AgentsSet.FirstName + " " + demandSet.AgentsSet.MiddleName.ToString();
                textBoxMinArea.Text = demandSet.MinArea.ToString();
                textBoxMaxArea.Text = demandSet.MaxArea.ToString();
                textBoxMinFloors.Text = demandSet.MinFloors.ToString();
                textBoxMaxFloors.Text = demandSet.MaxFloors.ToString();
                textBoxMinPrice.Text = demandSet.MinPrice.ToString();
                textBoxMaxPrice.Text = demandSet.MaxPrice.ToString();
            }
            else
            {
                //если  не выбран ни один элемент, задаем пустые поля
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
            }
        }

        private void listViewLand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLand.SelectedItems.Count == 1)
            {
                DemandSet demandSet = listViewLand.SelectedItems[0].Tag as DemandSet;
                comboBoxClients.Text = demandSet.ClientsSet.LastName + " " + demandSet.ClientsSet.FirtsName + " " + demandSet.ClientsSet.MiddleName.ToString();
                comboBoxAgents.Text = demandSet.AgentsSet.LastName + " " + demandSet.AgentsSet.FirstName + " " + demandSet.AgentsSet.MiddleName.ToString();
                textBoxMinArea.Text = demandSet.MinArea.ToString();
                textBoxMaxArea.Text = demandSet.MaxArea.ToString();
                textBoxMinPrice.Text = demandSet.MinPrice.ToString();
                textBoxMaxPrice.Text = demandSet.MaxPrice.ToString();
            }
            else
            {
                //если  не выбран ни один элемент, задаем пустые поля
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxRealEstate.SelectedIndex ==0)
                {
                    if (listViewApartments.SelectedItems.Count ==1)
                    {
                        DemandSet demandSet = listViewApartments.SelectedItems[0].Tag as DemandSet;
                        Program.wftdb.DemandSet.Remove(demandSet);
                        Program.wftdb.SaveChanges();
                        ShowDemandSet();
                    }
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinKolKom.Text = "";
                    textBoxMaxKolKom.Text = "";
                    textBoxMinFloor.Text = "";
                    textBoxMaxFloor.Text = "";
                    comboBoxClients.Text = "";
                    comboBoxAgents.Text = "";
                }
                else if (comboBoxRealEstate.SelectedIndex ==1)
                {
                    if(listViewHouse.SelectedItems.Count ==1)
                    {
                        DemandSet demandSet = listViewHouse.SelectedItems[0].Tag as DemandSet;
                        Program.wftdb.DemandSet.Remove(demandSet);
                        Program.wftdb.SaveChanges();
                        ShowDemandSet();
                    }
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinFloors.Text = "";
                    textBoxMaxFloors.Text = "";
                    comboBoxClients.Text = "";
                    comboBoxAgents.Text = "";
                }
                else
                {
                    if (listViewLand.SelectedItems.Count ==1)
                    {
                        DemandSet demandSet = listViewLand.SelectedItems[0].Tag as DemandSet;
                        Program.wftdb.DemandSet.Remove(demandSet);
                        Program.wftdb.SaveChanges();
                        ShowDemandSet();
                    }
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    comboBoxClients.Text = "";
                    comboBoxAgents.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта записать используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
