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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ShowClient();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //создаем новый экземпляр класса Клиент
            ClientsSet clientSet = new ClientsSet();
            //делаем ссылку на объект, который хранится в textbox-ax
            clientSet.FirtsName = textBoxFirstName.Text;
            clientSet.MiddleName = textBoxMiddleName.Text;
            clientSet.LastName = textBoxLastName.Text;
            clientSet.Phone = textBoxPhone.Text;
            clientSet.Email = textBoxEmail.Text;
            //Добавляем в таблицу ClientsSet нового клиента clientSet
            Program.wftdb.ClientsSet.Add(clientSet);
            //Сохраняем изменения в модели wftDb (экземпляр которой был создан раннее)
            Program.wftdb.SaveChanges();
            ShowClient();
        }
        void ShowClient()
        {
            //предварительно очищаем listView
            listViewClient.Items.Clear();
            //проходимся по коллекции клиентов, которые находятся в базе с помощью foreach
            foreach (ClientsSet clientsSet in Program.wftdb.ClientsSet)
            {
                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
                    {
                        //указываем необходимые поля
                        clientsSet.Id.ToString(), clientsSet.FirtsName, clientsSet.MiddleName,
                        clientsSet.LastName, clientsSet.Phone, clientsSet.Email
});
                //указываю по какому тегу будет брать элементы
                item.Tag = clientsSet;
                //добавляем элементы в listView для отображения
                listViewClient.Items.Add(item);
            }
            //выравниваем колонки в listView
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //условие, если в listView выбран 1 элемент
            if (listViewClient.SelectedItems.Count ==1)
            {
                //ищем элементы из таблицы по тегу
                ClientsSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                //указываем, что омжет быть изменено
                clientsSet.FirtsName = textBoxFirstName.Text;
                clientsSet.MiddleName = textBoxMiddleName.Text;
                clientsSet.LastName = textBoxLastName.Text;
                clientsSet.Phone = textBoxPhone.Text;
                clientsSet.Email = textBoxEmail.Text;
                //сохраняем изменения в модели wftDb (экземпляр который был создан ранее)
                Program.wftdb.SaveChanges();
                //отображение в listView
                ShowClient();
            }
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //условие, если в listView выбран 1 элемент
            if (listViewClient.SelectedItems.Count == 1)
            {
                //ищем элементы из таблицы по тегу
                ClientsSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                //указываем, что может быть изменено
                textBoxFirstName.Text = clientsSet.FirtsName;
                textBoxMiddleName.Text = clientsSet.MiddleName;
                textBoxLastName.Text = clientsSet.LastName;
                textBoxPhone.Text = clientsSet.Phone;
                textBoxEmail.Text = clientsSet.Email;
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задает пустые поля
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //пробуем совершить действие
            try
            {
                //если выбран 1 элемент из listViews
                if (listViewClient.SelectedItems.Count == 1)
                {
                    //ищем этот элемент, сверяем его
                    ClientsSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                    //удаляем из модели и базы данных
                    Program.wftdb.ClientsSet.Remove(clientsSet);
                    //сохраняем изменения
                    Program.wftdb.SaveChanges();
                    //отображаем обновленный список 
                    ShowClient();
                }
                //очищаем textBox-ы
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            //если возникает какая-то ошибка, к примеру, запись используется, выводим всплывающее сообщение
            catch
            {
                //вызываем метод для всплывающего окна, в котором указываем текст, заголовок, кнопку и иконку
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
