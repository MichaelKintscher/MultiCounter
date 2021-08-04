using MultiCounter.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MultiCounter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        /// <summary>
        /// The collection of variable counts to display buttons for.
        /// </summary>
        ObservableCollection<VariableCount> VariableCounts { get; set; }
        public MainPage()
        {
            this.InitializeComponent();

            this.VariableCounts = new ObservableCollection<VariableCount>()
            {
                new VariableCount("P1 Gestures"),
                new VariableCount("P1 Utterances"),
                new VariableCount("P2 Gestures"),
                new VariableCount("P2 Utterances")
            };
        }

        /// <summary>
        /// Handles when a button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                // Get a reference to the count and increas it by 1.
                VariableCount count = this.VariableCounts.Where(c => c.Name == button.Tag.ToString()).FirstOrDefault();
                count.Count++;
            }
        }

        private void Template1Button_Click(object sender, RoutedEventArgs e)
        {
            this.VariableCounts.Clear();
            this.VariableCounts.Add(new VariableCount("P1 Gestures"));
            this.VariableCounts.Add(new VariableCount("P1 Utterances"));
            this.VariableCounts.Add(new VariableCount("P2 Gestures"));
            this.VariableCounts.Add(new VariableCount("P2 Utterances"));
        }

        private void Template2Button_Click(object sender, RoutedEventArgs e)
        {
            this.VariableCounts.Clear();
            this.VariableCounts.Add(new VariableCount("N/A"));
            this.VariableCounts.Add(new VariableCount("Look Together"));
            this.VariableCounts.Add(new VariableCount("Convo Grounding"));
            this.VariableCounts.Add(new VariableCount("Look Across"));
        }
    }
}
