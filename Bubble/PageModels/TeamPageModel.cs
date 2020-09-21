using System;
using System.Collections.ObjectModel;
using Bubble.Models;
using FreshMvvm;
using Xamarin.Forms;

namespace Bubble.PageModels
{
    public class TeamPageModel : FreshBasePageModel
    {

        private ObservableCollection<BubbleLeader> leaders;

        public ObservableCollection<BubbleLeader> Leaders
        {
            get { return leaders; }
            set
            {

                leaders = value;
            }
        }

        private BubbleLeader _selectedInstructor { get; set; }

        public BubbleLeader SelectedInstructor

        {
            get { return _selectedInstructor; }

            set
            {
                if (_selectedInstructor != value)
                {
                    _selectedInstructor = value;
                    GoToBubbleLeaderProfilePage();

                }

            }
        }
        public TeamPageModel()
        {

            Leaders = new ObservableCollection<BubbleLeader>() {
                new BubbleLeader()
                {

                    Name = "T",
                    Language = "Te Reo, English",
                    Hobbies = "Watching films",
                    Degree = "BA,Media in Politics",
                    ImageUrl="profilepicture.png",
                },

                new BubbleLeader()
                {

                    Name = "A",
                    Language = "English",
                    Hobbies = "Playing piano",
                    Degree = "BA,French and History",
                    ImageUrl="profilepicture.png",

                },

                new BubbleLeader()
                {

                    Name = "K",
                    Language = "English",
                    Hobbies = "Blogging",
                    Degree = "BSc,MSc,Psychology",
                    ImageUrl="profilepicture.png",
                },

                new BubbleLeader()
                {

                    Name = "R",
                    Language = "English",
                    Hobbies = "Listening to music",
                    Degree = "BSc,Psychology",
                    ImageUrl="profilepicture.png",
                },
                new BubbleLeader()
                {

                    Name = "K",
                    Language = "English",
                    Hobbies = "Drawing",
                    Degree = "BCom,Accounting",
                    ImageUrl="profilepicture.png",
                },

                new BubbleLeader()
                {

                    Name = "S",
                    Language = "English",
                    Hobbies = "basketball",
                    Degree = "BSc,Psycology and CS",
                    ImageUrl="profilepicture.png",
                },
            };
        }



        private void GoToBubbleLeaderProfilePage()
        {
            var user = SelectedInstructor;
            CoreMethods.PushPageModel<BubbleLeaderProfilePageModel>(user);

        }

    }
}
