using CVPortfolio.Models;

namespace CVPortfolio.Services;

public class CVService
{
    public CVContent GetCV()
    {
        return new CVContent
        {
            PersonalInfo = new PersonalInfo(),
            Highlights = new List<string>
            {
                "Liderlik ve Organizasyon: SAEROTECH Teknofest Kulübü'nde Yönetim Kurulu Üyeliği, Eğitim Komitesi Başkanlığı ve Sosyal Etkinlik Komitesi Başkanlığı",
                "Web Geliştirme: Müşteri talepleri doğrultusunda işlevsel e-ticaret platformları ve web siteleri geliştirme tecrübesi",
                "Mobil Uygulama Geliştirme: Swift dilini kullanarak iOS platformu için mobil uygulamalar geliştirme",
                "Topluluk ve İletişim: Huawei Student Developers Kulübü'nde Sosyal Medya Komitesi'nde görev alma"
            },
            Educations = new List<Education>
            {
                new Education 
                { 
                    School = "SAKARYA ÜNİVERSİTESİ",
                    Program = "Bilgisayar Mühendisliği",
                    Years = "2022 - Devam Ediyor"
                },
                new Education 
                { 
                    School = "GO ACADEMY",
                    Program = "Yazılım Geliştirme Bootcamp",
                    Years = "2022 - 2023"
                },
                new Education 
                { 
                    School = "ERDEMLİ ANADOLU LİSESİ",
                    Program = "Lise",
                    Years = "2017 - 2021"
                }
            },
            VolunteerRoles = new List<string>
            {
                "SAEROTECH - Eğitim Komitesi Başkan Yardımcısı",
                "SAEROTECH - Yönetim Kurulu Üyesi",
                "SAEROTECH - Eğitim Komitesi Başkanı",
                "SAEROTECH - Sosyal Etkinlik Başkanı",
                "HUAWEI STUDENT DEVELOPERS - Sosyal Medya Komitesi"
            },
            Skills = new Skills(),
            Languages = new Languages()
        };
    }
}
