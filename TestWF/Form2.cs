using Business;
using Entities;
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

namespace TestWF
{
    public partial class Form2 : Form
    {
        TicketManager _ticketmanager = new();
        public Form2()
        {
            InitializeComponent();
        }

        public void FillDGV()
        {
            var allTicket = _ticketmanager.GetAllTicket()
                .Select(allTicket => new
                {
                    ID = allTicket.Id,
                    Number = allTicket.Number,

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




    }

}
