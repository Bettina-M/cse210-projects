using System.Reflection;
using System.Runtime.CompilerServices;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;


public class Video
{
    public string _title;
    public string _author;
    public int _videoLength;

    public List<Video> videos;


    public void DisplayVideo()
    {
        Console.WriteLine($"Video({_title}, {_author}, {_videoLength} seconds)");
    }

    public void VideoComments()
    {
        List<Video> videos = new List<Video> ();
        Video myvideo1 = new Video();
        myvideo1._title = "How to style your hair";
        myvideo1._author = "Bettina Menya";
        myvideo1._videoLength= 3000;
        
        videos.Add(myvideo1);
       
        Video myVideo2 = new Video();
        myVideo2._title = "Easiest Pizza Recipe";
        myVideo2._author = "Willis Ochieng";
        myVideo2._videoLength = 1000;

        videos.Add(myVideo2);
       
        Video myVideo3 = new Video();
        myVideo3._title= "Seeking personal revelation";
        myVideo3._author = "Russel.M Nelson";
        myVideo3._videoLength = 2000;
        
        videos.Add(myVideo3);
        foreach (var item in  videos)
       {
            item.DisplayVideo();
            
            List <Comments>_comments = new List<Comments>();
            
            if (item._title == "How to style your hair" )
            {
            
            _comments.Add(new Comments{_name ="Mary",_text ="I will try this method today"});
            _comments.Add(new Comments{_name ="Brenda",_text ="Looks Wow!"});
            _comments.Add(new Comments{_name = "Nancy", _text ="Wonderful!"});
            }

            if (item._title =="Easiest Pizza Recipe" )
            {
            _comments.Add(new Comments{_name ="Brian",_text ="Yummy Pizza!"});
            _comments.Add(new Comments{_name ="John",_text ="Share the amount of Ingridients"});
            _comments.Add(new Comments{_name ="Anna",_text ="Which cheese did you use? "});

            }

            if (item._title == "Seeking personal revelation")
            {
            _comments.Add(new Comments{_name ="June",_text ="Inspiring!"});
            _comments.Add(new Comments{_name ="Adam",_text ="You're amazing!"});
            _comments.Add(new Comments{_name ="Lucy",_text ="Amazing talk!"});
            _comments.Add(new Comments{_name ="Rachel",_text ="Amazing talk!"});

            }
            Console.WriteLine($"Number of Comments {_comments.Count()}");
            
            
            
            
            foreach (var line in _comments)
            {
                
                line.DisplayComments();
            }

       }
    }


}


public class Comments
{
   public  List <Comments> _comments;
   public  string _name;
   public string _text;



   public void DisplayComments()
   {
       Console.WriteLine($"{_name} commented - {_text}");
   }


}