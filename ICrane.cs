using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Timers;
using iCrane.Siniflar.VeriTabani;

namespace iCrane
{
    public partial class ICrane : Form
    {

        /*
         * pcb dizi boyutu ayarlanacak
         * sayfa açıldığında datagridSA dolu ise silme işlemi dene
         */

        int i,j,y;
        string bekleyenGenislik, bekleyenCap, bekleyenRuloKodu;
        bool secildiMi = false;
        bool yerlestiMi = false;        
        int sayac = 0;
        int tagSayac = 0;
        int kontrol = 0;

        CoilSAVeriTabani coilSAVT = new CoilSAVeriTabani();
        CoilVeriTabani coilVT = new CoilVeriTabani();

        public PictureBox[] pcb = new PictureBox[16];
        
        public ICrane()
        {
            InitializeComponent();
        }
        private void ICrane_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            gridFillSA();
            gridFillBekleyen();
            checkboxFalse();
            defaultCoilGetir();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public void gridFillSA()//dataGridSA doldurulmasını sağlıyor
        {
            dataGridSA.DataSource = coilSAVT.CoilSAGetir();
            dataGridSA.Columns[2].Visible = false;
            dataGridSA.Columns[3].Visible = false;
            dataGridSA.Columns[4].Visible = false;
            dataGridSA.Columns[5].Visible = false;
            dataGridSA.Columns[6].Visible = false;
        }
        public void gridFillBekleyen()
        {
            dataGridBekleyen.DataSource = coilVT.CoilGetir();
        }        
        private void defaultCoilGetir()
        {
            int genislik = 0;
            int cap = 0;
            int koordinatX = 0;
            int koordinatY = 0 ;
            string saKod="";

            int satir = dataGridSA.Rows.Count;

            if (satir > 1)
            {
                for (int i = 0; i < dataGridSA.Rows.Count - 1; i++)
                {
                    foreach (Control itemPicture in Controls)
                    {
                        if (itemPicture is PictureBox)
                        {
                            if (dataGridSA.Rows[i].Cells[1].Value.ToString() == itemPicture.Tag.ToString())
                            {
                                 genislik = Convert.ToInt32(dataGridSA.Rows[i].Cells[2].Value.ToString());
                                 cap = Convert.ToInt32(dataGridSA.Rows[i].Cells[3].Value.ToString());
                                 koordinatX = Convert.ToInt32(dataGridSA.Rows[i].Cells[4].Value.ToString());
                                 koordinatY = Convert.ToInt32(dataGridSA.Rows[i].Cells[5].Value.ToString());
                                 saKod = dataGridSA.Rows[i].Cells[1].Value.ToString();

                                foreach (Control itemCheck in Controls)
                                {
                                    if (itemCheck is CheckBox)
                                    {
                                        if (dataGridSA.Rows[i].Cells[1].Value.ToString() == itemCheck.Tag.ToString())
                                        {
                                            kontrol++;
                                            CheckBox chck = (CheckBox)itemCheck;//açık tür dönüşümü
                                            chck.Checked = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    coilGetir(cap, genislik, koordinatX, koordinatY, saKod);
                }

                
            }
        }
        private void checkboxFalse()
        {
            a1.Checked = false;
            a2.Checked = false;
            a3.Checked = false;
            a4.Checked = false;

            b1.Checked = false;
            b2.Checked = false;
            b3.Checked = false;
            b4.Checked = false;

            c1.Checked = false;
            c2.Checked = false;
            c3.Checked = false;
            c4.Checked = false;
            c5.Checked = false;
            c6.Checked = false;
            b5.Checked = false;
            b6.Checked = false;
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      
        private void btnYerlestir_Click(object sender, EventArgs e)
        {           
            coilTimer.Start();
            timer1.Start();
            groupBox1.Visible = true;
        }
        private void coilTimer_Tick(object sender, EventArgs e)
        {
            
            if (j > 1199)
            {
                if (a1.Checked == false)
                {
                    groupTasima(pcba1, a1);

                }
                else if (a2.Checked == false)
                {
                    groupTasima(pcba2, a2);

                }
                else if (a3.Checked == false)
                {
                    groupTasima(pcba3, a3);

                }
                else if (a4.Checked == false)
                {
                    groupTasima(pcba4, a4);

                }
                else
                {
                    coilTimer.Stop();
                    MessageBox.Show("Bu büyüklükteki depolama alanı doludur");
                    
                }

            }
            if(j >=800 && j <=900)
            {
                if (b1.Checked == false)
                {
                    groupTasima(pcbb1, b1);

                }
                else if (b2.Checked == false)
                {
                    groupTasima(pcbb2, b2);

                }
                else if (b3.Checked == false)
                {
                    groupTasima(pcbb3, b3);

                }
                else if (b4.Checked == false)
                {
                    groupTasima(pcbb4, b4);

                }
                else if (b5.Checked == false)
                {
                    groupTasima(pcbb5, b5);

                }
                else if (b6.Checked == false)
                {
                    groupTasima(pcbb6, b6);

                }
                else
                {
                    coilTimer.Stop();

                    MessageBox.Show("Bu Büyüklükte Depolama Alanı Yok");
                }
            }
            if (j <800)
            
            {
                
                if (c1.Checked == false)
                {
                    groupTasima(pcbc1, c1);

                }
                else if(c2.Checked == false)
                {
                    groupTasima(pcbc2, c2);

                }
                else if(c3.Checked == false)
                {
                    groupTasima(pcbc3, c3);

                }
                else if(c4.Checked == false)
                {
                    groupTasima(pcbc4, c4);

                }
                else if(c5.Checked == false)
                {
                    groupTasima(pcbc5, c5);

                }
                else if(c6.Checked == false)
                {
                    groupTasima(pcbc6, c6);

                }
                else
                {
                    coilTimer.Stop();
                    MessageBox.Show("Bu Büyüklükte Depolama Alanı Yok");
                }
            }         
        }
        private void groupTasima(PictureBox pctr, CheckBox check)
        {
            dataGridBekleyen.Enabled = false;

            pcb[y].BringToFront();
            if (pcb[y].Location.X+pcb[y].Width/2< pctr.Location.X+pctr.Width/2)
            {
                pcb[y].Left = pcb[y].Left + 1;
            }
            if (pcb[y].Location.X + pcb[y].Width / 2 > pctr.Location.X+ pctr.Width / 2)
            {
                pcb[y].Left = pcb[y].Left - 1;
            }
            if (pcb[y].Location.Y + pcb[y].Height / 2 < pctr.Location.Y+ pctr.Height / 2)
            {
                pcb[y].Top = pcb[y].Top + 1;
            }
            if (pcb[y].Location.Y + pcb[y].Height / 2 > pctr.Location.Y + pctr.Height / 2)
            {
                pcb[y].Top = pcb[y].Top - 1;
            }

            if (pcb[y].Location.Y + pcb[y].Height / 2 == pctr.Location.Y + pctr.Height / 2 && pcb[y].Location.X + pcb[y].Width / 2 == pctr.Location.X + pctr.Width / 2)
            {
                coilTimer.Stop();
                check.Checked = true;
                yerlestiMi = true;
                dataGridVeriAktar(pctr);

                pcb[y].Tag = pctr.Tag;

                string ruloKodu = dataGridBekleyen.SelectedRows[0].Cells[0].Value.ToString();
                coilSAVT.SAKodGuncelle(ruloKodu, pctr);
                coilVT.CoilSil(bekleyenRuloKodu);

                gridFillBekleyen();
                gridFillSA();
                dataGridBekleyen.Enabled = true;
                groupBox1.Visible = false;
            }
        }
        private void dataGridVeriAktar(PictureBox pctr)
        {
            int selectedIndex = dataGridBekleyen.CurrentCell.RowIndex;
            bekleyenRuloKodu = dataGridBekleyen.CurrentRow.Cells[0].Value.ToString();
            bekleyenGenislik = dataGridBekleyen.CurrentRow.Cells[1].Value.ToString();
            bekleyenCap = dataGridBekleyen.CurrentRow.Cells[2].Value.ToString();

            coilSAVT.CoilSAEkle(bekleyenRuloKodu, bekleyenGenislik, bekleyenCap, pcb[y]);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Visible == true)
            {
                label1.Visible = false;
            }
            else
                label1.Visible = true;
        }

        private void dataGridBekleyen_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secildiMi = true;
            
            sayac++;

            if (sayac<= 1)
            {
                coilGetir();
            }
            if (sayac > 1 && yerlestiMi==true)
            {
                coilGetir();
            }
            if (sayac > 1 && yerlestiMi == false)
            {
                pcb[y].Dispose();
                coilGetir();
            }
        }
        private void coilGetir()
        {
            j = Convert.ToInt32(dataGridBekleyen.SelectedRows[0].Cells[1].Value);//genişlik
            i = Convert.ToInt32(dataGridBekleyen.SelectedRows[0].Cells[2].Value);//çap

            y++;
            pcb[y] = new PictureBox();
            pcb[y].ImageLocation = "./Images/palet.png";

            pcb[y].SizeMode = PictureBoxSizeMode.StretchImage;
            pcb[y].Name = "pcb" + y.ToString();       
            pcb[y].SetBounds(36, 500, (i) * 1 / 5, (j) * 1 / 5);
            this.Controls.Add(pcb[y]);
            pcb[y].BackColor = Color.Black;
            yerlestiMi = false;            
        }
        private void coilGetir(int i, int j, int koordinatX, int koordinatY, string saKod)//polymorphism kullanıldı
        {
            //i=çap
            //j=genişlik

            y++;
            tagSayac++;
            pcb[y] = new PictureBox();
            //pcb[y].ImageLocation = "C:/Users/PC336/Downloads/soniCrane/iCrane/palet.png";
            pcb[y].ImageLocation = "./Images/palet.png";
            pcb[y].SizeMode = PictureBoxSizeMode.StretchImage;
            pcb[y].Name = "pcb" + y.ToString();
            pcb[y].Tag = saKod;
            pcb[y].SetBounds(koordinatX , koordinatY , (i) * 1 / 5, (j) * 1 / 5);
            this.Controls.Add(pcb[y]);
            pcb[y].BackColor = Color.Black;
            pcb[y].BringToFront();

        }    
        private void btnStoktanCikar_Click(object sender, EventArgs e)
        {
            string stokRuloKodu = dataGridSA.CurrentRow.Cells[0].Value.ToString();
            string stokSAKodu = dataGridSA.CurrentRow.Cells[1].Value.ToString();
            string stokGenislik = dataGridSA.CurrentRow.Cells[2].Value.ToString();
            string stokCap = dataGridSA.CurrentRow.Cells[3].Value.ToString();
            string pcrName = dataGridSA.CurrentRow.Cells[6].Value.ToString();

            foreach (Control itemPicture in Controls)
            {
                if (itemPicture is PictureBox)
                {
                    if (stokSAKodu == itemPicture.Tag.ToString())
                    {
                        foreach (Control itemCheck in Controls)
                        {
                            if (itemCheck is CheckBox)
                            {
                                CheckBox chck = (CheckBox)itemCheck;

                                if (stokSAKodu == itemCheck.Tag.ToString() && chck.Checked == true)
                                {
                                    int index = Convert.ToInt32(itemPicture.Name.Substring(3));//pcb sonrası 3.index dahil  
                                    pcb[index].Dispose();
                                    chck.Checked = false;
                                }
                            }
                        }
                    }
                }
            }

            coilVT.CoilEkle(stokRuloKodu, stokGenislik, stokCap);
            coilSAVT.CoilSASil(stokRuloKodu);

            gridFillSA();
            gridFillBekleyen();
        }
    }
}
