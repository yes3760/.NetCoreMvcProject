using System.ComponentModel.DataAnnotations;

namespace CvSiteNet9_Modern.Models
{
    public class Resume
    {
        [Required] public string Name { get; set; } = "";
        [Required] public string Title { get; set; } = "";
        public string? Summary { get; set; }
        public string? Location { get; set; }
        [EmailAddress] public string? Email { get; set; }
        public string? Phone { get; set; }
        public SocialLinks Social { get; set; } = new();
        public List<SkillSection> Skills { get; set; } = new();
        public List<string> Highlights { get; set; } = new();
        public List<Metric> Metrics { get; set; } = new();
        public List<FocusArea> FocusAreas { get; set; } = new();
        public List<Experience> Experiences { get; set; } = new();
        public List<Education> Educations { get; set; } = new();
        public List<Project> Projects { get; set; } = new();
        public List<LanguageSkill> Languages { get; set; } = new();
        public string? ReferenceNote { get; set; }
    }

    public class SocialLinks
    {
        public string? Github { get; set; }
        public string? LinkedIn { get; set; }
        public string? Website { get; set; }
        public string? X { get; set; }
    }

    public class SkillSection
    {
        public string Heading { get; set; } = "";
        public List<string> Items { get; set; } = new();
    }

    public class Experience
    {
        public string Company { get; set; } = "";
        public string Role { get; set; } = "";
        public string Start { get; set; } = "";
        public string? End { get; set; }
        public string Location { get; set; } = "";
        public List<string> Highlights { get; set; } = new();
    }

    public class Education
    {
        public string School { get; set; } = "";
        public string Degree { get; set; } = "";
        public string Years { get; set; } = "";
        public string? Detail { get; set; }
    }

    public class Project
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public List<string>? Tech { get; set; }
        public string? Url { get; set; }
        public string? Repo { get; set; }
    }

    public class Metric
    {
        public string Value { get; set; } = "";
        public string Label { get; set; } = "";
    }

    public class FocusArea
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
    }

    public class LanguageSkill
    {
        public string Name { get; set; } = "";
        public string Level { get; set; } = "";
    }

    public class ContactMessage
    {
        [Required, StringLength(100)] public string Name { get; set; } = "";
        [Required, EmailAddress] public string Email { get; set; } = "";
        [Required, StringLength(2000)] public string Message { get; set; } = "";
    }

    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
