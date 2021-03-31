using IntelligentOnlineCowboy.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace IntelligentOnlineCowboy
{
    public partial class MainWindow : Form
    {
        private List<ContestantModel> _contestants;
        private List<ContestantModel> _shotContestants;
        private List<TopicModel> _topics;
        private Random _random;

        public MainWindow()
        {
            _random = new Random();
            _shotContestants = new List<ContestantModel>();
            _contestants = new List<ContestantModel>();
            _topics = new List<TopicModel>();
            InitializeComponent();
            InitializeContestants();
            InitializeTopics();
        }

        private void InitializeTopics()
        {
            _topics.Clear();

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
            _contestants.Clear();

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

            TopicTextBox.Text = randomTopic.TopicName;

        }

        private ContestantModel GetRandomContestant()
        {
            return _contestants[_random.Next(_contestants.Count())];
        }

        private TopicModel GetRandomTopic()
        {
            return _topics[_random.Next(_topics.Count())];
        }

        private void EmptyFields()
        {
            TopContestantTextBox.Text = "";
            TopicTextBox.Text = "";
            BottomContestantTextBox.Text = "";
        }

        private void RefreshGraveyard()
        {
            GraveyardTextBox.Text = string.Join(", ", _shotContestants.Select(sc => sc.ContestantName));
        }

        private void EmptyGraveyard()
        {
            GraveyardTextBox.Text = "";
            _shotContestants.Clear();
        }

        private void CheckWinner()
        {
            if(_contestants.Count() == 1)
            {
                var winner = _contestants[0];

                MessageBox.Show($"{winner.ContestantName} lett a győztés és menekült meg az örült lövöldözőtől 🎉🎊", 
                    "Győztes", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);

                InitializeContestants();
                EmptyGraveyard();
            }
        }

        private void TopicTextBox_TextChanged(object sender, EventArgs e)
        {
            var hasTopic = !string.IsNullOrWhiteSpace(TopicTextBox.Text);

            TopContestantDogedButton.Visible = hasTopic;
            BottomContestantDogedButton.Visible = hasTopic;
        }

        private void TopContestantDogedButton_Click(object sender, EventArgs e)
        {
            var shotContestant = _contestants.First(c => c.Id == (Guid)BottomContestantTextBox.Tag);
            _shotContestants.Add(shotContestant);
            _contestants.Remove(shotContestant);

            EmptyFields();
            RefreshGraveyard();
            CheckWinner();
        }

        private void BottomContestantDogedButton_Click(object sender, EventArgs e)
        {
            var shotContestant = _contestants.First(c => c.Id == (Guid)TopContestantTextBox.Tag);
            _shotContestants.Add(shotContestant);
            _contestants.Remove(shotContestant);

            EmptyFields();
            RefreshGraveyard();
            CheckWinner();
        }
    }
}
