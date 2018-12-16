///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject5/DataStructuresProject5
//	File Name:         QuizResultsWindow.cs
//	Description:       Shows the results of the matching game as well as a goodbye message
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Dakota Cowell, cowelld@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Wednesday, November 28, 2018
//	Copyright:         Dakota Cowell, 2018
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2210_002_CowellDakota_DataStructuresProject5
{
    /// <summary>
    /// Class to manage the results from the matching game
    /// Displays a goodbye message and the results as a percentage
    /// </summary>
    public partial class QuizResultsWindow : Form
    {
        public int attempts;
        public int correct;

        /// <summary>
        /// Default Constructor - Initializes the components
        /// </summary>
        public QuizResultsWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to calculate the percentage of correct answers and update the label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuizResultsWindow_Load(object sender, EventArgs e)
        {
            //If they had more than 1 try, display the percentage they got correct
            if(attempts > 0)
            {
                int percentCorrect = (int)(correct / (double)attempts * 100);
                resultsLabel.Text = $"Your score was {percentCorrect}% on {attempts} attempts";
            }
        }

        /// <summary>
        /// Closes the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okayButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
