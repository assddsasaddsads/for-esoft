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
    public partial class FormSupply : Form
    {
        public FormSupply()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            ShowRealEstate();
            ShowSupplySet();
        }

        private void FormSupply_Load(object sender, EventArgs e)
        {

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
                string[] item = {realtorsSet.Id.ToString()+".", realtorsSet.FirstName, realtorsSet.MiddleName, realtorsSet.LastName};
                comboBoxAgents.Items.Add(string.Join(" ", item));
            }

        }
        void ShowClients()
        {
            //очищаем comdoBox
            comboBoxClients.Items.Clear();
            foreach(ClientsSet clientsSet in Program.wftdb.ClientsSet)
            {
                //Добавляем информацию, которую хотим видеть в строке comboBox-a
                //Можно настроить по своему усмотрению, добавить/удалить некоторые элементы и сокращения
                //главное, не убирать ID, так как он нужен для дальнейшей работы
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.FirtsName, clientsSet.MiddleName, clientsSet.LastName };
                comboBoxClients.Items.Add(string.Join("", item));
            }
        }
        void ShowRealEstate()
        {
            //очищаем comboBox
            comboBoxRealEstate.Items.Clear();
            foreach(RealEstateSet realEstateSet in Program.wftdb.RealEstateSet)
            {
                //Добавляем информацию, которую хотим видеть в строке comboBox-a
                //Можно настроить по своему усмотрению, добавить/удалить некоторые элементы и сокращения
                //главное, не убирать ID, так как он нужен для дальнейшей работы
                string[] item = {realEstateSet.Id.ToString()+".", realEstateSet.Address_City+ ",", realEstateSet.Address_Street+",",
                "д. "+ realEstateSet.Address_House+ ",","кв. "+realEstateSet.Address_Number};
                comboBoxRealEstate.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //проверяем, что все поля (раскрывающихся списков и текстового поля) были заполнены
            if (comboBoxAgents.SelectedItem!=null && comboBoxClients.SelectedItem!=null && comboBoxRealEstate!=null && textBoxPrice.Text!="")
            {
                //создаем новый экземпляр класса Предложение
                SupplySet supply = new SupplySet();
                //из выбранной строки в comboboxAgents отделяем ID риелтора (он отделен точкой) и делаем ссылку suply.IdAgen
                supply.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                //точно также отделяем и заносим Id клиента
                supply.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                //отделяем и заносим Id объекта недвижимости
                supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                //цена объекта недвижимости чаще всгео превосходит миллион, поэтому используем int64
                supply.Price = Convert.ToInt64(textBoxPrice.Text);
                //добавляем в таблицу SupplySet новый объект недвижимости supply
                Program.wftdb.SupplySet.Add(supply);
                //сохраняем изменения в модели
                Program.wftdb.SaveChanges();
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void ShowSupplySet()
        {
            //очищаем все listView
            listViewSupplySet.Items.Clear();
            //проходим по коллекции клиентов, которые находятся в базе с помощью foreach
            foreach(SupplySet supply in Program.wftdb.SupplySet)
            {
                //создадим новый элемент в listView с помощью массива строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    //ID риелтора
                    supply.IdAgent.ToString(),
                    //ФИО риелтора (фамилия+имя+отчество)
                    supply.AgentsSet.LastName+" "+supply.AgentsSet.FirstName+" "+supply.AgentsSet.MiddleName,
                    supply.IdClient.ToString(),
                    supply.ClientsSet.LastName+" "+supply.ClientsSet.FirtsName+" "+supply.ClientsSet.MiddleName,
                    supply.IdRealEstate.ToString(),
                    "г. "+supply.RealEstateSet.Address_City+", ул. "+supply.RealEstateSet.Address_Street+", д. "+
                    supply.RealEstateSet.Address_House+", кв. "+supply.RealEstateSet.Address_Number,
                    //цена
                    supply.Price.ToString()
                });
                //указываем по какому тегу выбраны элементы
                item.Tag = supply;
                //добавляем элементы в listviewRealEstateSet_Apartment для отображения
                listViewSupplySet.Items.Add(item);
                listViewSupplySet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //если в listView выбран элемент
            if(listViewSupplySet.SelectedItems.Count ==1)
            {
                //ищем элемент из таблицы по тегу
                SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                //указываем, что может быть изменено
                supply.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                supply.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                supply.Price = Convert.ToInt64(textBoxPrice.Text);
                //Сохраняем изменения в модели wftDb
                Program.wftdb.SaveChanges();
                ShowSupplySet();
            }
        }

        private void listViewSupplySet_SelectedIndexChanged(object sender, EventArgs e)
        {
            //если в listView выбран элемент
            if (listViewSupplySet.SelectedItems.Count ==1)
            {
                //ищем элемент из таблицы по тегу
                SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                //указываем,что может быть изменено
                //находим в comboBoxAgents необходимую строку по Id риелтора из supply.IdAgent и задаем ее отображение combobox-у
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(supply.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(supply.IdClient.ToString());
                comboBoxRealEstate.SelectedIndex = comboBoxRealEstate.FindString(supply.IdRealEstate.ToString());
                textBoxPrice.Text = supply.Price.ToString();
            }
            else
            {
                //если не выбран ни один элемент, задаем пустые элементы
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
           
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //пробуем действие
            try
            {
                //если в listview выбран элемент
                if (listViewSupplySet.SelectedItems.Count ==1)
                {
                    //ищем элемент из таблицы по тегу
                    SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                    //удаляем из модели базы данных
                    Program.wftdb.SupplySet.Remove(supply);
                    //сохраняем изменения
                    Program.wftdb.SaveChanges();
                    //отображаем обновленный список
                    ShowSupplySet();
                }
                //очищаем все поля
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
            //если возникает какая-то ошибка
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
