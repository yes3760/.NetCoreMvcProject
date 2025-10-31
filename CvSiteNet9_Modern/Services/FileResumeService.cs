using System.Text.Json;
using CvSiteNet9_Modern.Models;

namespace CvSiteNet9_Modern.Services
{
    public class FileResumeService : IResumeService
    {
        private readonly IWebHostEnvironment _env;
        private readonly ILogger<FileResumeService> _logger;
        private Resume? _cache;
        private readonly object _lock = new();

        public FileResumeService(IWebHostEnvironment env, ILogger<FileResumeService> logger)
        {
            _env = env;
            _logger = logger;
        }

        public Resume Get()
        {
            if (_cache != null) return _cache;

            lock (_lock)
            {
                if (_cache != null) return _cache;

                var path = Path.Combine(_env.WebRootPath ?? "wwwroot", "data", "resume.json");
                if (!File.Exists(path))
                {
                    _logger.LogWarning("resume.json not found at {Path}. Returning minimal resume.", path);
                    return new Resume { Name = "Ad Soyad", Title = "Pozisyon" };
                }

                var json = File.ReadAllText(path);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var resume = JsonSerializer.Deserialize<Resume>(json, options) ?? new Resume();
                _cache = resume;
                return resume;
            }
        }
    }
}
