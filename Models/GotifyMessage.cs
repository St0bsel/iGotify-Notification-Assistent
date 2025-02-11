namespace iGotify_Notification_Assist;

public class GotifyMessage
{
    public int appid { get; set; }
    public string? date { get; set; }
    public int id { get; set; }
    public string? message { get; set; }
    public int priority { get; set; }
    public GotifyExtras? extras { get; set; }
    public string? title { get; set; }
}

public class GotifyExtras
{
    public ClientDisplay? clientdisplay { get; set; }
    public ClientNotification? clientnotification { get; set; }
    public ClientAndroidAction? androidaction { get; set; }
}

public class ClientDisplay
{
    public string? contentType { get; set; }
}

public class ClientNotification
{
    public string? bigImageUrl { get; set; }
    public ClientNotificationClick? click { get; set; }
}

public class ClientNotificationClick
{
    public string? url { get; set; }
}

public class ClientAndroidAction
{
    public ClientAndroidActionOnReceive? onReceive { get; set; }
}

public class ClientAndroidActionOnReceive
{
    public string? intentUrl { get; set; }
}