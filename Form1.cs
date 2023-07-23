using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marmaray_Duraklar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox3.Items.Add("GEBZE");
            comboBox3.Items.Add("HALKALI");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "GEBZE")
            {
                if (comboBox2.Text == "GEBZE")
                {

                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "DARICA")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                }
                if (comboBox2.Text == "OSMANGAZİ")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                }
                if (comboBox2.Text == "GEBZE TEK. UNİ.")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                }
                if (comboBox2.Text == "ÇAYIROVA")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                }
                if (comboBox2.Text == "TUZLA")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                }

                if (comboBox2.Text == "İÇMELER")
                {
                    comboBox1.Items.Clear();
                    label4.Text = "You can change the metro-line M4";
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                }

                if (comboBox2.Text == "AYDINTEPE")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                }
                if (comboBox2.Text == "GÜZELYALI")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");

                }
                if (comboBox2.Text == "TERSANE")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                }
                if (comboBox2.Text == "KAYNARCA")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                }
                if (comboBox2.Text == "PENDİK")
                {


                    comboBox1.Items.Clear();
                    label4.Text = "You can change the metro-line M10";
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                }
                if (comboBox2.Text == "YUNUS")
                {

                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                }
                if (comboBox2.Text == "KARTAL")
                {

                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                }
                if (comboBox2.Text == "BAŞAK")
                {

                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                }
                if (comboBox2.Text == "ATALAR")
                {

                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                }
                if (comboBox2.Text == "CEVİZLİ")
                {

                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                }
                if (comboBox2.Text == "MALTEPE")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                }
                if (comboBox2.Text == "SÜREYYAPLAJI")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                }
                if (comboBox2.Text == "İDEALTEPE")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");

                }
                if (comboBox2.Text == "KÜÇÜKYALI")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                }
                if (comboBox2.Text == "BOSTANCI")
                {
                    comboBox1.Items.Clear();
                    label4.Text = "You can change the high speed train,M8 and feribot";
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                }
                if (comboBox2.Text == "SUADİYE")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                }
                if (comboBox2.Text == "ERENKÖY")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                }
                if (comboBox2.Text == "GÖZTEPE")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("GÖZTEPE");
                }
                if (comboBox2.Text == "FENERYOLU")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                }
                if (comboBox2.Text == "SÖĞÜTLÜÇEŞME")
                {
                    comboBox1.Items.Clear();
                    label4.Text = "You can change the high speed train and feribot";
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                }
                if (comboBox2.Text == "AYRILIK ÇEŞMESİ")
                {
                    comboBox1.Items.Clear();
                    label4.Text = "You can change the metro-line M4";
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                }
                if (comboBox2.Text == "ÜSKÜDAR")
                {
                    comboBox1.Items.Clear();
                    label4.Text = "You can change the metro-line M5 and feribot";
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                }
                if (comboBox2.Text == "SİRKECİ")
                {
                    comboBox1.Items.Clear();
                    label4.Text = "You can change the T1 and feribot";
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                }
                if (comboBox2.Text == "YENİKAPI")
                {
                    comboBox1.Items.Clear();
                    label4.Text = "You can change the metro-line M1, M2 and feribot";
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                }
                if (comboBox2.Text == "KAZLIÇEŞME")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLOTRYA");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                }
                if (comboBox2.Text == "ZEYTİNBURNU")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                }

                if (comboBox2.Text == "YENİMAHALLE")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                }
                if (comboBox2.Text == "BAKIRKÖY")
                {
                    comboBox1.Items.Clear();
                    label4.Text = "You can change the high speed train and M3";
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                }
                if (comboBox2.Text == "ATAKÖY")
                {
                    comboBox1.Items.Clear();
                    label4.Text = "You can change the metro-line M9";
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                }
                if (comboBox2.Text == "YEŞİLYURT")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                }
                if (comboBox2.Text == "YEŞİLKÖY")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                }
                if (comboBox2.Text == "FLORYA AKVARYUM")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                }
                if (comboBox2.Text == "FLORYA")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                }
                if (comboBox2.Text == "KÜÇÜKÇEKMECE")
                {
                    comboBox1.Items.Clear();
                    label4.Text = "You can change the metrobus";
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                }
                if (comboBox2.Text == "MUSTAFA KEMAL")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                }

            }
            if (comboBox3.Text == "HALKALI")
            {
                if (comboBox2.Text == "HALKALI")
                {


                    comboBox1.Items.Clear();
                    label4.Text = "You can change the metro-line M1B and high sspeed train";
                    comboBox1.Items.Add("HALKALI");
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "MUSTAFA KEMAL")
                {


                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("MUSTAFA KEMAL");
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "KÜÇÜKÇEKMECE")
                {


                    comboBox1.Items.Clear();
                    label4.Text = "You can change the metrobus in this station";
                    comboBox1.Items.Add("KÜÇÜKÇEKMECE");
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "FLORYA")
                {


                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("FLORYA");
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "FLORYA AKVARYUM")
                {


                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("FLORYA AKVARYUM");
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");

                }
                if (comboBox2.Text == "YEŞİLKÖY")
                {


                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("YEŞİLKÖY");
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "YEŞİLYURT")
                {


                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("YEŞİLYURT");
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "ATAKÖY")
                {


                    comboBox1.Items.Clear();
                    label4.Text = "You can change the metro-line M9";
                    comboBox1.Items.Add("ATAKÖY");
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "BAKIRKÖY")
                {
                    comboBox1.Items.Clear();
                    label4.Text = "You can change the high speed train and M3";
                    comboBox1.Items.Add("BAKIRKÖY");
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "YENİMAHALLE")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("YENİMAHALLE");
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "ZEYTİNBURNU")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("ZEYTİNBURNU");
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "KAZLIÇEŞME")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("KAZLIÇEŞME");
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "YENİKAPI")
                {
                    comboBox1.Items.Clear();
                    label4.Text = "You can change the metro-line M1,M2 and feribot";
                    comboBox1.Items.Add("YENİKAPI");
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "SİRKECİ")
                {
                    comboBox1.Items.Clear();
                    label4.Text = "You can change the metro-line T1 and feribot";
                    comboBox1.Items.Add("SİRKECİ");
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "ÜSKÜDAR")
                {
                    comboBox1.Items.Clear();
                    label4.Text = "You can change the metro-line M5 and feribot";
                    comboBox1.Items.Add("ÜSKÜDAR");
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "AYRILIK ÇEŞMESİ")
                {
                    comboBox1.Items.Clear();
                    label4.Text = "You can change the metro-line M4";
                    comboBox1.Items.Add("AYRILIK ÇEŞMESİ");
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "SÖĞÜTLÜÇEŞME")
                {
                    comboBox1.Items.Clear();
                    label4.Text = "You can change the high speed train and feribot";
                    comboBox1.Items.Add("SÖĞÜTLÜÇEŞME");
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "FENERYOLU")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("FENERYOLU");
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "GÖZTEPE")
                {
                    comboBox1.Items.Clear();
                    label4.Text = "You can change the metro-line M12";
                    comboBox1.Items.Add("GÖZTEPE");
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "ERENKÖY")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("ERENKÖY");
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "SUADİYE")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("SUADİYE");
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "BOSTANCI")
                {
                    comboBox1.Items.Clear();
                    label4.Text = "You can change the metro-line M8,feribot and metrobus";
                    comboBox1.Items.Add("BOSTANCI");
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "KÜÇÜKYALI")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("KÜÇÜKYALI");
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "İDEALTEPE")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("İDEALTEPE");
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "SÜREYYAPLAJI")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("SÜREYYAPLAJI");
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "MALTEPE")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("MALTEPE");
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "CEVİZLİ")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("CEVİZLİ");
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "ATALAR")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("ATALAR");
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "BAŞAK")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("BAŞAK");
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "KARTAL")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("KARTAL");
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "YUNUS")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("YUNUS");
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "PENDİK")
                {
                    label4.Text = "You can change the high speed train and feribot";
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("PENDİK");
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "KAYNARCA")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("KAYNARCA");
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "TERSANE")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("TERSANE");
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "GÜZELYALI")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("GÜZELYALI");
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "AYDINTEPE")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("AYDINTEPE");
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "İÇMELER")
                {
                    comboBox1.Items.Clear();
                    label4.Text = "You can change the metro-line M4";
                    comboBox1.Items.Add("İÇMELER");
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "TUZLA")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("TUZLA");
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "ÇAYIROVA")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("ÇAYIROVA");
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "GEBZE TEK.UNİ.")
                {

                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("GEBZE TEK. UNİ.");
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "OSMANGAZİ")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("OSMANGAZİ");
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
                if (comboBox2.Text == "DARICA")
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("DARICA");
                    comboBox1.Items.Add("GEBZE");
                }
            }
        }
    }
    }

