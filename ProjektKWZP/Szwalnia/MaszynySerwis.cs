﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class MaszynySerwis : Form
    {
        public MaszynySerwis(SzwalniaEntities db)
        {
            InitializeComponent();
            dgvMaszynySerwis.DataSource = db.vMaszyny_serwis.ToList();
        }
    }
}
