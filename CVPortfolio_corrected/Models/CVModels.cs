namespace CVPortfolio.Models;

public class CVContent
{
    public PersonalInfo PersonalInfo { get; set; } = new();
    public List<string> Highlights { get; set; } = new();
    public List<Education> Educations { get; set; } = new();
    public List<string> VolunteerRoles { get; set; } = new();
    public Skills Skills { get; set; } = new();
    public Languages Languages { get; set; } = new();
}

public class PersonalInfo
{
    public string FullName { get; set; } = "YUNUS EMRE SEVİNDİK";
    public string Title { get; set; } = "BİLGİSAYAR MÜHENDİSİ";
    public string Phone { get; set; } = "0 510 220 49 33";
    public string Email { get; set; } = "svndkyes33@gmail.com";
    public string LinkedIn { get; set; } = "linkedin.com/in/yunuseemre";
    public string GitHub { get; set; } = "github.com/yunuseemre";
}

public class Education
{
    public string School { get; set; } = string.Empty;
    public string Program { get; set; } = string.Empty;
    public string Years { get; set; } = string.Empty;
}

public class Skills
{
    public List<string> Languages { get; set; } = new()
    {
        "C#", "C++", "Java", "Swift", "JavaScript"
    };
    
    public List<string> Frameworks { get; set; } = new()
    {
        "ASP.NET Core", "Node.js", "React Native", "HTML", "CSS"
    };
    
    public List<string> Database { get; set; } = new()
    {
        "SQL"
    };
    
    public List<string> Technical { get; set; } = new()
    {
        "Git", "GitHub", "E-ticaret platformları", "iOS (SwiftUI, UIKit)"
    };
}

public class Languages
{
    public string English { get; set; } = "B1 Seviye";
    public string German { get; set; } = "A1 Seviye";
}
