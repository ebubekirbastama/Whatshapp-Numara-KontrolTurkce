using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;


namespace Paylaşım_Botu_Tarayıcı_Entegre
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        string dgrkntrolll = "devam et";
        string aranandgr = "Ara veya yeni sohbet başlat";
        string gecersiznmr = "URL yoluyla paylaşılan telefon numarası geçersizdir.";
        IWebDriver drv = new ChromeDriver();
        string url = @"https://web.whatsapp.com/send?phone=";
        StreamReader sr; int sycc = 0; int sycci = 0; int atilan = 1;
        int sycaai = 0;
        int sycaa = 0;
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            try
            {
                drv.Navigate().GoToUrl("https://web.whatsapp.com");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch (Exception ex)
            {
            }
        }
        int saat = 0, dakika = 0, saniye = 0;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
          
        }
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        string snyy = DateTime.Now.Second.ToString(); 
        string dakaka = DateTime.Now.Minute.ToString(); // sadece dakika
        string saatt = DateTime.Now.Hour.ToString(); // sadece saat
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        string mesajj = ""; int syyyyy=0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    backgroundWorker3.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ebubekir Bastama");
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
               
                    using (sr = File.OpenText(openFileDialog1.FileName))
                    {
                        string telefon = sr.ReadLine();
                        while (telefon != null)
                        {
                        //sycc++;
                        listBox1.Items.Add("90" + telefon);
                         label7.Text = listBox1.Items.Count.ToString();
                         telefon = sr.ReadLine();
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            backgroundWorker4.RunWorkerAsync();
        }
        ArrayList sktnnmr = new ArrayList();
        ArrayList nrmlnnmr = new ArrayList();
        int s1 = 1;
        int s2 = 1;
        string kontrolmesaj;
        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
           

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
         
                drv.Navigate().GoToUrl(url + listBox1.Items[i].ToString());
                
            gitii: gt: if (drv.PageSource.IndexOf("_3h3LX _34ybp app-wrapper-web font-fix os-win") != -1)
                {
                    try
                    {
                        Thread.Sleep(5000);
                        var ddd = drv.FindElement(By.ClassName("_3NCh_")).Text;
                        kontrolmesaj = "";
                    }
                    catch (NoSuchElementException ex)
                    {
                        kontrolmesaj = ex.Message;
                    }
                    if (kontrolmesaj.IndexOf("no such element") == -1)
                    {
                      
                        try
                        {
                            drv.FindElement(By.XPath("//div[@class='_3NCXc _1Yw2u _FUG3 _2HGw4']")).Click();
                        }
                        catch
                        {
                            goto gitii;
                        }
                        sktnnmr.Add(listBox1.Items[i].ToString());
                        label9.Text = s2.ToString();
                        s2++;
                    }
                    else
                    {
                        nmraktr(listBox1.Items[i].ToString());
                        nrmlnnmr.Add(listBox1.Items[i].ToString());
                        label4.Text = s1.ToString();
                        s1++;
                    }
                    #region eski kod
                    //fgg: fg: var syfyklndm = drv.PageSource.ToString();
                    //    //Thread.Sleep(2000);
                    //    if (syfyklndm.Length != Class1.asd)
                    //    {
                    //        if (syfyklndm.Length != 4644)
                    //        {
                    //            var si = drv.PageSource.ToString();
                    //            int gcrnmrvrm = si.IndexOf(gecersiznmr);
                    //            label2.Text = i.ToString();
                    //            if (gcrnmrvrm == -1)
                    //            {

                    //                var sii = drv.PageSource.ToString();
                    //                int gcrnmrvrmi = sii.IndexOf(gecersiznmr);
                    //                if (gcrnmrvrmi == -1)
                    //                {
                    //                    nmraktr(listBox1.Items[i].ToString());
                    //                    nrmlnnmr.Add(listBox1.Items[i].ToString());
                    //                    label4.Text = s1.ToString();
                    //                    s1++;
                    //                    //drv.FindElements(By.XPath("//div[@class='_25Ooe']//span[@title='+90 555 412 88 54'][contains(text(),'+90 555 412 88 54')]"))[0].Click();//bizimkine geri geliyoruz.
                    //                    //Thread.Sleep(2000);
                    //                }
                    //                else//_1dwBj _3xWLK
                    //                {
                    //                    drv.FindElement(By.XPath("//div[@class='_3NCXc _1Yw2u _FUG3 _2HGw4']")).Click();
                    //                    Thread.Sleep(1000);

                    //                    sktnnmr.Add(listBox1.Items[i].ToString());
                    //                    label9.Text = s2.ToString();
                    //                    s2++;
                    //                dbi: var sib = drv.PageSource.ToString();
                    //                    int gcrnmrvrmb = sib.IndexOf(gecersiznmr);
                    //                    if (gcrnmrvrmb != -1)
                    //                    {
                    //                        goto dbi;
                    //                    }
                    //                }

                    //            }
                    //            else
                    //            {
                    //                drv.FindElement(By.XPath("//div[@class='_3NCXc _1Yw2u _FUG3 _2HGw4']")).Click();
                    //                //Thread.Sleep(1000);
                    //                //drv.FindElements(By.XPath("//div[@class='_25Ooe']//span[@title='+90 555 412 88 54'][contains(text(),'+90 555 412 88 54')]"))[0].Click();//bizimkine geri geliyoruz.
                    //                sktnnmr.Add(listBox1.Items[i].ToString());
                    //                label9.Text = s2.ToString();
                    //                s2++;
                    //                dbi: var sib = drv.PageSource.ToString();
                    //                int gcrnmrvrmb = sib.IndexOf(gecersiznmr);
                    //                if (gcrnmrvrmb != -1)
                    //                {
                    //                    goto dbi;
                    //                }
                    //            }
                    //        }
                    //        else
                    //        {
                    //            goto fgg;
                    //        }
                    //    }
                    //    else
                    //    {
                    //        goto fg;
                    //    }
                    #endregion
                }
                else
                {
                    goto gt;
                }
                //Thread.Sleep(5000);

            }
            listBox1.Items.Clear();
            for (int i = 0; i < nrmlnnmr.Count; i++)
            {
                listBox1.Items.Add(nrmlnnmr[i].ToString());    
            }
            label7.Text = listBox1.Items.Count.ToString();
            MessageBox.Show("Tüm Numaralar Kontrol Edildi ve temizlendi.", "Eçk Yazılım");
            nrmlnnmr.Clear();sktnnmr.Clear();
        }
        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            drv.Quit();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
           // backgroundWorker6.RunWorkerAsync();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
        {
            string dosya_yolu = Application.StartupPath + @"\" + "temiznumara.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(dosya_yolu, true);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sw.WriteLine(listBox1.Items[i].ToString());
            }
            sw.Flush();
            sw.Close();
            fs.Close();
            listBox1.Items.Clear();
        }
        public void nmraktr(string nmr)
        {
            string dosya_yolu = Application.StartupPath + @"\" + "temiznumara.txt";
           // FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(dosya_yolu,true);
            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    sw.WriteLine(listBox1.Items[i].ToString());
            //}
            sw.WriteLine(nmr);
            sw.Flush();
            sw.Close();
            //fs.Close();
            //listBox1.Items.Clear();
        }
    }
}