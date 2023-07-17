namespace oopadv;

public class English : Language
{
    public English() {
        Chooseyourname = "Hello, what is your name?";
        Defaultname = "en";
        Welcome = "welcome {0} to your oop adventure";
        DefaultRoomname = "Room {0} ({1}, {2})";
        DefaultRoomDescription = " You are in a {0} room with doors to the {1}.";
        ActionError = "you aint cant do that";
        Go = "Go";
        GoError = "cant go that way";
        Whattodo = "what u want to do";
        Quit = "quit";
        Roomnew = "YOu entered {0}";
        Roomold = "You return to {0}";
        And = "and";
        Comma = ",";
        Space = " ";
        Roomdescription = new List<string>
        {
            "normal",
            "cold",
            "warm",
            "dark",
            "bright",
            "scary",
            "strange"
        };
            }
}