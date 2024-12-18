﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilates.Views
{
    public partial class CadastroPAI : Form
    {
        public bool Ativo = true;
        public int Alterar = -7;
        public CadastroPAI()
        {
            InitializeComponent();
        }
        public virtual void Salvar() { }
        public virtual void Bloqueia() { }
        public virtual void Desbloqueia() { }
        public virtual void Carrega() { }
        public virtual void LimparCampos() { }

        private void rbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            Ativo = rbAtivo.Checked;
        }

        private void rbInativo_CheckedChanged(object sender, EventArgs e)
        {
            Ativo = !rbInativo.Checked;
        }

        private void CadastroPAI_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Texts))
            {
                txtCodigo.Texts = "0";
            }
            if (Alterar == -7)
            {
                txtDataCadastro.Texts = DateTime.Now.ToString();
                txtDataUltAlt.Texts = DateTime.Now.ToString();
                rbAtivo.Enabled = false;
                rbInativo.Enabled = false;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
