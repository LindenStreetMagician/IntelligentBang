using IntelligentOnlineCowboy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelligentOnlineCowboy
{
    public partial class MainWindow : Form
    {
        private List<ContestantModel> _contestants;
        private List<TopicModel> _topics;
        private Random _random;

        public MainWindow()
        {
            _random = new Random();
            InitializeComponent();
            InitializeContestants();
            InitializeTopics();
        }

        private void InitializeTopics()
        {
            _topics = new List<TopicModel>();

            string topicName;

            using (var sr = new StreamReader(@"./Topics.txt"))
            {
                while ((topicName = sr.ReadLine()) != null)
                {
                    _topics.Add(new TopicModel
                    {
                        TopicName = topicName
                    });
                }
            }
        }

        private void InitializeContestants()
        {
            _contestants = new List<ContestantModel>();

            string contestantName;

            using(var sr = new StreamReader(@"./Names.txt"))
            {
                while((contestantName = sr.ReadLine()) != null)
                {
                    _contestants.Add(new ContestantModel
                    {
                        ContestantName = contestantName
                    });
                }
            }
        }

        private void NextRoundButton_Click(object sender, EventArgs e)
        {
            var firstContestant = GetRandomContestant();
            var secondContestant = GetRandomContestant();

            while (firstContestant.ContestantName == secondContestant.ContestantName)
            {
                secondContestant = GetRandomContestant();
            }

            var randomTopic = GetRandomTopic();

            TopContestantTextBox.Text = firstContestant.ContestantName;
            TopContestantTextBox.Tag = firstContestant.Id;

            BottomContestantTextBox.Text = secondContestant.ContestantName;
            BottomContestantTextBox.Tag = secondContestant.Id;

            topicTextBox.Text = randomTopic.TopicName;

        }

        private ContestantModel GetRandomContestant()
        {
            return _contestants[_random.Next(_contestants.Count())];
        }

        private TopicModel GetRandomTopic()
        {
            return _topics[_random.Next(_topics.Count())];
        }
    }
}
