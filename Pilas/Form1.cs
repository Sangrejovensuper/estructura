﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas {
    public partial class Form1: Form {

        Pila p = new Pila();
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender,EventArgs e) 
        {
            p.push(textBox1.Text);
            listBox1.Items.Clear();
            p.mostrar(listBox1);
        }

        private void button2_Click(object sender,EventArgs e) 
        {
            string nom = p.Pop();
            if (nom!=null) {
                MessageBox.Show("desapilado: "+ nom);
                listBox1.Items.Clear();
                p.mostrar(listBox1);
            }
            
        }

        private void button3_Click(object sender,EventArgs e) 
        {
            MessageBox.Show("Cima: " + p.Peek()); 
        }

        private void button5_Click(object sender,EventArgs e) 
        {

        }

        private void button4_Click(object sender,EventArgs e) 
        {
            MessageBox.Show("# Elementos: "+p.contar());
        }
    }
}
