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
    public partial class FormAgents : Form
    {
        public FormAgents()
        {
            InitializeComponent();
            ShowRealtors();
        }

        private void FormRealtors_Load(object sender, EventArgs e)
        {
            //задаем новую форму из класса риелторы
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //создаем новый экземпляр класса
            RealtorsSet realtorsSet = new RealtorsSet();
            //делаем ссылку на объект, который хранится в textBox-ax
            realtorsSet.LastName = textBoxLastName.Text;
            realtorsSet.FirstName = textBoxFirstName.Text;
            realtorsSet.MiddleName = textBoxMiddleName.Text;
            realtorsSet.Share = textBoxShare.Text;
            //добавляем в таблицу RealtorsSet нового риелтора
            Program.wftdb.RealtorsSet.Add(realtorsSet);
            //сохраняем изменения в модели wftDb
            Program.wftdb.SaveChanges();
            ShowRealtors();
        }
        void ShowRealtors()
        {
            //очищаем listView
            listViewRealtors.Items.Clear();
            //проходимся по коллекции риелторов, которые находятся в базе с помощью foreach
            foreach (RealtorsSet realtorsSet in Program.wftdb.RealtorsSet)
            {
                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    realtorsSet.Id.ToString(), realtorsSet.LastName, realtorsSet.FirstName,
                    realtorsSet.MiddleName, realtorsSet.Share
                });
                //указываем по какому тегу будем брать элементы
                item.Tag = realtorsSet;
                //добавляем элементы в listView для отображения
                listViewRealtors.Items.Add(item);
            }
            //выравниваем колонки в listView 
            listViewRealtors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //условие, если в listView выбран 1 элемент
            if (listViewRealtors.SelectedItems.Count ==1)
            {
                //ищем элемент из таблицы по тегу
                RealtorsSet realtorsSet = listViewRealtors.SelectedItems[0].Tag as RealtorsSet;
                //указываем, что может быть изменено
                realtorsSet.LastName = textBoxLastName.Text;
                realtorsSet.FirstName = textBoxFirstName.Text;
                realtorsSet.MiddleName = textBoxMiddleName.Text;
                realtorsSet.Share = textBoxShare.Text;
                //сохраняем изменения в модели wftDb
                Program.wftdb.SaveChanges();
                //отображение в listview
                ShowRealtors();
            }
        }

        private void listViewRealtors_SelectedIndexChanged(object sender, EventArgs e)
        {
            //условие, если выбран 1 элемент
            if (listViewRealtors.SelectedItems.Count ==1)
            {
                //ищем элемент из таблицы по тегу
                RealtorsSet realtorsSet = listViewRealtors.SelectedItems[0].Tag as RealtorsSet;
                //указываем, что может быть изменено
                textBoxLastName.Text = realtorsSet.LastName;
                textBoxFirstName.Text = realtorsSet.FirstName;
                textBoxMiddleName.Text = realtorsSet.MiddleName;
                textBoxShare.Text = realtorsSet.Share;
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxLastName.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxShare.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //пробуем совершить действие
            try
            {
                //если выбран 1 элемент из listView
                if (listViewRealtors.SelectedItems.Count ==1)
                {
                    //ищем этот элемент, сверяем его
                    RealtorsSet realtorsSet = listViewRealtors.SelectedItems[0].Tag as RealtorsSet;
                    //удаляем из модели и базы данных
                    Program.wftdb.RealtorsSet.Remove(realtorsSet);
                    //сохраняем изменения
                    Program.wftdb.SaveChanges();
                    //отображаем обновленный список
                    ShowRealtors();
                }
                //очищаем textBox-ы
                textBoxLastName.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxShare.Text = "";
            }
            catch
            {
                //вызываем метод для всплывающего окна, в котором указываем текст, заголовок, кнопку и иконку
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
