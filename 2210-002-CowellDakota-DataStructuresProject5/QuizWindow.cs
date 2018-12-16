///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  DataStructuresProject5/DataStructuresProject5
//	File Name:         QuizWindow.cs
//	Description:       Main Window for this application - Allows the user to interact with the form to play the matching game
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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2210_002_CowellDakota_DataStructuresProject5
{
    /// <summary>
    /// Partial class to manage the quiz window
    /// Keeps track of the number of attempts and correct answers
    /// Reads all states from the states.txt file and images of each from the State Pictures folder
    /// Uses a SortedDictionary to keep track of the states and their capitals
    /// </summary>
    public partial class QuizWindow : Form
    {
        Random rand = new Random();
        private int attempts = 0;
        private int correct = 0;
        private SortedDictionary<string, string> states = new SortedDictionary<string, string>();
        private int timeRemaining = 20;//How many seconds left for the question - starts at 20 seconds
        private string[] images = new string[50];

        /// <summary>
        /// Default Constructor - Initializes Components
        /// </summary>
        public QuizWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Reset the timer and show a new state for the user to select the capital of
        /// If the user hasn't finished their turn, display an error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            if (!capitalsListBox.Enabled)
            {
                userFeedbackLabel.Visible = false;
                timeRemaining = 20;
                UpdateLabels();
                EnableControls();
                ShowRandomState();
            } else
            {
                userFeedbackLabel.Text = "You have not selected an answer";
                userFeedbackLabel.ForeColor = System.Drawing.Color.Red;
                userFeedbackLabel.Visible = true;
            }
        }

        /// <summary>
        /// Close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// When the form loads, load the data into the states SortedDictionary from states.txt
        /// Then start the quiz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuizWindow_Load(object sender, EventArgs e)
        {
            //Load state data into dictionary and add it to the ListBox in sorted order
            StreamReader reader = new StreamReader(@"../../State Data/states.txt");

            while(reader.Peek() != -1)
            {
                string[] fields = reader.ReadLine().Split(',');
                states.Add(fields[1], fields[0]);
                capitalsListBox.Items.Add(fields[0]);
            }
            capitalsListBox.Sorted = true;

            LoadImages();
            ShowRandomState();
        }

        /// <summary>
        /// Every second, if the time is > 1, decrement the timeLeft variable and update the label
        /// When the timer ticks and there is 1 left on it, decrement it and tell the user they ran out of time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //If time is up, disable the timer and the ListBox - otherwise, decrement the timer and update the label
            if(timeRemaining <= 1)
            {
                timeRemaining--;
                timeRemainingLabel.Text = $"{timeRemaining}";
                DisableControls();
                userFeedbackLabel.Text = $"You ran out of time! The answer is {states[stateNameLabel.Text]}";
                userFeedbackLabel.ForeColor = System.Drawing.Color.Red;
                userFeedbackLabel.Visible = true;
            } else
            {
                timeRemaining--;
                UpdateLabels();
            }
        }

        /// <summary>
        /// When something is selected, disable the text box
        /// Then, if it was correct, display correct
        /// If it was wrong, tell the user the correct answer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void capitalsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisableControls();
            if (states[stateNameLabel.Text] == (string)capitalsListBox.SelectedItem)
            {
                attempts++;
                correct++;
                userFeedbackLabel.Text = "Correct!";
                userFeedbackLabel.ForeColor = System.Drawing.Color.Green;
                userFeedbackLabel.Visible = true;
                UpdateLabels();
            } else
            {
                attempts++;
                userFeedbackLabel.Text = $"Incorrect! The correct answer is {states[stateNameLabel.Text]}";
                userFeedbackLabel.ForeColor = System.Drawing.Color.Red;
                userFeedbackLabel.Visible = true;
                UpdateLabels();
            }
        }

        /// <summary>
        /// Sets the labels to the values stored in the variables associated with those labels
        /// </summary>
        private void UpdateLabels()
        {
            timeRemainingLabel.Text = $"{timeRemaining}";
            attemptsLabel.Text = $"{attempts}";
            correctLabel.Text = $"{correct}";
        }

        /// <summary>
        /// Disables the Timer and ListBox
        /// </summary>
        private void DisableControls()
        {
            capitalsListBox.Enabled = false;
            timer1.Enabled = false;
        }

        /// <summary>
        /// Enables the Timer and ListBox
        /// </summary>
        private void EnableControls()
        {
            capitalsListBox.Enabled = true;
            timer1.Enabled = true;
        }

        /// <summary>
        /// Gets a random state from the dictionary and updates the label and picture for that state
        /// </summary>
        private void ShowRandomState()
        {
            //Get random state name and set the label to the random name
            string stateName = states.ElementAt(rand.Next(states.Count)).Key;
            stateNameLabel.Text = stateName;

            string stateImagePath = "";

            //Find the picture associated with the state and set the pictureBox to that picture
            foreach (var image in images)
            {
                if (image.Contains(stateName.Trim().Replace(" ", string.Empty)))
                {
                    stateImagePath = image;
                }
            }

            //Set the PictureBox's ImageLocation to the path of the state being displayed
            statePictureBox.ImageLocation = stateImagePath;
        }

        /// <summary>
        /// When the form is closed, display the goodbye message with the results from the quiz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuizWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuizResultsWindow quizResultsWindow = new QuizResultsWindow
            {
                attempts = attempts,
                correct = correct
            };
            DisableControls();
            quizResultsWindow.ShowDialog();
        }

        /// <summary>
        /// Gets all images in the State Pictures Folder and adds their paths to the images array
        /// </summary>
        private void LoadImages()
        {
            //Create a list of names of the current files in the State Pictures folder
            var currentDir = Directory.GetCurrentDirectory();
            var files = from file in Directory.GetFiles(currentDir + @"../../../State Pictures")
                        orderby file
                        select file;

            //Create an object of .NET's FileInfo class for each file in the list just created and put these in another list
            var fileInfo = from file in files
                           select new FileInfo(file);

            //Get the Path of each image and put results into another list
            var myFileInfo = from fileInfoItem in fileInfo
                             select new
                             {
                                 Path = fileInfoItem.Name
                             };

            //Add paths of each file to the images array
            int count = 0;
            foreach (var file in myFileInfo)
            {
                images[count] = @"../../State Pictures/" + file.Path;
                count++;
            }
        }
    }
}
