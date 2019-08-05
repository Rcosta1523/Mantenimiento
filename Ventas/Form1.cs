﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.BL;

namespace Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var productoBL = new ProductosBL();
            listadeProductosBindingSource.DataSource = productoBL.ListadeProductos;

            var categoriasBL = new CategoriasBL();
            listadeCategoriasBindingSource.DataSource = categoriasBL.ListadeCategorias;
        }
    }
}
