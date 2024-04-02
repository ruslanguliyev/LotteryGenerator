using Business;
using DataAccess.Migrations;
using Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TestWF
{
    public partial class Form2 : Form
    {
        TicketManager _ticketmanager = new();
        public Form2()
        {
            InitializeComponent();
            //DGVTicket.DoubleClick += DGVTicket_DoubleClick;

        }



        public void FillDGV()
        {
            var allTicket = _ticketmanager.GetAllTicket()
                .Select(allTicket => new
                {
                    ID = allTicket.Id,
                    Number = allTicket.Number,
                    IsDeleted = allTicket.IsDeleted,

                }).ToList();

            DGVTicket.DataSource = allTicket;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var Number = txtNumber.Text;
            if (string.IsNullOrWhiteSpace(Number))
            {
                MessageBox.Show("Boşluqları doldurun");
            }
            else
            {
                Ticket ticket = new()
                {
                    Number = Number,
                };
                _ticketmanager.AddTicket(ticket);
                txtNumber.Text = " ";
                MessageBox.Show("Kupon əlavə olundu");
                FillDGV();
            }
        }
        

        

        private void btnGen_Click(object sender, EventArgs e)
        {
            List<Ticket> existingTickets = _ticketmanager.GetAllTicketNumber("");

            Random random = new Random();

            string newTicketNumber;
            do
            {
                
                string baseNumber = existingTickets.Any() ? existingTickets[random.Next(existingTickets.Count)].Number : "";
                int randomNumber = random.Next(100000000);
                newTicketNumber = baseNumber + randomNumber.ToString();
            } while (existingTickets.Any(ticket => ticket.Number == newTicketNumber)); 

            MessageBox.Show(newTicketNumber);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            int ticketNumber = Convert.ToInt32(txt_Id.Text);

            if (!int.TryParse(txt_Id.Text, out ticketNumber))
            {
                MessageBox.Show("Заполните поля");
               
            }
            else
            {
                _ticketmanager.DeleteTicket(ticketNumber);
                MessageBox.Show("Билет успешно удален.");
                FillDGV();
            }



        }


    }

}
