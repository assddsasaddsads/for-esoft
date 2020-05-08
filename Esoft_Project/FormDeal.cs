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
    public partial class FormDeal : Form
    {
        public FormDeal()
        {
            InitializeComponent();
            ShowSupply();
            ShowDemand();
            ShowDealSet();
        }
     void ShowSupply()
        {
            //очищаем comboBox
            comboBoxSupply.Items.Clear();
            foreach (SupplySet supplySet in Program.wftdb.SupplySet)
            {
                //Добавляем информацию, которую хотим видеть в строке comboBox-a
                //можно настроить по своему усмотрению, добавить/удалить некоторые жлементы и скоращения
                //главное, не убирать Id, так как он нужен для дальнейшей работы
                string[] item = { supplySet.Id.ToString() + ". ", "Риелтор: " + supplySet.AgentsSet.LastName, "Клиент: " + supplySet.ClientsSet.LastName };
                comboBoxSupply.Items.Add(string.Join(" ", item));
            }
        }
        void ShowDemand()
        {
            //очищаем comboBox
            comboBoxDemand.Items.Clear();
            foreach (DemandSet demandSet in Program.wftdb.DemandSet)
            {
                //Добавляем информацию, которую хотим видеть в строке comboBox-a
                //можно настроить по своему усмотрению, добавить/удалить некоторые жлементы и скоращения
                //главное, не убирать Id, так как он нужен для дальнейшей работы
                string[] item = { demandSet.Id.ToString() + ". ", "Риелтор: " + demandSet.AgentsSet.LastName, "Клиент: " + demandSet.ClientsSet.LastName };
                comboBoxDemand.Items.Add(string.Join(" ", item));
            }
        }

        private void comboBoxSupply_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deductions();
        }

        private void comboBoxDemand_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deductions();
        }
        void Deductions()
        {
            if (comboBoxSupply.SelectedItem !=null && comboBoxDemand.SelectedItem!=null)
            {
                //находим в базе предложение и потребность с выбранными номерами
                SupplySet supplySet = Program.wftdb.SupplySet.Find(Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]));
                DemandSet demandSet = Program.wftdb.DemandSet.Find(Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]));
                //рассчитываем отчисления компании для клиента-покупателя (3% от стоимости недвижимости), выводим в textCustomerCompanyDeductions
                double customerCompanyDeductions = supplySet.Price * 0.03;
                textCustomerCompanyDeductions.Text = customerCompanyDeductions.ToString("0.00");
                //рассчитываем отчисления риелтору для клиента-покупателя (комиссия указана в таблице AgentSet), выводим в textBoxAgentCustomerDeductions
                if (demandSet.AgentsSet.Share !=null)
                {
                    double agentCustomerDeductions = customerCompanyDeductions * Convert.ToDouble(demandSet.AgentsSet.Share) / 100.00;
                    textBoxAgentCustomerDeductions.Text = agentCustomerDeductions.ToString("0.00");
                }
                else
                {
                    //если комиссия не указана, то автоматически берется 45%
                    double agentCustomerDeductions = customerCompanyDeductions * 0.45;
                    textBoxAgentCustomerDeductions.Text = agentCustomerDeductions.ToString("0.00");
                }
            }
            else
            {
                textCustomerCompanyDeductions.Text = "";
                textBoxAgentCustomerDeductions.Text = "";
            }
            if (comboBoxSupply.SelectedItem !=null)
            {
                SupplySet supplySet = Program.wftdb.SupplySet.Find(Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]));
                double sellerCompanyDeductions;
                if(supplySet.RealEstateSet.Type == 0)
                {
                    sellerCompanyDeductions = 36000 + supplySet.Price * 0.01;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                //если продается дом
                else if (supplySet.RealEstateSet.Type ==1)
                {
                    sellerCompanyDeductions = 30000 + supplySet.Price * 0.01;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                //если продается земля
                else
                {
                    sellerCompanyDeductions = 30000 + supplySet.Price * 0.02;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                //рассчитываем отчисления риелтору для клиента-покупателя (комиссия указана в таблице AgentsSet)
                if (supplySet.AgentsSet.Share!=null)
                {
                    double agentSellerDeductions = sellerCompanyDeductions * Convert.ToDouble(supplySet.AgentsSet.Share) / 100.00;
                    textBoxAgentSellerDeductions.Text = agentSellerDeductions.ToString("0.00");
                }
                else
                {
                    //если комиссия не указана, то автоматически берется 45%
                    double agenSellerDeductions = sellerCompanyDeductions * 0.45;
                    textBoxAgentSellerDeductions.Text = agenSellerDeductions.ToString("0.00");
                }
            }
            else
            {
                textBoxSellerCompanyDeductions.Text = "";
                textBoxAgentSellerDeductions.Text = "";
                textCustomerCompanyDeductions.Text = "";
                textBoxAgentCustomerDeductions.Text = "";
            }
        }
        void ShowDealSet()
        {
            //предварительно очищаем все listView
            listViewDealSet.Items.Clear();
            //проходим по коллекции сделок, которые находятся в базе с помощью foreach
            foreach(DealSet deal in Program.wftdb.DealSet)
            {
                //создадим новый элемент в listview с помощью массива строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля (можно добавить имена, отчества, информацию про объект недвижимости и т.д.)
                    //фамилия клиента-продавца
                    deal.SupplySet.ClientsSet.LastName,
                    //Фамилия риелтора клиента-продавца
                    deal.SupplySet.AgentsSet.LastName,
                    //фамилия клиента-покупателя
                    deal.DemandSet.ClientsSet.LastName,
                    //фамилия риелтора клиента-покупателя
                    deal.DemandSet.AgentsSet.LastName,
                    //адрес объекта недвижимости
                    "г. "+ deal.SupplySet.RealEstateSet.Address_City+", ул. "+ deal.SupplySet.RealEstateSet.Address_Street+ ", д. "+
                    deal.SupplySet.RealEstateSet.Address_House+", кв. "+deal.SupplySet.RealEstateSet.Address_Number,
                    //стоимость
                    deal.SupplySet.Price.ToString()
                });
                //указываем по какому тегу выбраны элементы
                item.Tag = deal;
                //добавляем элементы в listViewRealEstateSet_Apartment для отображения
                listViewDealSet.Items.Add(item);
                listViewDealSet.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //проверяем, что все поля (раскрывшихся списков и текстового поля) были заполнены
            if (comboBoxDemand.SelectedItem != null && comboBoxSupply.SelectedItem != null)
            {
                //создаем новый экземпляр класса Сделка
                DealSet deal = new DealSet();
                //из выбранной строки отделяем Id предложения (он отделен точкой) и делаем ссылку
                deal.IdSupply = Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]);
                //из выбранной строки отделяем Id потребности (он отделен точкой) и делаем ссылку
                deal.IdDemand = Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]);
                //добавляем в таблицу Dealset новую сделку
                Program.wftdb.DealSet.Add(deal);
                //сохраняем изменения в модели wftdb
                Program.wftdb.SaveChanges();
                ShowDealSet();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //если в listView выбран элемент
            if (listViewDealSet.SelectedItems.Count==1)
            {
                //ищем элементы из таблицы по тегу
                DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                //указываем, что может быть изменено
                deal.IdSupply = Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]);
                deal.IdDemand = Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]);
                //сохраняем изменения в модели wftdb
                Program.wftdb.SaveChanges();
                ShowDealSet();
            }
        }

        private void listViewDealSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            //если в listView выбран элемент
            if (listViewDealSet.SelectedItems.Count ==1)
            {
                //ищем элемент из таблицы по тегу
                DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                comboBoxSupply.SelectedIndex = comboBoxSupply.FindString(deal.IdSupply.ToString());
                comboBoxDemand.SelectedIndex = comboBoxDemand.FindString(deal.IdDemand.ToString());
            }
            else
            {
                //если не выбран ни один элемент, задаем пустые элементы
                comboBoxSupply.SelectedItem = null;
                comboBoxDemand.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //пробуем совершить действие
            try
            {
                //если в listView выбран элемент
                if(listViewDealSet.SelectedItems.Count ==1)
                {
                    //ищем элемент из таблицы по тегу
                    DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                    //удаляем из модели базы данных
                    Program.wftdb.DealSet.Remove(deal);
                    //сохраняем изменения
                    Program.wftdb.SaveChanges();
                    
                }
                //очищаем все поля
                comboBoxSupply.SelectedItem = null;
                comboBoxDemand.SelectedItem = null;
            }
            //если возникает какая-то ошибка
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
