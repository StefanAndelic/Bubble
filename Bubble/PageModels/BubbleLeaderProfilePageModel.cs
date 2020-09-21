using Bubble.Models;
using FreshMvvm;

namespace Bubble.PageModels
{
    public class BubbleLeaderProfilePageModel : FreshBasePageModel
    {
        BubbleLeader _leader;




        public string language { get; set; }

        public string Language
        {
            get { return language; }
            set
            {

                language = value;
            }
        }

        public string hobbies { get; set; }

        public string Hobbies
        {
            get { return hobbies; }
            set
            {

                hobbies = value;
            }
        }

        public string image { get; set; }

        public string Image
        {
            get { return image; }
            set
            {

                image = value;
            }
        }


        public BubbleLeaderProfilePageModel(BubbleLeader leader)
        {
            _leader = leader;


        }

        public override void Init(object initData)
        {
            base.Init(initData);
            _leader = (BubbleLeader)initData;
            Image = _leader.ImageUrl;
            Language = _leader.Language;
            Hobbies = _leader.Hobbies;




        }


    }
}
