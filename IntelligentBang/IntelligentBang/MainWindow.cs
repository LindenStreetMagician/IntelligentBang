using IntelligentBang.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace IntelligentBang
{
    public partial class MainWindow : Form
    {
        private readonly List<ContestantModel> _contestants;
        private readonly List<ContestantModel> _shotContestants;
        private readonly List<TopicModel> _topics;
        private readonly Random _random;

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

            using (var sr = new StreamReader(@"./Data/Topics.txt"))
            {
                while ((topicName = sr.ReadLine()) != null)
                {
                    _topics.Add(new TopicModel
                    {
                        TopicName = topicName
                    });
                }
            }

            if (!_topics.Any())
            {
                MessageBox.Show("A Topics.txt nem tartalmaz egyetlen témát sem.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        private void InitializeContestants()
        {
            _contestants.Clear();

            string contestantName;

            using(var sr = new StreamReader(@"./Data/Names.txt"))
            {
                while((contestantName = sr.ReadLine()) != null)
                {
                    _contestants.Add(new ContestantModel
                    {
                        ContestantName = contestantName
                    });
                }
            }

            if (_contestants.Count() < 2)
            {
                MessageBox.Show("A Names.txt nem tartalmaz legalább 2 nevet.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
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
            TopicTextBox.Tag = randomTopic.Id;

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

                MessageBox.Show($"{winner.ContestantName} lett a győztés! 🎉🎊", 
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

        private void RemoveContestant(Guid contestantId)
        {
            var shotContestant = _contestants.First(c => c.Id == contestantId);
            _shotContestants.Add(shotContestant);
            _contestants.Remove(shotContestant);
        }

        private void RemoveTopic(Guid topicId)
        {
            var spentTopic = _topics.First(c => c.Id == topicId);
            _topics.Remove(spentTopic);

            if (!_topics.Any())
            {
                InitializeTopics();
            }
        }

        private void TopContestantDogedButton_Click(object sender, EventArgs e)
        {
            RemoveContestant((Guid)BottomContestantTextBox.Tag);
            EmptyFields();
            RefreshGraveyard();
            RemoveTopic((Guid)TopicTextBox.Tag);
            CheckWinner();
        }

        private void BottomContestantDogedButton_Click(object sender, EventArgs e)
        {
            RemoveContestant((Guid)TopContestantTextBox.Tag);
            EmptyFields();
            RefreshGraveyard();
            RemoveTopic((Guid)TopicTextBox.Tag);
            CheckWinner();
        }

        private void NewGameContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var dialogResult = MessageBox.Show("Újra szeretnéd indítani?", "Újraindítás", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                InitializeContestants();
                InitializeTopics();
                EmptyFields();
                EmptyGraveyard();
            }
        }
    }
}
