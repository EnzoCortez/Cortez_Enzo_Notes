namespace Notes.Models;

internal class About
{
    public string Title => AppInfo.Name;
    //public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://aka.ms/maui";
    public string Message => "Mucho gusto mi nombre es Enzo y soy estudiante de Ing. en software";
}