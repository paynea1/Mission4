using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneProject
{
    // **************************************************
    //
    // Title: Capstone Project - Square foot of Walls Calculator
    // Description: Calculator for calculating the square footage of all walls in a house of up to 5 rooms.
    // Application Type: Window (WinForms)
    // Author: Payne, Austin
    // Dated Created: 4/23/2020
    // Last Modified: 4/26/2020
    //
    // **************************************************
    public partial class Form1 : Form
    {
        int numberOfRooms = 1;
        double area, height, width1, width2, width3, width4, width5, length1, length2, length3, length4, length5;

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panelFiveRooms_Paint(object sender, PaintEventArgs e)
        {
            height = double.Parse(textBox34.Text);
            width1 = double.Parse(textBox32.Text);
            length1 = double.Parse(textBox33.Text);
            width2 = double.Parse(textBox30.Text);
            length2 = double.Parse(textBox31.Text);
            width3 = double.Parse(textBox28.Text);
            length3 = double.Parse(textBox29.Text);
            width4 = double.Parse(textBox26.Text);
            length4 = double.Parse(textBox27.Text);
            width5 = double.Parse(textBox35.Text);
            length5 = double.Parse(textBox36.Text);
        }

        private void panelFourRooms_Paint(object sender, PaintEventArgs e)
        {
            height = double.Parse(textBox23.Text);
            width1 = double.Parse(textBox21.Text);
            length1 = double.Parse(textBox22.Text);
            width2 = double.Parse(textBox19.Text);
            length2 = double.Parse(textBox20.Text);
            width3 = double.Parse(textBox17.Text);
            length3 = double.Parse(textBox18.Text);
            width4 = double.Parse(textBox24.Text);
            length4 = double.Parse(textBox25.Text);
        }

        private void panelThreeRooms_Paint(object sender, PaintEventArgs e)
        {
            height = double.Parse(textBox14.Text);
            width1 = double.Parse(textBox12.Text);
            length1 = double.Parse(textBox13.Text);
            width2 = double.Parse(textBox10.Text);
            length2 = double.Parse(textBox11.Text);
            width3 = double.Parse(textBox15.Text);
            length3 = double.Parse(textBox16.Text);
           
        }

        private void panelTwoRooms_Paint(object sender, PaintEventArgs e)
        {
            height = double.Parse(textBox7.Text);
            width1 = double.Parse(textBox5.Text);
            length1 = double.Parse(textBox6.Text);
            width2 = double.Parse(textBox9.Text);
            length2 = double.Parse(textBox8.Text);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            area = (height * width1 * 2) + (height * length1 * 2) + (height * width2 * 2) + (height * length2 * 2);
            label15.Text = area.ToString() + " square feet";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            area = (height * width1 * 2) + (height * length1 * 2) + (height * width2 * 2) + (height * length2 * 2) + (height * width3 * 2) + (height * length3 * 2);

            label26.Text = area.ToString() + " square feet";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            area = (height * width1 * 2) + (height * length1 * 2) +
(height * width2 * 2) + (height * length2 * 2) +
(height * width3 * 2) + (height * length3 * 2) +
(height * width4 * 2) + (height * length4 * 2);

            label39.Text = area.ToString() + " square feet";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            area = (height * width1 * 2) + (height * length1 * 2) +
(height * width2 * 2) + (height * length2 * 2) +
(height * width3 * 2) + (height * length3 * 2) +
(height * width4 * 2) + (height * length4 * 2) +
(height * width5 * 2) + (height * length5 * 2);

            label54.Text = area.ToString() + " square feet";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            panelOneRoom.Visible = false;
            panelTwoRooms.Visible = false;
            panelThreeRooms.Visible = false;
            panelFourRooms.Visible = false;
            panelFiveRooms.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string input;
            input = textBox1.Text;
            numberOfRooms = int.Parse(input);

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (numberOfRooms == 1)
            {
                panel1.Visible = false;
                
                panelOneRoom.Visible = true;
                panelTwoRooms.Visible = false;
                panelThreeRooms.Visible = false;
                panelFourRooms.Visible = false;
                panelFiveRooms.Visible = false;
            }
            else if (numberOfRooms == 2)
            {
                panel1.Visible = false;
                panelOneRoom.Visible = false;
                panelTwoRooms.Visible = true;
                panelThreeRooms.Visible = false;
                panelFourRooms.Visible = false;
                panelFiveRooms.Visible = false;
            }
            else if (numberOfRooms == 3)
            {
                panel1.Visible = false;
                panelOneRoom.Visible = false;
                panelTwoRooms.Visible = false;
                panelThreeRooms.Visible = true;
                panelFourRooms.Visible = false;
                panelFiveRooms.Visible = false;
            }
            else if (numberOfRooms == 4)
            {
                panel1.Visible = false;
                panelOneRoom.Visible = false;
                panelTwoRooms.Visible = false;
                panelThreeRooms.Visible = false;
                panelFourRooms.Visible = true;
                panelFiveRooms.Visible = false;
            }
            else if (numberOfRooms == 5)
            {
                panel1.Visible = false;
                panelOneRoom.Visible = false;
                panelTwoRooms.Visible = false;
                panelThreeRooms.Visible = false;
                panelFourRooms.Visible = false;
                panelFiveRooms.Visible = true;
            }
            else
            {
                label12.Text = "That response is not allowed";
            } 
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1Room_Paint(object sender, PaintEventArgs e)
        {
            
            height = double.Parse(textBox2.Text);
            width1 = double.Parse(textBox3.Text);
            length1 = double.Parse(textBox4.Text);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            area = (height * width1 * 2) + (height * length1 * 2);
            label9.Text = area.ToString() + " square feet";
        }
    }
}
