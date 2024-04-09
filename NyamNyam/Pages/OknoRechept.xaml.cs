using NyamNyam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NyamNyam.Pages
{
    /// <summary>
    /// Логика взаимодействия для OknoRechept.xaml
    /// </summary>
    public partial class OknoRechept : Page
    {
        Bludo contextBludo;
        public OknoRechept(Bludo bludo)
        {
            InitializeComponent();
            contextBludo = bludo;
            NameRec.Text = '"' + contextBludo.Name + '"';
            CategoryRec.Text = contextBludo.Category.Name;
            TimeSpan timeSpan = TimeSpan.Zero;
            foreach (var rec in bludo.Rechept.ToList())
            {
                timeSpan = timeSpan.Add(rec.Time.Value);
            }
            TimeRec.Text = timeSpan.ToString();
            TotalRec.Text = (contextBludo.Sum * contextBludo.BaseServings).ToString();
            TextRec.Text = contextBludo.Opisanie;
            LoadIngredients();
        }

        private void LoadIngredients()
        {
            var steps = contextBludo.Rechept.SelectMany(x => x.OneRechept);
            DataIngredients.ItemsSource = steps;
        }
    }
}
